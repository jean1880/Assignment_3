namespace Assignment_3
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.paymentPicture = new System.Windows.Forms.PictureBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cardNumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CCVBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expiryDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(286, 15);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(176, 28);
            this.paymentComboBox.TabIndex = 13;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // paymentPicture
            // 
            this.paymentPicture.Location = new System.Drawing.Point(229, 15);
            this.paymentPicture.Name = "paymentPicture";
            this.paymentPicture.Size = new System.Drawing.Size(51, 28);
            this.paymentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paymentPicture.TabIndex = 14;
            this.paymentPicture.TabStop = false;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.White;
            this.paymentLabel.Location = new System.Drawing.Point(12, 15);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(126, 20);
            this.paymentLabel.TabIndex = 15;
            this.paymentLabel.Text = "Payment Option:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(517, 154);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cardNumBox
            // 
            this.cardNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumBox.Location = new System.Drawing.Point(124, 75);
            this.cardNumBox.Name = "cardNumBox";
            this.cardNumBox.Size = new System.Drawing.Size(468, 26);
            this.cardNumBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Credit Card #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name:";
            // 
            // fNameBox
            // 
            this.fNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameBox.Location = new System.Drawing.Point(108, 117);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(191, 26);
            this.fNameBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name:";
            // 
            // lNameBox
            // 
            this.lNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBox.Location = new System.Drawing.Point(401, 117);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(191, 26);
            this.lNameBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "CCV:";
            // 
            // CCVBox
            // 
            this.CCVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCVBox.Location = new System.Drawing.Point(64, 154);
            this.CCVBox.Name = "CCVBox";
            this.CCVBox.Size = new System.Drawing.Size(54, 26);
            this.CCVBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Expiry Date:";
            // 
            // expiryDate
            // 
            this.expiryDate.CustomFormat = "MM/yy";
            this.expiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDate.Location = new System.Drawing.Point(229, 154);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(70, 26);
            this.expiryDate.TabIndex = 26;
            this.expiryDate.Value = new System.DateTime(2013, 11, 8, 14, 59, 38, 0);
            // 
            // paymentForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 193);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CCVBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNumBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.paymentPicture);
            this.Controls.Add(this.paymentComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bananza!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            ((System.ComponentModel.ISupportInitialize)(this.paymentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.PictureBox paymentPicture;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox cardNumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CCVBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker expiryDate;
    }
}