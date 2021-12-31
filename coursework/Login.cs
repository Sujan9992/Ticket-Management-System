using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String errorTitle = "Error Found";
        String emptyUsernameMessage = "Please do not leave the username field empty.";
        String emptyPasswordMessage = "Please do not leave the password field empty.";
        String emptyMessage = "Please enter your username and password.";
        String incorrectCredentials = "Please provide correct username or password.";

        MessageBoxButtons okButton = MessageBoxButtons.OK;

        Hashtable admin = new Hashtable() {
                                      {"admin1", "admin1"},
                                          {"admin2", "admin2"}
                                       };
        Hashtable staff = new Hashtable() {
                                      {"staff1", "staff1"},
                                          {"staff2", "staff2"},
                                          {"staff3", "staff3"}
                                       };
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "" && passwordText.Text == "")
            {
                DialogResult result1 = MessageBox.Show(emptyMessage, errorTitle, okButton, MessageBoxIcon.Error);
                if (result1 == DialogResult.OK)
                {
                    usernameText.Focus();
                }
            }
            else if (usernameText.Text == "")
            {
                DialogResult result2 = MessageBox.Show(emptyUsernameMessage, errorTitle, okButton, MessageBoxIcon.Error);
                if (result2 == DialogResult.OK)
                {
                    usernameText.Focus();
                }
            }
            else if (passwordText.Text == "")
            {
                DialogResult result3 = MessageBox.Show(emptyPasswordMessage, errorTitle, okButton, MessageBoxIcon.Error);
                if (result3 == DialogResult.OK)
                {
                    passwordText.Focus();
                }
            }
            else {
                if (admin.ContainsKey(usernameText.Text))
                {
                    if ((String)admin[usernameText.Text] == passwordText.Text)
                    {
                        Form adminUI = new AdminDashboard(usernameText.Text);
                        adminUI.Show();
                        this.Hide();
                    }
                    else {
                        DialogResult result4 = MessageBox.Show(incorrectCredentials, errorTitle, okButton, MessageBoxIcon.Error);
                        if (result4 == DialogResult.OK)
                        {
                            usernameText.Focus();
                        }
                    }
                }
                else if (staff.ContainsKey(usernameText.Text))
                {
                    if ((String)staff[usernameText.Text] == passwordText.Text)
                    {
                        Form staffUI = new StaffDashBoard(usernameText.Text);
                        staffUI.Show();
                        this.Hide();
                    }
                    else {
                        DialogResult result5 = MessageBox.Show(incorrectCredentials, errorTitle, okButton, MessageBoxIcon.Error);
                        if (result5 == DialogResult.OK)
                        {
                            usernameText.Focus();
                        }
                    }
                }
                else
                {
                    DialogResult result6 = MessageBox.Show(incorrectCredentials, errorTitle, okButton, MessageBoxIcon.Error);
                    if (result6 == DialogResult.OK)
                    {
                        usernameText.Focus();
                    }
                }
            }
          
        }
    }
}
