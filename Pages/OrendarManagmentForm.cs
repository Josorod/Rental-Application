using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Globalization;
using System.Data.Entity.Core.Metadata.Edm;

namespace RentalBuildingApplication.Pages
{
    public partial class OrendarManagmentForm : Form
    {
        public OrendarManagmentForm()
        {
            InitializeComponent();
            AutoRoomNumber();
            LoadTableRooms();
        }
        SqlConnection con = new SqlConnection(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=RentalBuildingApplication.Models.RentalContext;");
        SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool mode = true;
        string id;

        public void AutoRoomNumber()
        {
            sql = "select Id from Orendar order by Id desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("0");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = "1";
            }
            else
            {
                proid = "1";
            }

            textBoxOrendarId.Text = proid.ToString();

            con.Close();
        }

        private void buttonAddOrendar_Click(object sender, EventArgs e)
        {
            string companyName = textBoxCompanyName.Text;
            string yutAdress = textBoxYurAdress.Text;
            string BankName = textBoxBankName.Text;
            string directorName = textBoxDirector.Text;
            string characteristic = textBoxChar.Text;
           
            if (mode == true)
            {
                sql = "insert Orendar(CompanyName,YurAdress,BankName,DirecorName,Characteristic)values(@CompanyName,@YurAdress,@BankName,@DirecorName,@Characteristic)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@CompanyName", companyName);
                cmd.Parameters.AddWithValue("@YurAdress", yutAdress);
                cmd.Parameters.AddWithValue("@BankName", BankName);
                cmd.Parameters.AddWithValue("@DirecorName", directorName);
                cmd.Parameters.AddWithValue("@Characteristic", characteristic);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Added");
                ClearTextBoxes();
            }
            else
            {
                sql = "update Orendar set CompanyName = @CompanyName, YurAdress = @YurAdress, BankName = @BankName,DirecorName = @DirecorName,Characteristic = @Characteristic where Id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@CompanyName", companyName);
                cmd.Parameters.AddWithValue("@YurAdress", yutAdress);
                cmd.Parameters.AddWithValue("@BankName", BankName);
                cmd.Parameters.AddWithValue("@DirecorName", directorName);
                cmd.Parameters.AddWithValue("@Characteristic", characteristic);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated");
                buttonAddOrendar.Text = "AddOrendar";
                textBoxOrendarId.Enabled = true;
                mode = true;
                ClearTextBoxes();
            }

            con.Close();
            LoadTableRooms();
            AutoRoomNumber();
        }
        public void LoadTableRooms()
        {
            sql = "select * from Orendar";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            con.Close();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public void getid(string id)
        {
            sql = "select * from orendar where id = '" + id + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxCompanyName.Text = dr[1].ToString();
                textBoxYurAdress.Text = dr[2].ToString();
                textBoxBankName.Text = dr[3].ToString();
                textBoxDirector.Text = dr[4].ToString();
                textBoxChar.Text = dr[5].ToString();

            }
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                mode = false;
                buttonAddOrendar.Text = "Edit";
                textBoxOrendarId.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Orendar where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                con.Close();
                LoadTableRooms();
                AutoRoomNumber();
            }
        }
    }
}
