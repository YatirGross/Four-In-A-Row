namespace FourInRow
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesOfPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RptStepsInGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RPTGamesByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.תרשימיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesAndPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.gameToolStripMenuItem2,
            this.viewGameToolStripMenuItem,
            this.תרשימיםToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.citiesToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.gameStepsToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tablesToolStripMenuItem.Text = "טבלאות";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.playersToolStripMenuItem.Text = "שחקנים";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.PlayerClick);
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.citiesToolStripMenuItem.Text = "ערים";
            this.citiesToolStripMenuItem.Click += new System.EventHandler(this.CitiesClick);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gamesToolStripMenuItem.Text = "משחקים";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.GamesClick);
            // 
            // gameStepsToolStripMenuItem
            // 
            this.gameStepsToolStripMenuItem.Name = "gameStepsToolStripMenuItem";
            this.gameStepsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gameStepsToolStripMenuItem.Text = "מהלכי משחק";
            this.gameStepsToolStripMenuItem.Click += new System.EventHandler(this.GameStepsClick);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.gameStepToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.addToolStripMenuItem.Text = "הוספה";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.playerToolStripMenuItem.Text = "שחקן";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.AddPlayerClick);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cityToolStripMenuItem.Text = "עיר";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.AddCityClick);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gameToolStripMenuItem.Text = "משחק";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.AddGameClick);
            // 
            // gameStepToolStripMenuItem
            // 
            this.gameStepToolStripMenuItem.Name = "gameStepToolStripMenuItem";
            this.gameStepToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gameStepToolStripMenuItem.Text = "מהלך משחק";
            this.gameStepToolStripMenuItem.Click += new System.EventHandler(this.gameStepToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem1,
            this.gameToolStripMenuItem1,
            this.stepToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.updateToolStripMenuItem.Text = "עידכון";
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.playerToolStripMenuItem1.Text = "שחקן";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.updatePlayerClick);
            // 
            // gameToolStripMenuItem1
            // 
            this.gameToolStripMenuItem1.Name = "gameToolStripMenuItem1";
            this.gameToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.gameToolStripMenuItem1.Text = "משחק";
            this.gameToolStripMenuItem1.Click += new System.EventHandler(this.gameToolStripMenuItem1_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.stepToolStripMenuItem.Text = "מהלך";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesOfPlayerToolStripMenuItem,
            this.RptStepsInGameToolStripMenuItem,
            this.RPTGamesByDateToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.reportToolStripMenuItem.Text = "דו\"ח";
            // 
            // gamesOfPlayerToolStripMenuItem
            // 
            this.gamesOfPlayerToolStripMenuItem.Name = "gamesOfPlayerToolStripMenuItem";
            this.gamesOfPlayerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gamesOfPlayerToolStripMenuItem.Text = "דו\"ח משחקים של שחקן";
            this.gamesOfPlayerToolStripMenuItem.Click += new System.EventHandler(this.gamesOfPlayerToolStripMenuItem_Click);
            // 
            // RptStepsInGameToolStripMenuItem
            // 
            this.RptStepsInGameToolStripMenuItem.Name = "RptStepsInGameToolStripMenuItem";
            this.RptStepsInGameToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.RptStepsInGameToolStripMenuItem.Text = "דו\"ח מהלכים של משחק";
            this.RptStepsInGameToolStripMenuItem.Click += new System.EventHandler(this.RptStepsInGameToolStripMenuItem_Click);
            // 
            // RPTGamesByDateToolStripMenuItem
            // 
            this.RPTGamesByDateToolStripMenuItem.Name = "RPTGamesByDateToolStripMenuItem";
            this.RPTGamesByDateToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.RPTGamesByDateToolStripMenuItem.Text = "דו\"ח משחקים לפי תאריך";
            this.RPTGamesByDateToolStripMenuItem.Click += new System.EventHandler(this.RPTGamesByDateToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem2
            // 
            this.gameToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twoPlayersToolStripMenuItem,
            this.onePlayerToolStripMenuItem});
            this.gameToolStripMenuItem2.Name = "gameToolStripMenuItem2";
            this.gameToolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.gameToolStripMenuItem2.Text = "משחק";
            // 
            // twoPlayersToolStripMenuItem
            // 
            this.twoPlayersToolStripMenuItem.Name = "twoPlayersToolStripMenuItem";
            this.twoPlayersToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.twoPlayersToolStripMenuItem.Text = "שני שחקנים";
            this.twoPlayersToolStripMenuItem.Click += new System.EventHandler(this.twoPlayersToolStripMenuItem_Click);
            // 
            // onePlayerToolStripMenuItem
            // 
            this.onePlayerToolStripMenuItem.Name = "onePlayerToolStripMenuItem";
            this.onePlayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.onePlayerToolStripMenuItem.Text = "שחקן אחד";
            this.onePlayerToolStripMenuItem.Click += new System.EventHandler(this.onePlayerToolStripMenuItem_Click);
            // 
            // viewGameToolStripMenuItem
            // 
            this.viewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGameToolStripMenuItem1});
            this.viewGameToolStripMenuItem.Name = "viewGameToolStripMenuItem";
            this.viewGameToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.viewGameToolStripMenuItem.Text = "צפיה במשחק";
            // 
            // viewGameToolStripMenuItem1
            // 
            this.viewGameToolStripMenuItem1.Name = "viewGameToolStripMenuItem1";
            this.viewGameToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.viewGameToolStripMenuItem1.Text = "צפיה במשחק";
            this.viewGameToolStripMenuItem1.Click += new System.EventHandler(this.viewGameToolStripMenuItem1_Click);
            // 
            // תרשימיםToolStripMenuItem
            // 
            this.תרשימיםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesAndPlayersToolStripMenuItem});
            this.תרשימיםToolStripMenuItem.Name = "תרשימיםToolStripMenuItem";
            this.תרשימיםToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.תרשימיםToolStripMenuItem.Text = "תרשימים";
            // 
            // gamesAndPlayersToolStripMenuItem
            // 
            this.gamesAndPlayersToolStripMenuItem.Name = "gamesAndPlayersToolStripMenuItem";
            this.gamesAndPlayersToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gamesAndPlayersToolStripMenuItem.Text = "התפלגות משחקים לשחקן";
            this.gamesAndPlayersToolStripMenuItem.Click += new System.EventHandler(this.gamesAndPlayersToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 260);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(532, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesOfPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RptStepsInGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RPTGamesByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem twoPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onePlayerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem תרשימיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesAndPlayersToolStripMenuItem;

    }
}