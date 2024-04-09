
namespace RentalBuildingApplication.Pages
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonOrendar = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(13, 247);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(754, 191);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(67, 78);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(146, 49);
            this.buttonAddRoom.TabIndex = 1;
            this.buttonAddRoom.Text = "Manage Rooms";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonOrendar
            // 
            this.buttonOrendar.Location = new System.Drawing.Point(219, 78);
            this.buttonOrendar.Name = "buttonOrendar";
            this.buttonOrendar.Size = new System.Drawing.Size(146, 49);
            this.buttonOrendar.TabIndex = 1;
            this.buttonOrendar.Text = "Manage Orendars";
            this.buttonOrendar.UseVisualStyleBackColor = true;
            this.buttonOrendar.Click += new System.EventHandler(this.buttonOrendar_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(523, 78);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(146, 49);
            this.buttonReport.TabIndex = 1;
            this.buttonReport.Text = "Reports";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(620, 192);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(146, 49);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(371, 78);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(146, 49);
            this.buttonRent.TabIndex = 1;
            this.buttonRent.Text = "RentRoom";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonOrendar);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Rental Application ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Button buttonAddRoom;
        public System.Windows.Forms.Button buttonOrendar;
        public System.Windows.Forms.Button buttonReport;
        public System.Windows.Forms.Button buttonLogout;
        public System.Windows.Forms.Button buttonRent;
    }
}