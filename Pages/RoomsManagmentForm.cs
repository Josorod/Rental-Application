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
using System.Globalization;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentalBuildingApplication.Pages
{
    public partial class RoomsManagmentForm : Form
    {
        public RoomsManagmentForm()
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
            sql = "select RoomNumber from Room order by Id desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("0000000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = "0000000";

            }
            else {
                proid = "0000000";
            }

            textBoxRoomNumber.Text = proid.ToString();

            con.Close();
        }

        public void LoadTableRooms()
        {
            sql = "select * from Room";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridViewRoom.Rows.Clear();

            while (dr.Read())
            {
                dataGridViewRoom.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            con.Close();
        }

        public void getid(string id)
        {
            sql = "select * from room where id = '" +id + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxRoomNumber.Text = dr[1].ToString();
                textBoxRoomSquare.Text = dr[2].ToString();
                comboBoxRoomType.SelectedItem = dr[4].ToString();
                comboBoxIsAvailable.SelectedItem = dr[5].ToString();

            }
            con.Close();
        }
        private void RoomsManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = textBoxRoomNumber.Text;
            double roomSquare = double.Parse(textBoxRoomSquare.Text, CultureInfo.InvariantCulture);
            string isAvailable = comboBoxIsAvailable.SelectedItem.ToString();
            string roomType = comboBoxRoomType.SelectedItem.ToString();
            int roomTypeId = 0;
            id = dataGridViewRoom.CurrentRow.Cells[0].Value.ToString();

            switch (comboBoxRoomType.SelectedItem.ToString())
            {
                case "Flat":
                    @roomTypeId = 1;
                    break;
                case "Office":
                    @roomTypeId = 2;
                    break;
                case "Storage":
                    @roomTypeId = 3;
                    break;
                case "Cottege":
                    @roomTypeId = 4;
                    break;
            }

            if (mode == true)
            {
                sql = "insert Room(RoomNumber,RoomSquare,IsAvailable,TypeName,TypeId)values(@RoomNumber,@RoomSquare,@IsAvailable,@TypeName,@TypeId)";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                cmd.Parameters.AddWithValue("@RoomSquare", roomSquare);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);
                cmd.Parameters.AddWithValue("@TypeName", roomType);
                cmd.Parameters.AddWithValue("@TypeId", roomTypeId);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Record Added");
                textBoxRoomSquare.Clear();
                comboBoxIsAvailable.Items.Clear();
                comboBoxRoomType.Items.Clear();
                textBoxRoomNumber.Clear();
                
            }
            else {
                sql = "update Room set RoomSquare = @RoomSquare, IsAvailable = @IsAvailable, TypeName = @TypeName,TypeId = @TypeId where RoomNumber = @RoomNumber";
                con.Open();
                cmd = new SqlCommand(sql, con);

               
                cmd.Parameters.AddWithValue("@RoomSquare", roomSquare);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);
                cmd.Parameters.AddWithValue("@TypeName", roomType);
                cmd.Parameters.AddWithValue("@TypeId", roomTypeId);
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated");
                buttonAddRoom.Text = "AddRoom";
                textBoxRoomNumber.Enabled = true;
                mode = true;

                textBoxRoomSquare.Clear();
                comboBoxIsAvailable.Items.Clear();
                comboBoxRoomType.Items.Clear();
                textBoxRoomNumber.Clear();
               
            }
            
            con.Close();
            LoadTableRooms();
            AutoRoomNumber();

        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRoom.Columns["edit"].Index && e.RowIndex >= 0)
            {
                mode = false;
                buttonAddRoom.Text = "Edit";
                textBoxRoomNumber.Enabled = false;
                id = dataGridViewRoom.CurrentRow.Cells[0].Value.ToString();

                getid(id);
            }
            else if (e.ColumnIndex == dataGridViewRoom.Columns["delete"].Index && e.RowIndex >= 0)
            {
                mode = false;
                id = dataGridViewRoom.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Room where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id );
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                con.Close();
                LoadTableRooms();
                AutoRoomNumber();
            }
        }

        private void buttonClearRoom_Click(object sender, EventArgs e)
        {
            textBoxRoomSquare.Clear();
            comboBoxIsAvailable.Items.Clear();
            comboBoxRoomType.Items.Clear();
            textBoxRoomNumber.Clear();
            AutoRoomNumber();
        }

        private void buttonCancelRoom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
