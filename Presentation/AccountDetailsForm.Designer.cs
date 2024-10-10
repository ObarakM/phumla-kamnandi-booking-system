namespace BookingSystem.Presentation
{
    partial class AccountDetailsForm
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
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.securityCodeTextBox = new System.Windows.Forms.TextBox();
            this.securityCodeLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(630, 178);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(332, 20);
            this.cardNumberTextBox.TabIndex = 24;
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.expiryDateLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expiryDateLabel.Location = new System.Drawing.Point(392, 228);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(146, 28);
            this.expiryDateLabel.TabIndex = 23;
            this.expiryDateLabel.Text = "Expiry Date";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardNumberLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardNumberLabel.Location = new System.Drawing.Point(392, 170);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(168, 28);
            this.cardNumberLabel.TabIndex = 22;
            this.cardNumberLabel.Text = "Card Number";
            // 
            // securityCodeTextBox
            // 
            this.securityCodeTextBox.Location = new System.Drawing.Point(630, 289);
            this.securityCodeTextBox.Name = "securityCodeTextBox";
            this.securityCodeTextBox.Size = new System.Drawing.Size(332, 20);
            this.securityCodeTextBox.TabIndex = 27;
            // 
            // securityCodeLabel
            // 
            this.securityCodeLabel.AutoSize = true;
            this.securityCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.securityCodeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.securityCodeLabel.Location = new System.Drawing.Point(392, 280);
            this.securityCodeLabel.Name = "securityCodeLabel";
            this.securityCodeLabel.Size = new System.Drawing.Size(172, 28);
            this.securityCodeLabel.TabIndex = 26;
            this.securityCodeLabel.Text = "Security Code";
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
            this.header.Location = new System.Drawing.Point(217, 21);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1356, 97);
            this.header.TabIndex = 47;
            this.header.Text = "Phumla Kamnandi Hotel Group";
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.BackColor = System.Drawing.Color.Transparent;
            this.makePaymentButton.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_;
            this.makePaymentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makePaymentButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.makePaymentButton.Location = new System.Drawing.Point(802, 325);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(160, 57);
            this.makePaymentButton.TabIndex = 49;
            this.makePaymentButton.Text = "Make Payment";
            this.makePaymentButton.UseVisualStyleBackColor = false;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(630, 236);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(332, 20);
            this.dateTimePicker.TabIndex = 53;
            // 
            // AccountDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookingSystem.Properties.Resources.pexels_soulful_pizza_2080276_3914755__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1531, 405);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.makePaymentButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.securityCodeTextBox);
            this.Controls.Add(this.securityCodeLabel);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Name = "AccountDetailsForm";
            this.Text = "AccountDetailsForm";
            this.Load += new System.EventHandler(this.AccountDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox securityCodeTextBox;
        private System.Windows.Forms.Label securityCodeLabel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}