namespace BookingSystem.Presentation
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.header = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.roomDescription1 = new System.Windows.Forms.TextBox();
            this.roomDescription2 = new System.Windows.Forms.TextBox();
            this.roomDescription3 = new System.Windows.Forms.TextBox();
            this.roomDescription4 = new System.Windows.Forms.TextBox();
            this.select1 = new System.Windows.Forms.Button();
            this.select2 = new System.Windows.Forms.Button();
            this.select3 = new System.Windows.Forms.Button();
            this.select4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.finishBookingButton = new System.Windows.Forms.Button();
            this.reservationListView = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.header.Location = new System.Drawing.Point(261, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1356, 97);
            this.header.TabIndex = 1;
            this.header.Text = "Phumla Kamnandi Hotel Group";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BookingSystem.Properties.Resources.Apartment;
            this.pictureBox4.Location = new System.Drawing.Point(1061, 560);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 174);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BookingSystem.Properties.Resources.ExecutiveRoom;
            this.pictureBox3.Location = new System.Drawing.Point(744, 560);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookingSystem.Properties.Resources.Studio;
            this.pictureBox2.Location = new System.Drawing.Point(416, 560);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSystem.Properties.Resources.FamilyRoom;
            this.pictureBox1.Location = new System.Drawing.Point(95, 560);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(90, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(491, 412);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 40);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(88, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Check-in date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(486, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Check-out date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(90, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Children              0-5 years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(90, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Older Children    6-16 years";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(90, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adults                 16+ years";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Location = new System.Drawing.Point(491, 349);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 40);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown3.Location = new System.Drawing.Point(491, 286);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 40);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(491, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search for  available rooms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomDescription1
            // 
            this.roomDescription1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.roomDescription1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.roomDescription1.Location = new System.Drawing.Point(95, 754);
            this.roomDescription1.Multiline = true;
            this.roomDescription1.Name = "roomDescription1";
            this.roomDescription1.Size = new System.Drawing.Size(280, 87);
            this.roomDescription1.TabIndex = 22;
            this.roomDescription1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // roomDescription2
            // 
            this.roomDescription2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.roomDescription2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.roomDescription2.Location = new System.Drawing.Point(416, 754);
            this.roomDescription2.Multiline = true;
            this.roomDescription2.Name = "roomDescription2";
            this.roomDescription2.Size = new System.Drawing.Size(280, 87);
            this.roomDescription2.TabIndex = 23;
            this.roomDescription2.TextChanged += new System.EventHandler(this.roomDescription2_TextChanged);
            // 
            // roomDescription3
            // 
            this.roomDescription3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.roomDescription3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.roomDescription3.Location = new System.Drawing.Point(744, 754);
            this.roomDescription3.Multiline = true;
            this.roomDescription3.Name = "roomDescription3";
            this.roomDescription3.Size = new System.Drawing.Size(280, 87);
            this.roomDescription3.TabIndex = 24;
            this.roomDescription3.TextChanged += new System.EventHandler(this.roomDescription3_TextChanged);
            // 
            // roomDescription4
            // 
            this.roomDescription4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.roomDescription4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescription4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.roomDescription4.Location = new System.Drawing.Point(1061, 754);
            this.roomDescription4.Multiline = true;
            this.roomDescription4.Name = "roomDescription4";
            this.roomDescription4.Size = new System.Drawing.Size(280, 87);
            this.roomDescription4.TabIndex = 25;
            this.roomDescription4.TextChanged += new System.EventHandler(this.roomDescription4_TextChanged);
            // 
            // select1
            // 
            this.select1.BackColor = System.Drawing.Color.Transparent;
            this.select1.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_;
            this.select1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select1.ForeColor = System.Drawing.SystemColors.Control;
            this.select1.Location = new System.Drawing.Point(233, 892);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(142, 45);
            this.select1.TabIndex = 30;
            this.select1.Text = "Select Room";
            this.select1.UseVisualStyleBackColor = false;
            this.select1.Click += new System.EventHandler(this.button6_Click);
            // 
            // select2
            // 
            this.select2.BackColor = System.Drawing.Color.Transparent;
            this.select2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select2.BackgroundImage")));
            this.select2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select2.ForeColor = System.Drawing.SystemColors.Control;
            this.select2.Location = new System.Drawing.Point(554, 892);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(142, 45);
            this.select2.TabIndex = 31;
            this.select2.Text = "Select Room";
            this.select2.UseVisualStyleBackColor = false;
            this.select2.Click += new System.EventHandler(this.button2_Click);
            // 
            // select3
            // 
            this.select3.BackColor = System.Drawing.Color.Transparent;
            this.select3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select3.BackgroundImage")));
            this.select3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select3.ForeColor = System.Drawing.SystemColors.Control;
            this.select3.Location = new System.Drawing.Point(882, 892);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(142, 45);
            this.select3.TabIndex = 32;
            this.select3.Text = "Select Room";
            this.select3.UseVisualStyleBackColor = false;
            this.select3.Click += new System.EventHandler(this.button3_Click);
            // 
            // select4
            // 
            this.select4.BackColor = System.Drawing.Color.Transparent;
            this.select4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select4.BackgroundImage")));
            this.select4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select4.ForeColor = System.Drawing.SystemColors.Control;
            this.select4.Location = new System.Drawing.Point(1199, 892);
            this.select4.Name = "select4";
            this.select4.Size = new System.Drawing.Size(142, 45);
            this.select4.TabIndex = 33;
            this.select4.Text = "Select Room";
            this.select4.UseVisualStyleBackColor = false;
            this.select4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 31);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(491, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 31);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // finishBookingButton
            // 
            this.finishBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.finishBookingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishBookingButton.BackgroundImage")));
            this.finishBookingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishBookingButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBookingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.finishBookingButton.Location = new System.Drawing.Point(1617, 496);
            this.finishBookingButton.Name = "finishBookingButton";
            this.finishBookingButton.Size = new System.Drawing.Size(159, 45);
            this.finishBookingButton.TabIndex = 37;
            this.finishBookingButton.Text = "Finish Booking";
            this.finishBookingButton.UseVisualStyleBackColor = false;
            this.finishBookingButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // reservationListView
            // 
            this.reservationListView.HideSelection = false;
            this.reservationListView.Location = new System.Drawing.Point(1364, 179);
            this.reservationListView.Name = "reservationListView";
            this.reservationListView.Size = new System.Drawing.Size(412, 275);
            this.reservationListView.TabIndex = 38;
            this.reservationListView.UseCompatibleStateImageBehavior = false;
            this.reservationListView.SelectedIndexChanged += new System.EventHandler(this.reservationListView_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BookingSystem.Properties.Resources.castle_4931672;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(95, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 82);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ReservationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reservationListView);
            this.Controls.Add(this.finishBookingButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.select4);
            this.Controls.Add(this.select3);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.roomDescription4);
            this.Controls.Add(this.roomDescription3);
            this.Controls.Add(this.roomDescription2);
            this.Controls.Add(this.roomDescription1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox roomDescription1;
        private System.Windows.Forms.TextBox roomDescription2;
        private System.Windows.Forms.TextBox roomDescription3;
        private System.Windows.Forms.TextBox roomDescription4;
        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.Button select3;
        private System.Windows.Forms.Button select4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button finishBookingButton;
        private System.Windows.Forms.ListView reservationListView;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}