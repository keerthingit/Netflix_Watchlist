namespace CPTWinformCrawling
{
    partial class frmWebcrawl
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
            this.webCrawling = new System.Windows.Forms.WebBrowser();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.grpMovieDisplay = new System.Windows.Forms.GroupBox();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.lblOutof10 = new System.Windows.Forms.Label();
            this.btnListAdd1 = new System.Windows.Forms.Button();
            this.lblUserRating = new System.Windows.Forms.Label();
            this.txtBoxRating = new System.Windows.Forms.TextBox();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.lblMovieDuration = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.grpBoxDiscover = new System.Windows.Forms.GroupBox();
            this.grpBox3 = new System.Windows.Forms.GroupBox();
            this.cmboBoxMyLists = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.comBoxSortBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.grpFlowHolder = new System.Windows.Forms.GroupBox();
            this.flwMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWebHolder = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnNetflixGUI = new System.Windows.Forms.Button();
            this.panelHolder.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.grpMovieDisplay.SuspendLayout();
            this.panelMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.grpBoxDiscover.SuspendLayout();
            this.grpBox3.SuspendLayout();
            this.grpFlowHolder.SuspendLayout();
            this.panelWebHolder.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // webCrawling
            // 
            this.webCrawling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webCrawling.Location = new System.Drawing.Point(0, 0);
            this.webCrawling.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCrawling.Name = "webCrawling";
            this.webCrawling.ScriptErrorsSuppressed = true;
            this.webCrawling.Size = new System.Drawing.Size(1117, 20);
            this.webCrawling.TabIndex = 5;
            this.webCrawling.Url = new System.Uri("https://www.netflix.com/browse/genre/34399", System.UriKind.Absolute);
            this.webCrawling.WebBrowserShortcutsEnabled = false;
            this.webCrawling.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.BadNavigating);
            // 
            // panelHolder
            // 
            this.panelHolder.AutoSize = true;
            this.panelHolder.Controls.Add(this.panelMainMenu);
            this.panelHolder.Controls.Add(this.panelWebHolder);
            this.panelHolder.Controls.Add(this.panelSideMenu);
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.Location = new System.Drawing.Point(0, 0);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1231, 765);
            this.panelHolder.TabIndex = 7;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMainMenu.Controls.Add(this.grpMovieDisplay);
            this.panelMainMenu.Controls.Add(this.grpBoxDiscover);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1117, 765);
            this.panelMainMenu.TabIndex = 7;
            // 
            // grpMovieDisplay
            // 
            this.grpMovieDisplay.Controls.Add(this.panelMovie);
            this.grpMovieDisplay.ForeColor = System.Drawing.Color.White;
            this.grpMovieDisplay.Location = new System.Drawing.Point(10, 455);
            this.grpMovieDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.grpMovieDisplay.Name = "grpMovieDisplay";
            this.grpMovieDisplay.Padding = new System.Windows.Forms.Padding(1);
            this.grpMovieDisplay.Size = new System.Drawing.Size(1101, 322);
            this.grpMovieDisplay.TabIndex = 14;
            this.grpMovieDisplay.TabStop = false;
            this.grpMovieDisplay.Text = "Movie";
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.lblOutof10);
            this.panelMovie.Controls.Add(this.btnListAdd1);
            this.panelMovie.Controls.Add(this.lblUserRating);
            this.panelMovie.Controls.Add(this.txtBoxRating);
            this.panelMovie.Controls.Add(this.btnListAdd);
            this.panelMovie.Controls.Add(this.lblMovieDuration);
            this.panelMovie.Controls.Add(this.lblMovieYear);
            this.panelMovie.Controls.Add(this.lblMovieRating);
            this.panelMovie.Controls.Add(this.lblTitle);
            this.panelMovie.Controls.Add(this.picMovie);
            this.panelMovie.Location = new System.Drawing.Point(17, 29);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(1069, 275);
            this.panelMovie.TabIndex = 0;
            // 
            // lblOutof10
            // 
            this.lblOutof10.AutoSize = true;
            this.lblOutof10.BackColor = System.Drawing.Color.Maroon;
            this.lblOutof10.Location = new System.Drawing.Point(915, 48);
            this.lblOutof10.Name = "lblOutof10";
            this.lblOutof10.Size = new System.Drawing.Size(24, 13);
            this.lblOutof10.TabIndex = 9;
            this.lblOutof10.Text = "/10";
            // 
            // btnListAdd1
            // 
            this.btnListAdd1.BackColor = System.Drawing.Color.Maroon;
            this.btnListAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListAdd1.ForeColor = System.Drawing.Color.White;
            this.btnListAdd1.Location = new System.Drawing.Point(833, 141);
            this.btnListAdd1.Name = "btnListAdd1";
            this.btnListAdd1.Size = new System.Drawing.Size(134, 113);
            this.btnListAdd1.TabIndex = 8;
            this.btnListAdd1.Text = "Plan On Watching";
            this.btnListAdd1.UseVisualStyleBackColor = false;
            this.btnListAdd1.Click += new System.EventHandler(this.btnListAdd1_Click);
            // 
            // lblUserRating
            // 
            this.lblUserRating.AutoSize = true;
            this.lblUserRating.BackColor = System.Drawing.Color.Maroon;
            this.lblUserRating.Location = new System.Drawing.Point(851, 48);
            this.lblUserRating.Name = "lblUserRating";
            this.lblUserRating.Size = new System.Drawing.Size(33, 13);
            this.lblUserRating.TabIndex = 7;
            this.lblUserRating.Text = "Rate:";
            // 
            // txtBoxRating
            // 
            this.txtBoxRating.Location = new System.Drawing.Point(884, 45);
            this.txtBoxRating.Name = "txtBoxRating";
            this.txtBoxRating.Size = new System.Drawing.Size(32, 20);
            this.txtBoxRating.TabIndex = 6;
            this.txtBoxRating.Text = "0";
            // 
            // btnListAdd
            // 
            this.btnListAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnListAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListAdd.ForeColor = System.Drawing.Color.White;
            this.btnListAdd.Location = new System.Drawing.Point(833, 22);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(134, 113);
            this.btnListAdd.TabIndex = 5;
            this.btnListAdd.Text = "Watched";
            this.btnListAdd.UseVisualStyleBackColor = false;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // lblMovieDuration
            // 
            this.lblMovieDuration.AutoSize = true;
            this.lblMovieDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDuration.Location = new System.Drawing.Point(426, 162);
            this.lblMovieDuration.Name = "lblMovieDuration";
            this.lblMovieDuration.Size = new System.Drawing.Size(182, 31);
            this.lblMovieDuration.TabIndex = 4;
            this.lblMovieDuration.Text = "Please Wait...";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYear.Location = new System.Drawing.Point(426, 131);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(182, 31);
            this.lblMovieYear.TabIndex = 3;
            this.lblMovieYear.Text = "Please Wait...";
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.AutoSize = true;
            this.lblMovieRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieRating.Location = new System.Drawing.Point(426, 100);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(182, 31);
            this.lblMovieRating.TabIndex = 2;
            this.lblMovieRating.Text = "Please Wait...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(426, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Please Wait...";
            // 
            // picMovie
            // 
            this.picMovie.Location = new System.Drawing.Point(61, 35);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(343, 205);
            this.picMovie.TabIndex = 0;
            this.picMovie.TabStop = false;
            // 
            // grpBoxDiscover
            // 
            this.grpBoxDiscover.Controls.Add(this.grpBox3);
            this.grpBoxDiscover.Controls.Add(this.grpFlowHolder);
            this.grpBoxDiscover.ForeColor = System.Drawing.Color.White;
            this.grpBoxDiscover.Location = new System.Drawing.Point(10, 10);
            this.grpBoxDiscover.Margin = new System.Windows.Forms.Padding(1);
            this.grpBoxDiscover.Name = "grpBoxDiscover";
            this.grpBoxDiscover.Padding = new System.Windows.Forms.Padding(1);
            this.grpBoxDiscover.Size = new System.Drawing.Size(1101, 443);
            this.grpBoxDiscover.TabIndex = 6;
            this.grpBoxDiscover.TabStop = false;
            this.grpBoxDiscover.Text = "Discover";
            // 
            // grpBox3
            // 
            this.grpBox3.Controls.Add(this.cmboBoxMyLists);
            this.grpBox3.Controls.Add(this.btnSort);
            this.grpBox3.Controls.Add(this.btnResetSearch);
            this.grpBox3.Controls.Add(this.comBoxSortBy);
            this.grpBox3.Controls.Add(this.btnSearch);
            this.grpBox3.Controls.Add(this.txtSearchBar);
            this.grpBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBox3.Location = new System.Drawing.Point(17, 26);
            this.grpBox3.Margin = new System.Windows.Forms.Padding(1);
            this.grpBox3.Name = "grpBox3";
            this.grpBox3.Padding = new System.Windows.Forms.Padding(1);
            this.grpBox3.Size = new System.Drawing.Size(1069, 58);
            this.grpBox3.TabIndex = 13;
            this.grpBox3.TabStop = false;
            this.grpBox3.Text = "Advanced Search";
            // 
            // cmboBoxMyLists
            // 
            this.cmboBoxMyLists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmboBoxMyLists.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmboBoxMyLists.Items.AddRange(new object[] {
            "Watched",
            "Plan to Watch"});
            this.cmboBoxMyLists.Location = new System.Drawing.Point(736, 22);
            this.cmboBoxMyLists.Margin = new System.Windows.Forms.Padding(1);
            this.cmboBoxMyLists.Name = "cmboBoxMyLists";
            this.cmboBoxMyLists.Size = new System.Drawing.Size(161, 21);
            this.cmboBoxMyLists.TabIndex = 16;
            this.cmboBoxMyLists.Text = "Select My Lists";
            this.cmboBoxMyLists.SelectedIndexChanged += new System.EventHandler(this.cmboBoxMyLists_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSort.Location = new System.Drawing.Point(451, 19);
            this.btnSort.Margin = new System.Windows.Forms.Padding(1);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(86, 21);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetSearch.Location = new System.Drawing.Point(971, 20);
            this.btnResetSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(86, 21);
            this.btnResetSearch.TabIndex = 0;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // comBoxSortBy
            // 
            this.comBoxSortBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comBoxSortBy.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comBoxSortBy.Items.AddRange(new object[] {
            "Title",
            "Year",
            "Duration"});
            this.comBoxSortBy.Location = new System.Drawing.Point(545, 22);
            this.comBoxSortBy.Margin = new System.Windows.Forms.Padding(1);
            this.comBoxSortBy.Name = "comBoxSortBy";
            this.comBoxSortBy.Size = new System.Drawing.Size(161, 21);
            this.comBoxSortBy.TabIndex = 14;
            this.comBoxSortBy.Text = "Sort by";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(12, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(98, 24);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(1);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(322, 20);
            this.txtSearchBar.TabIndex = 3;
            this.txtSearchBar.Text = "Search";
            // 
            // grpFlowHolder
            // 
            this.grpFlowHolder.Controls.Add(this.flwMovies);
            this.grpFlowHolder.ForeColor = System.Drawing.Color.White;
            this.grpFlowHolder.Location = new System.Drawing.Point(17, 96);
            this.grpFlowHolder.Margin = new System.Windows.Forms.Padding(1);
            this.grpFlowHolder.Name = "grpFlowHolder";
            this.grpFlowHolder.Padding = new System.Windows.Forms.Padding(1);
            this.grpFlowHolder.Size = new System.Drawing.Size(1069, 324);
            this.grpFlowHolder.TabIndex = 4;
            this.grpFlowHolder.TabStop = false;
            this.grpFlowHolder.Text = "Recommended Movies";
            // 
            // flwMovies
            // 
            this.flwMovies.AutoScroll = true;
            this.flwMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwMovies.Location = new System.Drawing.Point(1, 14);
            this.flwMovies.Margin = new System.Windows.Forms.Padding(1);
            this.flwMovies.Name = "flwMovies";
            this.flwMovies.Size = new System.Drawing.Size(1067, 309);
            this.flwMovies.TabIndex = 1;
            // 
            // panelWebHolder
            // 
            this.panelWebHolder.Controls.Add(this.webCrawling);
            this.panelWebHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWebHolder.Location = new System.Drawing.Point(0, 765);
            this.panelWebHolder.Name = "panelWebHolder";
            this.panelWebHolder.Size = new System.Drawing.Size(1117, 0);
            this.panelWebHolder.TabIndex = 6;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.lblUserName);
            this.panelSideMenu.Controls.Add(this.picProfile);
            this.panelSideMenu.Controls.Add(this.btnNetflixGUI);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideMenu.Location = new System.Drawing.Point(1117, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(114, 765);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 667);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 117);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 105);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(78, 26);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Login For More\r\nFeautures";
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProfile.Location = new System.Drawing.Point(0, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(114, 105);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProfile.TabIndex = 2;
            this.picProfile.TabStop = false;
            // 
            // btnNetflixGUI
            // 
            this.btnNetflixGUI.BackColor = System.Drawing.Color.Maroon;
            this.btnNetflixGUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNetflixGUI.ForeColor = System.Drawing.Color.White;
            this.btnNetflixGUI.Location = new System.Drawing.Point(0, 544);
            this.btnNetflixGUI.Name = "btnNetflixGUI";
            this.btnNetflixGUI.Size = new System.Drawing.Size(114, 117);
            this.btnNetflixGUI.TabIndex = 0;
            this.btnNetflixGUI.Text = "Open Netflix GUI";
            this.btnNetflixGUI.UseVisualStyleBackColor = false;
            this.btnNetflixGUI.Click += new System.EventHandler(this.btnNetflixGUI_Click);
            // 
            // frmWebcrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 765);
            this.Controls.Add(this.panelHolder);
            this.MaximumSize = new System.Drawing.Size(1247, 804);
            this.MinimumSize = new System.Drawing.Size(831, 487);
            this.Name = "frmWebcrawl";
            this.Text = "MyMovieList";
            this.Load += new System.EventHandler(this.frmWebcrawl_Load);
            this.panelHolder.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.grpMovieDisplay.ResumeLayout(false);
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.grpBoxDiscover.ResumeLayout(false);
            this.grpBox3.ResumeLayout(false);
            this.grpBox3.PerformLayout();
            this.grpFlowHolder.ResumeLayout(false);
            this.panelWebHolder.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webCrawling;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnNetflixGUI;
        private System.Windows.Forms.Panel panelWebHolder;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.GroupBox grpBox3;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.ComboBox comBoxSortBy;
        private System.Windows.Forms.GroupBox grpBoxDiscover;
        private System.Windows.Forms.GroupBox grpFlowHolder;
        private System.Windows.Forms.FlowLayoutPanel flwMovies;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpMovieDisplay;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Label lblMovieDuration;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOutof10;
        private System.Windows.Forms.Button btnListAdd1;
        private System.Windows.Forms.Label lblUserRating;
        private System.Windows.Forms.TextBox txtBoxRating;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmboBoxMyLists;
    }
}

