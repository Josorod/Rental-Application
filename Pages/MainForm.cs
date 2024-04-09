using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalBuildingApplication.Pages
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }


        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            RoomsManagmentForm roomform = new RoomsManagmentForm();
            roomform.Show();
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOrendar_Click(object sender, EventArgs e)
        {
            
           OrendarManagmentForm orendarForm = new OrendarManagmentForm();
            orendarForm.Show();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            Rent rentForm = new Rent();
            rentForm.Show();
        }
    }
}
