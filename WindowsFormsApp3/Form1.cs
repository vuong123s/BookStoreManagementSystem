using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public Form1()
        {
            InitializeComponent();
            
        }


        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '●';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            Home home = new Home();
            home.Show();/*
            regForm.Show();*/
            this.Hide();
        }
    }
}
