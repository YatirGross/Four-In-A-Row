namespace FourInRow
{
    partial class FormGames
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGames = new FourInRow.DataSetGames();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGamesTableAdapter = new FourInRow.DataSetGamesTableAdapters.tblGamesTableAdapter();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerComDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gameRowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameColsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerColor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerColor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameStepsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayer1StartDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.game1IsWinnerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.gameDateDataGridViewTextBoxColumn,
            this.gameTimeDataGridViewTextBoxColumn,
            this.gamePlayerComDataGridViewCheckBoxColumn,
            this.gameRowsDataGridViewTextBoxColumn,
            this.gameColsDataGridViewTextBoxColumn,
            this.gamePlayerID1DataGridViewTextBoxColumn,
            this.gamePlayerColor1DataGridViewTextBoxColumn,
            this.gamePlayerID2DataGridViewTextBoxColumn,
            this.gamePlayerColor2DataGridViewTextBoxColumn,
            this.gameSecondsDataGridViewTextBoxColumn,
            this.gameStepsDataGridViewTextBoxColumn,
            this.gamePlayer1StartDataGridViewCheckBoxColumn,
            this.game1IsWinnerDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblGamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblGamesBindingSource
            // 
            this.tblGamesBindingSource.DataMember = "tblGames";
            this.tblGamesBindingSource.DataSource = this.dataSetGames;
            // 
            // dataSetGames
            // 
            this.dataSetGames.DataSetName = "DataSetGames";
            this.dataSetGames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(270, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(244, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת משחקים";
            // 
            // tblGamesTableAdapter
            // 
            this.tblGamesTableAdapter.ClearBeforeFill = true;
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "GameID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "מספר משחק";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            // 
            // gameDateDataGridViewTextBoxColumn
            // 
            this.gameDateDataGridViewTextBoxColumn.DataPropertyName = "gameDate";
            this.gameDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.gameDateDataGridViewTextBoxColumn.Name = "gameDateDataGridViewTextBoxColumn";
            // 
            // gameTimeDataGridViewTextBoxColumn
            // 
            this.gameTimeDataGridViewTextBoxColumn.DataPropertyName = "gameTime";
            this.gameTimeDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.gameTimeDataGridViewTextBoxColumn.Name = "gameTimeDataGridViewTextBoxColumn";
            // 
            // gamePlayerComDataGridViewCheckBoxColumn
            // 
            this.gamePlayerComDataGridViewCheckBoxColumn.DataPropertyName = "gamePlayerCom";
            this.gamePlayerComDataGridViewCheckBoxColumn.HeaderText = "שחקן מחשב";
            this.gamePlayerComDataGridViewCheckBoxColumn.Name = "gamePlayerComDataGridViewCheckBoxColumn";
            // 
            // gameRowsDataGridViewTextBoxColumn
            // 
            this.gameRowsDataGridViewTextBoxColumn.DataPropertyName = "gameRows";
            this.gameRowsDataGridViewTextBoxColumn.HeaderText = "שורות";
            this.gameRowsDataGridViewTextBoxColumn.Name = "gameRowsDataGridViewTextBoxColumn";
            // 
            // gameColsDataGridViewTextBoxColumn
            // 
            this.gameColsDataGridViewTextBoxColumn.DataPropertyName = "gameCols";
            this.gameColsDataGridViewTextBoxColumn.HeaderText = "עמודות";
            this.gameColsDataGridViewTextBoxColumn.Name = "gameColsDataGridViewTextBoxColumn";
            // 
            // gamePlayerID1DataGridViewTextBoxColumn
            // 
            this.gamePlayerID1DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerID1";
            this.gamePlayerID1DataGridViewTextBoxColumn.HeaderText = "ת\"ז שחקן א";
            this.gamePlayerID1DataGridViewTextBoxColumn.Name = "gamePlayerID1DataGridViewTextBoxColumn";
            // 
            // gamePlayerColor1DataGridViewTextBoxColumn
            // 
            this.gamePlayerColor1DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerColor1";
            this.gamePlayerColor1DataGridViewTextBoxColumn.HeaderText = "צבע שחקן א";
            this.gamePlayerColor1DataGridViewTextBoxColumn.Name = "gamePlayerColor1DataGridViewTextBoxColumn";
            // 
            // gamePlayerID2DataGridViewTextBoxColumn
            // 
            this.gamePlayerID2DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerID2";
            this.gamePlayerID2DataGridViewTextBoxColumn.HeaderText = "ת\"ז שחקן ב";
            this.gamePlayerID2DataGridViewTextBoxColumn.Name = "gamePlayerID2DataGridViewTextBoxColumn";
            // 
            // gamePlayerColor2DataGridViewTextBoxColumn
            // 
            this.gamePlayerColor2DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerColor2";
            this.gamePlayerColor2DataGridViewTextBoxColumn.HeaderText = "צבע שחקן ב";
            this.gamePlayerColor2DataGridViewTextBoxColumn.Name = "gamePlayerColor2DataGridViewTextBoxColumn";
            // 
            // gameSecondsDataGridViewTextBoxColumn
            // 
            this.gameSecondsDataGridViewTextBoxColumn.DataPropertyName = "gameSeconds";
            this.gameSecondsDataGridViewTextBoxColumn.HeaderText = "משך המשחק";
            this.gameSecondsDataGridViewTextBoxColumn.Name = "gameSecondsDataGridViewTextBoxColumn";
            // 
            // gameStepsDataGridViewTextBoxColumn
            // 
            this.gameStepsDataGridViewTextBoxColumn.DataPropertyName = "gameSteps";
            this.gameStepsDataGridViewTextBoxColumn.HeaderText = "מספר מהלכים";
            this.gameStepsDataGridViewTextBoxColumn.Name = "gameStepsDataGridViewTextBoxColumn";
            // 
            // gamePlayer1StartDataGridViewCheckBoxColumn
            // 
            this.gamePlayer1StartDataGridViewCheckBoxColumn.DataPropertyName = "gamePlayer1Start";
            this.gamePlayer1StartDataGridViewCheckBoxColumn.HeaderText = "שחקן א מתחיל";
            this.gamePlayer1StartDataGridViewCheckBoxColumn.Name = "gamePlayer1StartDataGridViewCheckBoxColumn";
            // 
            // game1IsWinnerDataGridViewCheckBoxColumn
            // 
            this.game1IsWinnerDataGridViewCheckBoxColumn.DataPropertyName = "Game1IsWinner";
            this.game1IsWinnerDataGridViewCheckBoxColumn.HeaderText = "ניצחון שחקן א";
            this.game1IsWinnerDataGridViewCheckBoxColumn.Name = "game1IsWinnerDataGridViewCheckBoxColumn";
            // 
            // FormGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGames";
            this.Text = "FormGames";
            this.Load += new System.EventHandler(this.FormGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private DataSetGames dataSetGames;
        private System.Windows.Forms.BindingSource tblGamesBindingSource;
        private DataSetGamesTableAdapters.tblGamesTableAdapter tblGamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gamePlayerComDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameRowsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameColsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerColor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerColor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStepsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gamePlayer1StartDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn game1IsWinnerDataGridViewCheckBoxColumn;
    }
}