using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Password_Management
{
    public partial class Form1 : Form
    {
        public struct Data
        {
            public string Title;
            public string Account;
            public string Password;
        }

        public string title, account, password,path;
        public List<Data> datalist = new List<Data>();

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        public void Form1_Load()
        {
            FileStream Config = new FileStream("Config.txt",FileMode.OpenOrCreate);
            StreamReader config = new StreamReader(Config);
            path = config.ReadLine();
            if(path==null)
            {
                path = Interaction.InputBox("Please input a storage path:", "Path");
                path = path + "\\data.txt";
                StreamWriter reconfig = new StreamWriter(Config);
                reconfig.BaseStream.Seek(0, SeekOrigin.Begin);
                reconfig.Write(path);
                reconfig.Close();
            }
            config.Close();
            Config.Close();
            try
            {
                FileStream list = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader listRead = new StreamReader(list);
                string line;
                while ((line = listRead.ReadLine()) != null)
                {
                    string[] str = line.Split(' ');
                    Data data;
                    data.Title = str[0];
                    data.Account = str[1];
                    data.Password = str[2];
                    datalist.Add(data);
                }
                listRead.Close();
                list.Close();
                Remove.Enabled = false;
                Change.Enabled = false;
            }
            catch(ArgumentException)
            {
                this.Close();
            }
        }

        private void TitleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TitleList.SelectedIndex!=-1)
            {
                string title = TitleList.SelectedItem.ToString();
                foreach (Data item in datalist)
                {
                    if (item.Title == title)
                    {
                        Account.Text = item.Account;
                        Password.Text = item.Password;
                        break;
                    }
                }
                Remove.Enabled = true;
                Change.Enabled = true;
            }
            else
            {
                Account.Text = "";
                Password.Text = "";
                Remove.Enabled = false;
                Change.Enabled = false;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Account.Text = "";
            Password.Text = "";
            refresh();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string selected = TitleList.SelectedItem.ToString();
            for (int i = 0; i < datalist.Count; i++)
            {
                if (datalist[i].Title == selected)
                {
                    Add add = new Password_Management.Add(datalist[i]);
                    add.Text = "Change";
                    add.ShowDialog(this);
                    datalist.RemoveAt(i);
                    break;
                }
            }
            Data data = new Data();
            data.Title = title;
            data.Account = account;
            data.Password = password;
            datalist.Add(data);
            Account.Text = "";
            Password.Text = "";
            refresh();
            save(path);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string title = TitleList.SelectedItem.ToString();
            for(int i=0;i<datalist.Count;i++)
            {
                if (datalist[i].Title == title)
                {
                    Account.Text = "";
                    Password.Text = "";
                    datalist.RemoveAt(i);
                    break;
                }
            }
            refresh();
            save(path);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Data data=new Data();
            Add add = new Password_Management.Add();
            add.ShowDialog(this);
            if( title.Length > 0 && account.Length > 0 && password.Length > 0 )
            {
                TitleList.Items.Add(title);
                //写入列表
                data.Title = title;
                data.Account = account;
                data.Password = password;
                datalist.Add(data);
                save(path);
            }
        }

        public void save(string path)
        {
            FileStream list = new FileStream(path, FileMode.Create);
            StreamWriter listAdd = new StreamWriter(list);
            listAdd.BaseStream.Seek(0, SeekOrigin.Begin);
            foreach(Data item in datalist)
            {
                listAdd.Write(item.Title + " ");
                listAdd.Write(item.Account + " ");
                listAdd.Write(item.Password);
                listAdd.Write("\n");
            }
            listAdd.Close();
            list.Close();
        }

        public void refresh()
        {
            if (TitleList.Items.Count > 0)
            {
                TitleList.Items.Clear();
            }
            foreach (Data item in datalist)
            {
                TitleList.Items.Add(item.Title);
            }
            Remove.Enabled = false;
            Change.Enabled = false;
        }
    }
}
