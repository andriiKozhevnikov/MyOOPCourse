namespace MyProject
{
    partial class ArtGuide
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtGuide));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSearchPictureFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchPictureViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtistSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSearchArtistFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchArtistViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchMuseum = new System.Windows.Forms.ToolStripMenuItem();
            this.MuseumSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSearchMuseumFind = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchCollectors = new System.Windows.Forms.ToolStripMenuItem();
            this.CollectorsSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSearchCollectorsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchAuctions = new System.Windows.Forms.ToolStripMenuItem();
            this.AuctionsSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSearchAuctionsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMyCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHiddenText = new System.Windows.Forms.ToolStripTextBox();
            this.MenuHiddenName = new System.Windows.Forms.ToolStripTextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu.ImageScalingSize = new System.Drawing.Size(16, 50);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSearch,
            this.MenuMyCollection,
            this.MenuHiddenText,
            this.MenuHiddenName});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(774, 41);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileClear,
            this.MenuFileExit});
            this.MenuFile.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFile.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(66, 37);
            this.MenuFile.Text = "File";
            this.MenuFile.DropDownClosed += new System.EventHandler(this.MenuFile_DropDownClosed);
            this.MenuFile.DropDownOpened += new System.EventHandler(this.MenuFile_DropDownOpened);
            // 
            // MenuFileClear
            // 
            this.MenuFileClear.Name = "MenuFileClear";
            this.MenuFileClear.Size = new System.Drawing.Size(148, 38);
            this.MenuFileClear.Text = "Clear";
            this.MenuFileClear.Click += new System.EventHandler(this.MenuFileClear_Click);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(148, 38);
            this.MenuFileExit.Text = "Exit";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // MenuSearch
            // 
            this.MenuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchPicture,
            this.MenuSearchArtist,
            this.MenuSearchMuseum,
            this.MenuSearchCollectors,
            this.MenuSearchAuctions});
            this.MenuSearch.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(102, 37);
            this.MenuSearch.Text = "Search";
            this.MenuSearch.DropDownClosed += new System.EventHandler(this.MenuSearch_DropDownClosed);
            this.MenuSearch.DropDownOpened += new System.EventHandler(this.MenuSearch_DropDownOpened);
            // 
            // MenuSearchPicture
            // 
            this.MenuSearchPicture.BackColor = System.Drawing.SystemColors.Control;
            this.MenuSearchPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PictureSearchBox,
            this.MenuSearchPictureFind,
            this.MenuSearchPictureViewAll});
            this.MenuSearchPicture.Name = "MenuSearchPicture";
            this.MenuSearchPicture.Size = new System.Drawing.Size(196, 38);
            this.MenuSearchPicture.Text = "Picture";
            // 
            // PictureSearchBox
            // 
            this.PictureSearchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PictureSearchBox.Name = "PictureSearchBox";
            this.PictureSearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MenuSearchPictureFind
            // 
            this.MenuSearchPictureFind.Name = "MenuSearchPictureFind";
            this.MenuSearchPictureFind.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchPictureFind.Text = "Find";
            this.MenuSearchPictureFind.Click += new System.EventHandler(this.MenuSearchPictureFind_Click);
            // 
            // MenuSearchPictureViewAll
            // 
            this.MenuSearchPictureViewAll.Name = "MenuSearchPictureViewAll";
            this.MenuSearchPictureViewAll.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchPictureViewAll.Text = "View all";
            this.MenuSearchPictureViewAll.Click += new System.EventHandler(this.MenuSearchPictureViewAll_Click);
            // 
            // MenuSearchArtist
            // 
            this.MenuSearchArtist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtistSearchBox,
            this.MenuSearchArtistFind,
            this.MenuSearchArtistViewAll});
            this.MenuSearchArtist.Name = "MenuSearchArtist";
            this.MenuSearchArtist.Size = new System.Drawing.Size(196, 38);
            this.MenuSearchArtist.Text = "Artist";
            // 
            // ArtistSearchBox
            // 
            this.ArtistSearchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ArtistSearchBox.Name = "ArtistSearchBox";
            this.ArtistSearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MenuSearchArtistFind
            // 
            this.MenuSearchArtistFind.Name = "MenuSearchArtistFind";
            this.MenuSearchArtistFind.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchArtistFind.Text = "Find";
            this.MenuSearchArtistFind.Click += new System.EventHandler(this.MenuSearchArtistFind_Click);
            // 
            // MenuSearchArtistViewAll
            // 
            this.MenuSearchArtistViewAll.Name = "MenuSearchArtistViewAll";
            this.MenuSearchArtistViewAll.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchArtistViewAll.Text = "View all";
            this.MenuSearchArtistViewAll.Click += new System.EventHandler(this.MenuSearchArtistViewAll_Click);
            // 
            // MenuSearchMuseum
            // 
            this.MenuSearchMuseum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuseumSearchBox,
            this.MenuSearchMuseumFind,
            this.viewAllToolStripMenuItem2});
            this.MenuSearchMuseum.Name = "MenuSearchMuseum";
            this.MenuSearchMuseum.Size = new System.Drawing.Size(196, 38);
            this.MenuSearchMuseum.Text = "Museums";
            // 
            // MuseumSearchBox
            // 
            this.MuseumSearchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MuseumSearchBox.Name = "MuseumSearchBox";
            this.MuseumSearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MenuSearchMuseumFind
            // 
            this.MenuSearchMuseumFind.Name = "MenuSearchMuseumFind";
            this.MenuSearchMuseumFind.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchMuseumFind.Text = "Find";
            // 
            // viewAllToolStripMenuItem2
            // 
            this.viewAllToolStripMenuItem2.Name = "viewAllToolStripMenuItem2";
            this.viewAllToolStripMenuItem2.Size = new System.Drawing.Size(165, 38);
            this.viewAllToolStripMenuItem2.Text = "View all";
            // 
            // MenuSearchCollectors
            // 
            this.MenuSearchCollectors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CollectorsSearchBox,
            this.MenuSearchCollectorsFind,
            this.viewAllToolStripMenuItem3});
            this.MenuSearchCollectors.Name = "MenuSearchCollectors";
            this.MenuSearchCollectors.Size = new System.Drawing.Size(196, 38);
            this.MenuSearchCollectors.Text = "Collectors";
            // 
            // CollectorsSearchBox
            // 
            this.CollectorsSearchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CollectorsSearchBox.Name = "CollectorsSearchBox";
            this.CollectorsSearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MenuSearchCollectorsFind
            // 
            this.MenuSearchCollectorsFind.Name = "MenuSearchCollectorsFind";
            this.MenuSearchCollectorsFind.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchCollectorsFind.Text = "Find";
            // 
            // viewAllToolStripMenuItem3
            // 
            this.viewAllToolStripMenuItem3.Name = "viewAllToolStripMenuItem3";
            this.viewAllToolStripMenuItem3.Size = new System.Drawing.Size(165, 38);
            this.viewAllToolStripMenuItem3.Text = "View all";
            // 
            // MenuSearchAuctions
            // 
            this.MenuSearchAuctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuctionsSearchBox,
            this.MenuSearchAuctionsFind,
            this.viewAllToolStripMenuItem4});
            this.MenuSearchAuctions.Name = "MenuSearchAuctions";
            this.MenuSearchAuctions.Size = new System.Drawing.Size(196, 38);
            this.MenuSearchAuctions.Text = "Auctions";
            // 
            // AuctionsSearchBox
            // 
            this.AuctionsSearchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AuctionsSearchBox.Name = "AuctionsSearchBox";
            this.AuctionsSearchBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MenuSearchAuctionsFind
            // 
            this.MenuSearchAuctionsFind.Name = "MenuSearchAuctionsFind";
            this.MenuSearchAuctionsFind.Size = new System.Drawing.Size(165, 38);
            this.MenuSearchAuctionsFind.Text = "Find";
            // 
            // viewAllToolStripMenuItem4
            // 
            this.viewAllToolStripMenuItem4.Name = "viewAllToolStripMenuItem4";
            this.viewAllToolStripMenuItem4.Size = new System.Drawing.Size(165, 38);
            this.viewAllToolStripMenuItem4.Text = "View all";
            // 
            // MenuMyCollection
            // 
            this.MenuMyCollection.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMyCollection.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuMyCollection.Name = "MenuMyCollection";
            this.MenuMyCollection.Size = new System.Drawing.Size(173, 37);
            this.MenuMyCollection.Text = "My Collection";
            this.MenuMyCollection.Click += new System.EventHandler(this.MenuMyCollection_Click);
            // 
            // MenuHiddenText
            // 
            this.MenuHiddenText.Name = "MenuHiddenText";
            this.MenuHiddenText.Size = new System.Drawing.Size(100, 37);
            this.MenuHiddenText.Visible = false;
            // 
            // MenuHiddenName
            // 
            this.MenuHiddenName.Name = "MenuHiddenName";
            this.MenuHiddenName.Size = new System.Drawing.Size(100, 37);
            this.MenuHiddenName.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(728, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(46, 43);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(774, 497);
            this.MainPanel.TabIndex = 2;
            // 
            // ArtGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 538);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Menu);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArtGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art Guide";
            this.Load += new System.EventHandler(this.ArtGuide_Load);
            this.Shown += new System.EventHandler(this.ArtGuide_Shown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem MenuMyCollection;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchPicture;
        private System.Windows.Forms.ToolStripTextBox PictureSearchBox;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchArtist;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchMuseum;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchCollectors;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchAuctions;
        private System.Windows.Forms.ToolStripTextBox ArtistSearchBox;
        private System.Windows.Forms.ToolStripTextBox MuseumSearchBox;
        private System.Windows.Forms.ToolStripTextBox CollectorsSearchBox;
        private System.Windows.Forms.ToolStripTextBox AuctionsSearchBox;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchPictureFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchArtistFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchMuseumFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchCollectorsFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchAuctionsFind;
        private System.Windows.Forms.ToolStripMenuItem MenuFileClear;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripTextBox MenuHiddenText;
        private System.Windows.Forms.ToolStripTextBox MenuHiddenName;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchPictureViewAll;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchArtistViewAll;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem4;





    }
}

