using System;
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
    public partial class StaffDashBoard : Form
    {
        public StaffDashBoard(string strTextBox)
        {
            InitializeComponent();
            username.Text = strTextBox;
        }

        String messageTitle = "Log Out";
        String confirmationMessage = "Are you sure you want to logout?";

        MessageBoxButtons btnType = MessageBoxButtons.YesNo;

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(confirmationMessage, messageTitle, btnType, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Form loginUI = new Form1();
                loginUI.Show();
                this.Hide();
            }
        }

        private void customerViewButton_Click(object sender, EventArgs e)
        {
            CustomerDashBoard cs = new CustomerDashBoard();
            panelShow.Controls.Clear();
            cs.TopLevel = false;
            panelShow.Controls.Add(cs);
            cs.Show();
        }

        private void reportViewButton_Click(object sender, EventArgs e)
        {
            ReportDashboard rs = new ReportDashboard();
            panelShow.Controls.Clear();
            rs.TopLevel = false;
            panelShow.Controls.Add(rs);
            rs.Show();
        }
    }
}
