using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Management
{
    public partial class Add : Form
    {
        public string title="", account="", password="";

        public Add()
        {
            InitializeComponent();
        }

        public Add(Form1.Data data)
        {
            InitializeComponent();
            this.Title.Text= title = data.Title;
            this.Account.Text = account = data.Account;
            this.Password.Text = password = data.Password;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)this.Owner;
            MainForm.title = title;
            MainForm.account = account;
            MainForm.password = password;
            this.Close();
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if(Title.TextLength>0&&Account.TextLength>0&&Password.TextLength>0)
            {
                Form1 MainForm = (Form1)this.Owner;
                MainForm.title = Title.Text;
                MainForm.account = Account.Text;
                MainForm.password = Password.Text;
                MessageBox.Show("Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incomplete information!");
            }
        }
    }
}
