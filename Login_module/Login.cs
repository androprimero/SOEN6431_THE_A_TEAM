using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicManagementSystem.UserInterface;

namespace AcademicManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        private void Login_button_Click(object sender, EventArgs e)
        {
            ValidateLoginIn();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateLoginIn();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateLoginIn();
            }
        }


        private void ValidateLoginIn()
        {
            if (ValidateRequiredFields())
                {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    //Student_form std = new Student_form();
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Sorry, but the credentials you have provided seems to be incorrect";
                }
            }
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()) ||
               string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                lblError.Text = "Sorry, but you should provide both username and password";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
