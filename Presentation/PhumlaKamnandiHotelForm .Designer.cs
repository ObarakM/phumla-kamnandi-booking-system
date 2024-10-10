namespace BookingSystem.Presentation
{
    partial class PhumlaKamnandiHotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhumlaKamnandiHotelForm));
            this.header = new System.Windows.Forms.Label();
            this.bookingsButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AllowDrop = true;
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Lucida Calligraphy", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.header.Location = new System.Drawing.Point(271, 69);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1356, 97);
            this.header.TabIndex = 0;
            this.header.Text = "Phumla Kamnandi Hotel Group";
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // bookingsButton
            // 
            this.bookingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bookingsButton.BackColor = System.Drawing.Color.Transparent;
            this.bookingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookingsButton.BackgroundImage")));
            this.bookingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsButton.Font = new System.Drawing.Font("Lucida Calligraphy", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookingsButton.Location = new System.Drawing.Point(811, 689);
            this.bookingsButton.Name = "bookingsButton";
            this.bookingsButton.Size = new System.Drawing.Size(315, 136);
            this.bookingsButton.TabIndex = 3;
            this.bookingsButton.Text = "Manage Bookings";
            this.bookingsButton.UseVisualStyleBackColor = false;
            this.bookingsButton.Click += new System.EventHandler(this.bookingsButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.BackColor = System.Drawing.Color.Transparent;
            this.reportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportButton.BackgroundImage")));
            this.reportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Lucida Calligraphy", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportButton.Location = new System.Drawing.Point(1391, 689);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(315, 136);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "View Reports";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // reservationButton
            // 
            this.reservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reservationButton.BackColor = System.Drawing.Color.Transparent;
            this.reservationButton.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_;
            this.reservationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationButton.Font = new System.Drawing.Font("Lucida Calligraphy", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reservationButton.Location = new System.Drawing.Point(225, 689);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(315, 136);
            this.reservationButton.TabIndex = 1;
            this.reservationButton.Text = "Make Reservation";
            this.reservationButton.UseVisualStyleBackColor = false;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // PhumlaKamnandiHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.bookingsButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.header);
            this.Name = "PhumlaKamnandiHotelForm";
            this.Text = "PhumlaKamnandiHotelForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button bookingsButton;
    }
}