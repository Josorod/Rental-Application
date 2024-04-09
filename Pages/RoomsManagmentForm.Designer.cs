
namespace RentalBuildingApplication.Pages
{
    partial class RoomsManagmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsManagmentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRoomSquare = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonClearRoom = new System.Windows.Forms.Button();
            this.buttonCancelRoom = new System.Windows.Forms.Button();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIsAvailable = new System.Windows.Forms.ComboBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIsAvailable);
            this.groupBox1.Controls.Add(this.comboBoxRoomType);
            this.groupBox1.Controls.Add(this.textBoxRoomSquare);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxRoomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RoomManagment";
            // 
            // textBoxRoomSquare
            // 
            this.textBoxRoomSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRoomSquare.Location = new System.Drawing.Point(128, 80);
            this.textBoxRoomSquare.Name = "textBoxRoomSquare";
            this.textBoxRoomSquare.Size = new System.Drawing.Size(170, 26);
            this.textBoxRoomSquare.TabIndex = 1;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRoomNumber.Location = new System.Drawing.Point(128, 33);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(170, 26);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RoomType :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Square :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoom.Image")));
            this.pictureBoxRoom.Location = new System.Drawing.Point(12, 417);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(299, 121);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoom.TabIndex = 1;
            this.pictureBoxRoom.TabStop = false;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(53, 268);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(105, 62);
            this.buttonAddRoom.TabIndex = 2;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonClearRoom
            // 
            this.buttonClearRoom.Location = new System.Drawing.Point(164, 268);
            this.buttonClearRoom.Name = "buttonClearRoom";
            this.buttonClearRoom.Size = new System.Drawing.Size(105, 62);
            this.buttonClearRoom.TabIndex = 2;
            this.buttonClearRoom.Text = "Clear";
            this.buttonClearRoom.UseVisualStyleBackColor = true;
            this.buttonClearRoom.Click += new System.EventHandler(this.buttonClearRoom_Click);
            // 
            // buttonCancelRoom
            // 
            this.buttonCancelRoom.Location = new System.Drawing.Point(107, 336);
            this.buttonCancelRoom.Name = "buttonCancelRoom";
            this.buttonCancelRoom.Size = new System.Drawing.Size(105, 62);
            this.buttonCancelRoom.TabIndex = 2;
            this.buttonCancelRoom.Text = "Cancel";
            this.buttonCancelRoom.UseVisualStyleBackColor = true;
            this.buttonCancelRoom.Click += new System.EventHandler(this.buttonCancelRoom_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnRoomNumber,
            this.ColumnSquare,
            this.ColumnTypeId,
            this.ColumnAvailable,
            this.ColumnTypeName,
            this.edit,
            this.delete});
            this.dataGridViewRoom.Location = new System.Drawing.Point(365, 22);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1051, 516);
            this.dataGridViewRoom.TabIndex = 3;
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Flat",
            "Office",
            "Storage",
            "Cottege"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(128, 128);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(170, 28);
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "IsAvailable :";
            // 
            // comboBoxIsAvailable
            // 
            this.comboBoxIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxIsAvailable.FormattingEnabled = true;
            this.comboBoxIsAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxIsAvailable.Location = new System.Drawing.Point(128, 175);
            this.comboBoxIsAvailable.Name = "comboBoxIsAvailable";
            this.comboBoxIsAvailable.Size = new System.Drawing.Size(170, 28);
            this.comboBoxIsAvailable.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 125;
            // 
            // ColumnRoomNumber
            // 
            this.ColumnRoomNumber.HeaderText = "RoomNumber";
            this.ColumnRoomNumber.MinimumWidth = 6;
            this.ColumnRoomNumber.Name = "ColumnRoomNumber";
            this.ColumnRoomNumber.Width = 125;
            // 
            // ColumnSquare
            // 
            this.ColumnSquare.HeaderText = "RoomSquare";
            this.ColumnSquare.MinimumWidth = 6;
            this.ColumnSquare.Name = "ColumnSquare";
            this.ColumnSquare.Width = 125;
            // 
            // ColumnTypeId
            // 
            this.ColumnTypeId.HeaderText = "TypeId";
            this.ColumnTypeId.MinimumWidth = 6;
            this.ColumnTypeId.Name = "ColumnTypeId";
            this.ColumnTypeId.Width = 125;
            // 
            // ColumnAvailable
            // 
            this.ColumnAvailable.HeaderText = "isAvailable";
            this.ColumnAvailable.MinimumWidth = 6;
            this.ColumnAvailable.Name = "ColumnAvailable";
            this.ColumnAvailable.Width = 125;
            // 
            // ColumnTypeName
            // 
            this.ColumnTypeName.HeaderText = "Type";
            this.ColumnTypeName.MinimumWidth = 6;
            this.ColumnTypeName.Name = "ColumnTypeName";
            this.ColumnTypeName.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // RoomsManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 550);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.buttonCancelRoom);
            this.Controls.Add(this.buttonClearRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.pictureBoxRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomsManagmentForm";
            this.Text = "RoomsManagment";
            this.Load += new System.EventHandler(this.RoomsManagmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomSquare;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonClearRoom;
        private System.Windows.Forms.Button buttonCancelRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.ComboBox comboBoxIsAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}