namespace BookingSystem.Presentation
{
    partial class BookingListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingListing));
            this.header = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.costOfStayTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.costOfLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.checkInTextBox = new System.Windows.Forms.TextBox();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.bookingsListView = new System.Windows.Forms.ListView();
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
            this.header.Location = new System.Drawing.Point(427, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1356, 97);
            this.header.TabIndex = 3;
            this.header.Text = "Phumla Kamnandi Hotel Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(224, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bookings";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // costOfStayTextBox
            // 
            this.costOfStayTextBox.Location = new System.Drawing.Point(513, 957);
            this.costOfStayTextBox.Multiline = true;
            this.costOfStayTextBox.Name = "costOfStayTextBox";
            this.costOfStayTextBox.Size = new System.Drawing.Size(100, 30);
            this.costOfStayTextBox.TabIndex = 28;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(513, 744);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(199, 30);
            this.phoneTextBox.TabIndex = 27;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(513, 690);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(431, 30);
            this.nameTextBox.TabIndex = 26;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(834, 627);
            this.guestIDTextBox.Multiline = true;
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(110, 30);
            this.guestIDTextBox.TabIndex = 25;
            // 
            // costOfLabel
            // 
            this.costOfLabel.AutoSize = true;
            this.costOfLabel.BackColor = System.Drawing.Color.Transparent;
            this.costOfLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costOfLabel.Location = new System.Drawing.Point(276, 957);
            this.costOfLabel.Name = "costOfLabel";
            this.costOfLabel.Size = new System.Drawing.Size(148, 28);
            this.costOfLabel.TabIndex = 23;
            this.costOfLabel.Text = "Cost of stay";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneLabel.Location = new System.Drawing.Point(276, 744);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 28);
            this.phoneLabel.TabIndex = 22;
            this.phoneLabel.Text = "Phone";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameLabel.Location = new System.Drawing.Point(276, 690);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 28);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.guestIDLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guestIDLabel.Location = new System.Drawing.Point(703, 627);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(106, 28);
            this.guestIDLabel.TabIndex = 20;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.Location = new System.Drawing.Point(513, 627);
            this.reservationIDTextBox.Multiline = true;
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(100, 30);
            this.reservationIDTextBox.TabIndex = 37;
            // 
            // reservationIDLabel
            // 
            this.reservationIDLabel.AutoSize = true;
            this.reservationIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.reservationIDLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reservationIDLabel.Location = new System.Drawing.Point(278, 627);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(179, 28);
            this.reservationIDLabel.TabIndex = 36;
            this.reservationIDLabel.Text = "Reservation ID";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(513, 794);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(431, 30);
            this.emailTextBox.TabIndex = 39;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailLabel.Location = new System.Drawing.Point(276, 794);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(75, 28);
            this.emailLabel.TabIndex = 38;
            this.emailLabel.Text = "Email";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Location = new System.Drawing.Point(513, 901);
            this.checkOutTextBox.Multiline = true;
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(199, 30);
            this.checkOutTextBox.TabIndex = 43;
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkOutLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOutLabel.Location = new System.Drawing.Point(276, 901);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(125, 28);
            this.checkOutLabel.TabIndex = 42;
            this.checkOutLabel.Text = "Check-out";
            // 
            // checkInTextBox
            // 
            this.checkInTextBox.Location = new System.Drawing.Point(513, 851);
            this.checkInTextBox.Multiline = true;
            this.checkInTextBox.Name = "checkInTextBox";
            this.checkInTextBox.Size = new System.Drawing.Size(199, 30);
            this.checkInTextBox.TabIndex = 41;
            // 
            // checkInLabel
            // 
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkInLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkInLabel.Location = new System.Drawing.Point(276, 851);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(110, 28);
            this.checkInLabel.TabIndex = 40;
            this.checkInLabel.Text = "Check-in";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BookingSystem.Properties.Resources.castle_4931672;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(230, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 82);
            this.button3.TabIndex = 46;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitButton.BackgroundImage")));
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(1615, 934);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(107, 53);
            this.submitButton.TabIndex = 45;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(1463, 934);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 53);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(1622, 636);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 58);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editButton.Location = new System.Drawing.Point(1463, 636);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 58);
            this.editButton.TabIndex = 34;
            this.editButton.Text = "\r\n\r\n";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // bookingsListView
            // 
            this.bookingsListView.HideSelection = false;
            this.bookingsListView.Location = new System.Drawing.Point(230, 197);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(1525, 351);
            this.bookingsListView.TabIndex = 2;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            // 
            // BookingListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkOutTextBox);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.checkInTextBox);
            this.Controls.Add(this.checkInLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.reservationIDTextBox);
            this.Controls.Add(this.reservationIDLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.costOfStayTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.costOfLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.header);
            this.Controls.Add(this.bookingsListView);
            this.Name = "BookingListing";
            this.Text = "BookingListing";
            this.Load += new System.EventHandler(this.BookingListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox costOfStayTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.Label costOfLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox checkOutTextBox;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.TextBox checkInTextBox;
        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView bookingsListView;
    }
}