
namespace RentalBuildingApplication.Pages
{
    partial class Rent
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
            this.groupBoxRent = new System.Windows.Forms.GroupBox();
            this.labelavailable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoomId = new System.Windows.Forms.ComboBox();
            this.textBoxOrendarId = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonAddRent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompaanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRent
            // 
            this.groupBoxRent.Controls.Add(this.buttonAddRent);
            this.groupBoxRent.Controls.Add(this.labelavailable);
            this.groupBoxRent.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxRent.Controls.Add(this.dateTimePickerStart);
            this.groupBoxRent.Controls.Add(this.textBoxPrice);
            this.groupBoxRent.Controls.Add(this.textBoxCompanyName);
            this.groupBoxRent.Controls.Add(this.textBoxOrendarId);
            this.groupBoxRent.Controls.Add(this.comboBoxRoomId);
            this.groupBoxRent.Controls.Add(this.label7);
            this.groupBoxRent.Controls.Add(this.label2);
            this.groupBoxRent.Controls.Add(this.label6);
            this.groupBoxRent.Controls.Add(this.label5);
            this.groupBoxRent.Controls.Add(this.label4);
            this.groupBoxRent.Controls.Add(this.label3);
            this.groupBoxRent.Location = new System.Drawing.Point(16, 16);
            this.groupBoxRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRent.Name = "groupBoxRent";
            this.groupBoxRent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxRent.Size = new System.Drawing.Size(491, 689);
            this.groupBoxRent.TabIndex = 0;
            this.groupBoxRent.TabStop = false;
            this.groupBoxRent.Text = "Rent";
            // 
            // labelavailable
            // 
            this.labelavailable.AutoSize = true;
            this.labelavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelavailable.Location = new System.Drawing.Point(10, 484);
            this.labelavailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelavailable.Name = "labelavailable";
            this.labelavailable.Size = new System.Drawing.Size(91, 20);
            this.labelavailable.TabIndex = 0;
            this.labelavailable.Text = "Available : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RoomId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "OrendarId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(8, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "CompanyName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(10, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "DateStart";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(10, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "DateFinish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price(m2)";
            // 
            // comboBoxRoomId
            // 
            this.comboBoxRoomId.FormattingEnabled = true;
            this.comboBoxRoomId.Location = new System.Drawing.Point(198, 48);
            this.comboBoxRoomId.Name = "comboBoxRoomId";
            this.comboBoxRoomId.Size = new System.Drawing.Size(253, 28);
            this.comboBoxRoomId.TabIndex = 1;
            // 
            // textBoxOrendarId
            // 
            this.textBoxOrendarId.Location = new System.Drawing.Point(198, 116);
            this.textBoxOrendarId.Name = "textBoxOrendarId";
            this.textBoxOrendarId.Size = new System.Drawing.Size(253, 26);
            this.textBoxOrendarId.TabIndex = 2;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(198, 193);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(253, 26);
            this.textBoxCompanyName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(198, 255);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(253, 26);
            this.textBoxPrice.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(198, 326);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(253, 26);
            this.dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(198, 396);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(253, 26);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // buttonAddRent
            // 
            this.buttonAddRent.Location = new System.Drawing.Point(7, 605);
            this.buttonAddRent.Name = "buttonAddRent";
            this.buttonAddRent.Size = new System.Drawing.Size(198, 77);
            this.buttonAddRent.TabIndex = 4;
            this.buttonAddRent.Text = "Add";
            this.buttonAddRent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRoomId,
            this.ColumnOrendar,
            this.ColumnCompaanyName,
            this.ColumnPrice,
            this.ColumnDateStart,
            this.ColumnDateEnd});
            this.dataGridView1.Location = new System.Drawing.Point(514, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnRoomId
            // 
            this.ColumnRoomId.HeaderText = "RoomId";
            this.ColumnRoomId.MinimumWidth = 6;
            this.ColumnRoomId.Name = "ColumnRoomId";
            this.ColumnRoomId.Width = 125;
            // 
            // ColumnOrendar
            // 
            this.ColumnOrendar.HeaderText = "OrendarId";
            this.ColumnOrendar.MinimumWidth = 6;
            this.ColumnOrendar.Name = "ColumnOrendar";
            this.ColumnOrendar.Width = 125;
            // 
            // ColumnCompaanyName
            // 
            this.ColumnCompaanyName.HeaderText = "CompanyName";
            this.ColumnCompaanyName.MinimumWidth = 6;
            this.ColumnCompaanyName.Name = "ColumnCompaanyName";
            this.ColumnCompaanyName.Width = 125;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Width = 125;
            // 
            // ColumnDateStart
            // 
            this.ColumnDateStart.HeaderText = "DateStart";
            this.ColumnDateStart.MinimumWidth = 6;
            this.ColumnDateStart.Name = "ColumnDateStart";
            this.ColumnDateStart.Width = 125;
            // 
            // ColumnDateEnd
            // 
            this.ColumnDateEnd.HeaderText = "DateEnd";
            this.ColumnDateEnd.MinimumWidth = 6;
            this.ColumnDateEnd.Name = "ColumnDateEnd";
            this.ColumnDateEnd.Width = 125;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxRent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rent";
            this.Text = "Rent";
            this.groupBoxRent.ResumeLayout(false);
            this.groupBoxRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelavailable;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxOrendarId;
        private System.Windows.Forms.ComboBox comboBoxRoomId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddRent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompaanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateEnd;
    }
}