namespace CPTWinformCrawling
{
    partial class MovieItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMovieDisp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // picMovieDisp
            // 
            this.picMovieDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMovieDisp.Location = new System.Drawing.Point(0, 0);
            this.picMovieDisp.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.picMovieDisp.Name = "picMovieDisp";
            this.picMovieDisp.Size = new System.Drawing.Size(800, 457);
            this.picMovieDisp.TabIndex = 0;
            this.picMovieDisp.TabStop = false;
            this.picMovieDisp.Click += new System.EventHandler(this.picMovieDisp_Click);
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picMovieDisp);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(800, 457);
            ((System.ComponentModel.ISupportInitialize)(this.picMovieDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMovieDisp;
    }
}
