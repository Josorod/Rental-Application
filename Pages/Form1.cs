using RentalBuildingApplication.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalBuildingApplication
{
    public partial class FormLogin : Form
    {
        MainForm main = new MainForm();
        public bool userORadmin;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Acess granted as admin");
                
                this.Hide();
                main.Show();
                userORadmin = true;
            }
            else if (username == "user" && password == "1234")
            {
                MessageBox.Show("Acess granted as user");
                
                this.Hide();
                main.Show();
                main.buttonOrendar.Enabled = false;
                main.buttonAddRoom.Enabled = false;
                userORadmin = false;

            }
            else {
                MessageBox.Show("Acess failed");
                textBox1.Text = textBox2.Text = "";
            }
        }

        private void buttonCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
