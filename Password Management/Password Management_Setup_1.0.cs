using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Password_Management
{
    [RunInstaller(true)]
    public partial class Password_Management_Setup_1 : System.Configuration.Install.Installer
    {
        public Password_Management_Setup_1()
        {
            InitializeComponent();
        }
    }
}
