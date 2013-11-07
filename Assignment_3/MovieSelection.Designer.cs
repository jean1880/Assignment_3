namespace Assignment_3
{
    partial class MovieSelection1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieSelection1));
            this.movieList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.moviePicture = new System.Windows.Forms.PictureBox();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // movieList
            // 
            this.movieList.FormattingEnabled = true;
            this.movieList.HorizontalScrollbar = true;
            this.movieList.Location = new System.Drawing.Point(12, 6);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(153, 329);
            this.movieList.TabIndex = 0;
            this.movieList.SelectedIndexChanged += new System.EventHandler(this.movie_selection);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.costLabel);
            this.groupBox1.Controls.Add(this.categoryLabel);
            this.groupBox1.Controls.Add(this.movieLabel);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.moviePicture);
            this.groupBox1.Location = new System.Drawing.Point(171, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 563);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.Color.White;
            this.costLabel.Location = new System.Drawing.Point(365, 98);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(202, 39);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(365, 55);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(202, 23);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Movie Genre";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieLabel
            // 
            this.movieLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.Color.White;
            this.movieLabel.Location = new System.Drawing.Point(365, 20);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(202, 23);
            this.movieLabel.TabIndex = 2;
            this.movieLabel.Text = "Movie title";
            this.movieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.Color.White;
            this.descriptionBox.Location = new System.Drawing.Point(369, 140);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(198, 392);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "Description";
            this.descriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moviePicture
            // 
            this.moviePicture.Location = new System.Drawing.Point(6, 20);
            this.moviePicture.Name = "moviePicture";
            this.moviePicture.Size = new System.Drawing.Size(353, 512);
            this.moviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviePicture.TabIndex = 0;
            this.moviePicture.TabStop = false;
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 2000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // MovieSelection1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(756, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.movieList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieSelection1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza!";
            this.Load += new System.EventHandler(this.MovieSelection_Load);
            this.Shown += new System.EventHandler(this.first_run);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox moviePicture;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Timer splashTimer;
    }
}

