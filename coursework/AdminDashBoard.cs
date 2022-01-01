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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(string strTextBox)
        {
            InitializeComponent();
            username.Text = strTextBox;
        }

        String messageTitle = "Log Out";
        String confirmationMessage = "Are you sure you want to logout?";

        MessageBoxButtons btnType = MessageBoxButtons.YesNo;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

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

        private void ticketViewButton_Click(object sender, EventArgs e)
        {
            TicketDashboard ticket = new TicketDashboard();
            mainPanel.Controls.Clear();
            ticket.TopLevel = false;
            mainPanel.Controls.Add(ticket);
            ticket.Show();
        }
    }
}
