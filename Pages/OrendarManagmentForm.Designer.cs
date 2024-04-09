
namespace RentalBuildingApplication.Pages
{
    partial class OrendarManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrendarManagmentForm));
            this.groupBoxOrendar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYurAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.buttonAddOrendar = new System.Windows.Forms.Button();
            this.buttonClearOrend = new System.Windows.Forms.Button();
            this.buttonCancelOrend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOrendarId = new System.Windows.Forms.TextBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYurAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxOrendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrendar
            // 
            this.groupBoxOrendar.Controls.Add(this.buttonCancelOrend);
            this.groupBoxOrendar.Controls.Add(this.buttonClearOrend);
            this.groupBoxOrendar.Controls.Add(this.buttonAddOrendar);
            this.groupBoxOrendar.Controls.Add(this.textBoxChar);
            this.groupBoxOrendar.Controls.Add(this.label5);
            this.groupBoxOrendar.Controls.Add(this.textBoxDirector);
            this.groupBoxOrendar.Controls.Add(this.label4);
            this.groupBoxOrendar.Controls.Add(this.textBoxBankName);
            this.groupBoxOrendar.Controls.Add(this.label3);
            this.groupBoxOrendar.Controls.Add(this.textBoxYurAdress);
            this.groupBoxOrendar.Controls.Add(this.label2);
            this.groupBoxOrendar.Controls.Add(this.textBoxOrendarId);
            this.groupBoxOrendar.Controls.Add(this.label6);
            this.groupBoxOrendar.Controls.Add(this.textBoxCompanyName);
            this.groupBoxOrendar.Controls.Add(this.label1);
            this.groupBoxOrendar.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOrendar.Name = "groupBoxOrendar";
            this.groupBoxOrendar.Size = new System.Drawing.Size(399, 319);
            this.groupBoxOrendar.TabIndex = 0;
            this.groupBoxOrendar.TabStop = false;
            this.groupBoxOrendar.Text = "Orendar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CompanyName";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCompanyName.Location = new System.Drawing.Point(135, 68);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(258, 26);
            this.textBoxCompanyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "YurAdress";
            // 
            // textBoxYurAdress
            // 
            this.textBoxYurAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxYurAdress.Location = new System.Drawing.Point(135, 100);
            this.textBoxYurAdress.Name = "textBoxYurAdress";
            this.textBoxYurAdress.Size = new System.Drawing.Size(258, 26);
            this.textBoxYurAdress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "BankName";
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxBankName.Location = new System.Drawing.Point(135, 132);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(258, 26);
            this.textBoxBankName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DirectorName";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDirector.Location = new System.Drawing.Point(135, 164);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(258, 26);
            this.textBoxDirector.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Characteristic";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxChar.Location = new System.Drawing.Point(135, 196);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(258, 26);
            this.textBoxChar.TabIndex = 1;
            // 
            // buttonAddOrendar
            // 
            this.buttonAddOrendar.Location = new System.Drawing.Point(10, 246);
            this.buttonAddOrendar.Name = "buttonAddOrendar";
            this.buttonAddOrendar.Size = new System.Drawing.Size(119, 51);
            this.buttonAddOrendar.TabIndex = 2;
            this.buttonAddOrendar.Text = "AddOrendar";
            this.buttonAddOrendar.UseVisualStyleBackColor = true;
            this.buttonAddOrendar.Click += new System.EventHandler(this.buttonAddOrendar_Click);
            // 
            // buttonClearOrend
            // 
            this.buttonClearOrend.Location = new System.Drawing.Point(135, 246);
            this.buttonClearOrend.Name = "buttonClearOrend";
            this.buttonClearOrend.Size = new System.Drawing.Size(119, 51);
            this.buttonClearOrend.TabIndex = 2;
            this.buttonClearOrend.Text = "Clear";
            this.buttonClearOrend.UseVisualStyleBackColor = true;
            // 
            // buttonCancelOrend
            // 
            this.buttonCancelOrend.Location = new System.Drawing.Point(260, 246);
            this.buttonCancelOrend.Name = "buttonCancelOrend";
            this.buttonCancelOrend.Size = new System.Drawing.Size(119, 51);
            this.buttonCancelOrend.TabIndex = 2;
            this.buttonCancelOrend.Text = "Cancel";
            this.buttonCancelOrend.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCompanyName,
            this.ColumnYurAdress,
            this.ColumnBankName,
            this.ColumnDirectorName,
            this.ColumnChar,
            this.edit,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(419, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 492);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // textBoxOrendarId
            // 
            this.textBoxOrendarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxOrendarId.Location = new System.Drawing.Point(135, 36);
            this.textBoxOrendarId.Name = "textBoxOrendarId";
            this.textBoxOrendarId.ReadOnly = true;
            this.textBoxOrendarId.Size = new System.Drawing.Size(258, 26);
            this.textBoxOrendarId.TabIndex = 1;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 125;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.HeaderText = "CompanyName";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Width = 125;
            // 
            // ColumnYurAdress
            // 
            this.ColumnYurAdress.HeaderText = "YurAdress";
            this.ColumnYurAdress.MinimumWidth = 6;
            this.ColumnYurAdress.Name = "ColumnYurAdress";
            this.ColumnYurAdress.Width = 125;
            // 
            // ColumnBankName
            // 
            this.ColumnBankName.HeaderText = "BankName";
            this.ColumnBankName.MinimumWidth = 6;
            this.ColumnBankName.Name = "ColumnBankName";
            this.ColumnBankName.Width = 125;
            // 
            // ColumnDirectorName
            // 
            this.ColumnDirectorName.HeaderText = "DirectorName";
            this.ColumnDirectorName.MinimumWidth = 6;
            this.ColumnDirectorName.Name = "ColumnDirectorName";
            this.ColumnDirectorName.Width = 125;
            // 
            // ColumnChar
            // 
            this.ColumnChar.HeaderText = "Characreristic";
            this.ColumnChar.MinimumWidth = 6;
            this.ColumnChar.Name = "ColumnChar";
            this.ColumnChar.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // OrendarManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxOrendar);
            this.Name = "OrendarManagmentForm";
            this.Text = "OrendarManagment";
            this.groupBoxOrendar.ResumeLayout(false);
            this.groupBoxOrendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrendar;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYurAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelOrend;
        private System.Windows.Forms.Button buttonClearOrend;
        private System.Windows.Forms.Button buttonAddOrendar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxOrendarId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYurAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChar;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}