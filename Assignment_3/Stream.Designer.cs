namespace Assignment_3
{
    partial class Stream
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stream));
            this.movieBox = new System.Windows.Forms.PictureBox();
            this.backControl = new System.Windows.Forms.PictureBox();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backControl)).BeginInit();
            this.titleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieBox
            // 
            this.movieBox.Location = new System.Drawing.Point(110, 12);
            this.movieBox.Name = "movieBox";
            this.movieBox.Size = new System.Drawing.Size(562, 566);
            this.movieBox.TabIndex = 0;
            this.movieBox.TabStop = false;
            // 
            // backControl
            // 
            this.backControl.Image = global::Assignment_3.Properties.Resources.back;
            this.backControl.Location = new System.Drawing.Point(12, 12);
            this.backControl.Name = "backControl";
            this.backControl.Size = new System.Drawing.Size(92, 69);
            this.backControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backControl.TabIndex = 1;
            this.backControl.TabStop = false;
            this.backControl.Visible = false;
            this.backControl.Click += new System.EventHandler(this.backControl_Click);
            // 
            // controlTimer
            // 
            this.controlTimer.Interval = 1000;
            this.controlTimer.Tick += new System.EventHandler(this.controlTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(6, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(405, 54);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "movie title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.titleLabel);
            this.titleBox.Location = new System.Drawing.Point(201, -6);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(417, 87);
            this.titleBox.TabIndex = 3;
            this.titleBox.TabStop = false;
            this.titleBox.Visible = false;
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 590);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.backControl);
            this.Controls.Add(this.movieBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stream";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bananza!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.Load += new System.EventHandler(this.Stream_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.show_controls);
            ((System.ComponentModel.ISupportInitialize)(this.movieBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backControl)).EndInit();
            this.titleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox movieBox;
        private System.Windows.Forms.PictureBox backControl;
        private System.Windows.Forms.Timer controlTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox titleBox;
    }
}