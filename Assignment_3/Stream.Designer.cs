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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.movieBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieBox)).BeginInit();
            this.SuspendLayout();
            // 
            // movieBox
            // 
            this.movieBox.Location = new System.Drawing.Point(89, 12);
            this.movieBox.Name = "movieBox";
            this.movieBox.Size = new System.Drawing.Size(562, 566);
            this.movieBox.TabIndex = 0;
            this.movieBox.TabStop = false;
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 590);
            this.Controls.Add(this.movieBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stream";
            this.Text = "Movie Bananza!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.Shown += new System.EventHandler(this.success_Output);
            ((System.ComponentModel.ISupportInitialize)(this.movieBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox movieBox;
    }
}