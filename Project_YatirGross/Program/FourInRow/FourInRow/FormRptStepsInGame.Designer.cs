namespace FourInRow
{
    partial class FormRptStepsInGame
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
            this.tblGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGames = new FourInRow.DataSetGames();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameIDBox = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tblGamesTableAdapter = new FourInRow.DataSetGamesTableAdapters.tblGamesTableAdapter();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.gameRowsDataGridViewTextBoxColumn.HeaderText = "מספר שורות";
            this.gameRowsDataGridViewTextBoxColumn.Name = "gameRowsDataGridViewTextBoxColumn";
            // 
            // gameColsDataGridViewTextBoxColumn
            // 
            this.gameColsDataGridViewTextBoxColumn.DataPropertyName = "gameCols";
            this.gameColsDataGridViewTextBoxColumn.HeaderText = "מספר עמודות";
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
            this.gamePlayer1StartDataGridViewCheckBoxColumn.HeaderText = "התחיל שחקן א";
            this.gamePlayer1StartDataGridViewCheckBoxColumn.Name = "gamePlayer1StartDataGridViewCheckBoxColumn";
            // 
            // game1IsWinnerDataGridViewCheckBoxColumn
            // 
            this.game1IsWinnerDataGridViewCheckBoxColumn.DataPropertyName = "Game1IsWinner";
            this.game1IsWinnerDataGridViewCheckBoxColumn.HeaderText = "ניצחון שחקן א";
            this.game1IsWinnerDataGridViewCheckBoxColumn.Name = "game1IsWinnerDataGridViewCheckBoxColumn";
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(12, 270);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(509, 249);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מספר משחק";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר סידורי";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שחקן א";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "כחלוף שניות";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שורה";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "עמודה";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "דוח מהלכים של משחק";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(527, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "מספר משחק:";
            // 
            // gameIDBox
            // 
            this.gameIDBox.Enabled = false;
            this.gameIDBox.Location = new System.Drawing.Point(421, 62);
            this.gameIDBox.Name = "gameIDBox";
            this.gameIDBox.Size = new System.Drawing.Size(100, 20);
            this.gameIDBox.TabIndex = 9;
            this.gameIDBox.TextChanged += new System.EventHandler(this.gameIDBox_TextChanged);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(329, 60);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 30);
            this.buttonFirst.TabIndex = 11;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(248, 60);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 30);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(127, 60);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 30);
            this.buttonLast.TabIndex = 13;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(46, 60);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 30);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // tblGamesTableAdapter
            // 
            this.tblGamesTableAdapter.ClearBeforeFill = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(527, 324);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(132, 48);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "ניקוי";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(527, 270);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(132, 48);
            this.ColorButton.TabIndex = 15;
            this.ColorButton.Text = "צבע";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(574, 94);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "טבלת משחקים";
            // 
            // FormRptStepsInGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(671, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRptStepsInGame";
            this.Text = "FormRptStepsInGame";
            this.Load += new System.EventHandler(this.FormRptStepsInGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameIDBox;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
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
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
    }
}