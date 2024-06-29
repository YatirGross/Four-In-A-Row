namespace FourInRow
{
    partial class FormUpdateGame
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
            this.buttonPlayer2 = new System.Windows.Forms.Button();
            this.buttonPlayer1 = new System.Windows.Forms.Button();
            this.gameStepsBox2 = new System.Windows.Forms.TextBox();
            this.gameSecondBox = new System.Windows.Forms.TextBox();
            this.player2ID = new System.Windows.Forms.ComboBox();
            this.player1ID = new System.Windows.Forms.ComboBox();
            this.rowsBox = new System.Windows.Forms.TextBox();
            this.colsBox = new System.Windows.Forms.TextBox();
            this.GameTime = new System.Windows.Forms.DateTimePicker();
            this.GameDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tblGamesTableAdapter = new FourInRow.DataSetGamesTableAdapters.tblGamesTableAdapter();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.GameIDBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPlayer1 = new System.Windows.Forms.TextBox();
            this.colorPlayer2 = new System.Windows.Forms.TextBox();
            this.player1Start = new System.Windows.Forms.CheckBox();
            this.player1Win = new System.Windows.Forms.CheckBox();
            this.computerPlayer = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlayer2
            // 
            this.buttonPlayer2.Location = new System.Drawing.Point(175, 157);
            this.buttonPlayer2.Name = "buttonPlayer2";
            this.buttonPlayer2.Size = new System.Drawing.Size(58, 23);
            this.buttonPlayer2.TabIndex = 72;
            this.buttonPlayer2.Text = "בחר צבע";
            this.buttonPlayer2.UseVisualStyleBackColor = true;
            this.buttonPlayer2.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPlayer1
            // 
            this.buttonPlayer1.Location = new System.Drawing.Point(590, 157);
            this.buttonPlayer1.Name = "buttonPlayer1";
            this.buttonPlayer1.Size = new System.Drawing.Size(55, 23);
            this.buttonPlayer1.TabIndex = 71;
            this.buttonPlayer1.Text = "בחר צבע";
            this.buttonPlayer1.UseVisualStyleBackColor = true;
            this.buttonPlayer1.Click += new System.EventHandler(this.button3_Click);
            // 
            // gameStepsBox2
            // 
            this.gameStepsBox2.Location = new System.Drawing.Point(414, 214);
            this.gameStepsBox2.Name = "gameStepsBox2";
            this.gameStepsBox2.Size = new System.Drawing.Size(58, 20);
            this.gameStepsBox2.TabIndex = 66;
            // 
            // gameSecondBox
            // 
            this.gameSecondBox.Location = new System.Drawing.Point(666, 214);
            this.gameSecondBox.Name = "gameSecondBox";
            this.gameSecondBox.Size = new System.Drawing.Size(58, 20);
            this.gameSecondBox.TabIndex = 65;
            // 
            // player2ID
            // 
            this.player2ID.FormattingEnabled = true;
            this.player2ID.Location = new System.Drawing.Point(406, 159);
            this.player2ID.Name = "player2ID";
            this.player2ID.Size = new System.Drawing.Size(76, 21);
            this.player2ID.TabIndex = 64;
            // 
            // player1ID
            // 
            this.player1ID.FormattingEnabled = true;
            this.player1ID.Location = new System.Drawing.Point(217, 109);
            this.player1ID.Name = "player1ID";
            this.player1ID.Size = new System.Drawing.Size(76, 21);
            this.player1ID.TabIndex = 63;
            // 
            // rowsBox
            // 
            this.rowsBox.Location = new System.Drawing.Point(675, 109);
            this.rowsBox.Name = "rowsBox";
            this.rowsBox.Size = new System.Drawing.Size(38, 20);
            this.rowsBox.TabIndex = 61;
            // 
            // colsBox
            // 
            this.colsBox.Location = new System.Drawing.Point(434, 109);
            this.colsBox.Name = "colsBox";
            this.colsBox.Size = new System.Drawing.Size(38, 20);
            this.colsBox.TabIndex = 62;
            // 
            // GameTime
            // 
            this.GameTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.GameTime.Location = new System.Drawing.Point(217, 59);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(66, 20);
            this.GameTime.TabIndex = 59;
            // 
            // GameDate
            // 
            this.GameDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.GameDate.Location = new System.Drawing.Point(345, 59);
            this.GameDate.Name = "GameDate";
            this.GameDate.Size = new System.Drawing.Size(166, 20);
            this.GameDate.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 162);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "צבע שחקן ב:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 162);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "ת\"ז שחקן ב:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 162);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "צבע שחקן א:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 64);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "תאריך:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 112);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "מספר עמודות:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 113);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "ת\"ז שחקן א:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 217);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "מספר מהלכים:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 217);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "משך משחק:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "מספר שורות:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "שעה:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(383, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "עדכון משחק";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 215);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "GameID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
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
            // tblGamesTableAdapter
            // 
            this.tblGamesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(631, 261);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 74;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(550, 261);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 75;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(367, 261);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 76;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(286, 261);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 77;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 249);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 47);
            this.buttonUpdate.TabIndex = 78;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(725, 64);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "מספר מזהה:";
            // 
            // GameIDBox
            // 
            this.GameIDBox.Enabled = false;
            this.GameIDBox.Location = new System.Drawing.Point(619, 59);
            this.GameIDBox.Name = "GameIDBox";
            this.GameIDBox.Size = new System.Drawing.Size(100, 20);
            this.GameIDBox.TabIndex = 80;
            // 
            // colorPlayer1
            // 
            this.colorPlayer1.Enabled = false;
            this.colorPlayer1.Location = new System.Drawing.Point(651, 159);
            this.colorPlayer1.Name = "colorPlayer1";
            this.colorPlayer1.Size = new System.Drawing.Size(62, 20);
            this.colorPlayer1.TabIndex = 81;
            // 
            // colorPlayer2
            // 
            this.colorPlayer2.Enabled = false;
            this.colorPlayer2.Location = new System.Drawing.Point(239, 159);
            this.colorPlayer2.Name = "colorPlayer2";
            this.colorPlayer2.Size = new System.Drawing.Size(54, 20);
            this.colorPlayer2.TabIndex = 82;
            // 
            // player1Start
            // 
            this.player1Start.AutoSize = true;
            this.player1Start.Location = new System.Drawing.Point(252, 214);
            this.player1Start.Name = "player1Start";
            this.player1Start.Size = new System.Drawing.Size(101, 17);
            this.player1Start.TabIndex = 83;
            this.player1Start.Text = "התחיל שחקן א";
            this.player1Start.UseVisualStyleBackColor = true;
            // 
            // player1Win
            // 
            this.player1Win.AutoSize = true;
            this.player1Win.Location = new System.Drawing.Point(100, 212);
            this.player1Win.Name = "player1Win";
            this.player1Win.Size = new System.Drawing.Size(102, 17);
            this.player1Win.TabIndex = 84;
            this.player1Win.Text = "ניצחון שחקן א";
            this.player1Win.UseVisualStyleBackColor = true;
            // 
            // computerPlayer
            // 
            this.computerPlayer.AutoSize = true;
            this.computerPlayer.Location = new System.Drawing.Point(100, 111);
            this.computerPlayer.Name = "computerPlayer";
            this.computerPlayer.Size = new System.Drawing.Size(87, 17);
            this.computerPlayer.TabIndex = 85;
            this.computerPlayer.Text = "שחקן מחשב";
            this.computerPlayer.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(791, 279);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 86;
            this.label13.Text = "טבלת משחקים";
            // 
            // FormUpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(888, 535);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.computerPlayer);
            this.Controls.Add(this.player1Win);
            this.Controls.Add(this.player1Start);
            this.Controls.Add(this.colorPlayer2);
            this.Controls.Add(this.colorPlayer1);
            this.Controls.Add(this.GameIDBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPlayer2);
            this.Controls.Add(this.buttonPlayer1);
            this.Controls.Add(this.gameStepsBox2);
            this.Controls.Add(this.gameSecondBox);
            this.Controls.Add(this.player2ID);
            this.Controls.Add(this.player1ID);
            this.Controls.Add(this.rowsBox);
            this.Controls.Add(this.colsBox);
            this.Controls.Add(this.GameTime);
            this.Controls.Add(this.GameDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "FormUpdateGame";
            this.Text = "FormUpdateGame";
            this.Load += new System.EventHandler(this.FormUpdateGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayer2;
        private System.Windows.Forms.Button buttonPlayer1;
        private System.Windows.Forms.TextBox gameStepsBox2;
        private System.Windows.Forms.TextBox gameSecondBox;
        private System.Windows.Forms.ComboBox player2ID;
        private System.Windows.Forms.ComboBox player1ID;
        private System.Windows.Forms.TextBox rowsBox;
        private System.Windows.Forms.TextBox colsBox;
        private System.Windows.Forms.DateTimePicker GameTime;
        private System.Windows.Forms.DateTimePicker GameDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GameIDBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox colorPlayer1;
        private System.Windows.Forms.TextBox colorPlayer2;
        private System.Windows.Forms.CheckBox player1Start;
        private System.Windows.Forms.CheckBox player1Win;
        private System.Windows.Forms.CheckBox computerPlayer;
        private System.Windows.Forms.Label label13;
    }
}