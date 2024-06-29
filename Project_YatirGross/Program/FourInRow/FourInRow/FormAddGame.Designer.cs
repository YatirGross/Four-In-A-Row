namespace FourInRow
{
    partial class FormAddGame
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
            this.label6 = new System.Windows.Forms.Label();
            this.GamedataGrid = new System.Windows.Forms.DataGridView();
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
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GameDate = new System.Windows.Forms.DateTimePicker();
            this.GameTime = new System.Windows.Forms.DateTimePicker();
            this.colsBox = new System.Windows.Forms.TextBox();
            this.rowsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.player1ID = new System.Windows.Forms.ComboBox();
            this.player2ID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gameSecondBox = new System.Windows.Forms.TextBox();
            this.gameStepsBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.player1Start = new System.Windows.Forms.CheckBox();
            this.Player1Win = new System.Windows.Forms.CheckBox();
            this.computerPlayer = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GamedataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(285, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = " הוספת משחק";
            // 
            // GamedataGrid
            // 
            this.GamedataGrid.AutoGenerateColumns = false;
            this.GamedataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamedataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.GamedataGrid.DataSource = this.tblGamesBindingSource;
            this.GamedataGrid.Location = new System.Drawing.Point(57, 293);
            this.GamedataGrid.Name = "GamedataGrid";
            this.GamedataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GamedataGrid.Size = new System.Drawing.Size(776, 150);
            this.GamedataGrid.TabIndex = 27;
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
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(57, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 70);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 80);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "שעה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 127);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "מספר שורות:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ת\"ז שחקן א:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 127);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "מספר עמודות:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(780, 80);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "תאריך:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 177);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "צבע שחקן א:";
            // 
            // GameDate
            // 
            this.GameDate.Location = new System.Drawing.Point(612, 75);
            this.GameDate.Name = "GameDate";
            this.GameDate.Size = new System.Drawing.Size(166, 20);
            this.GameDate.TabIndex = 36;
            // 
            // GameTime
            // 
            this.GameTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.GameTime.Location = new System.Drawing.Point(484, 75);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(66, 20);
            this.GameTime.TabIndex = 37;
            // 
            // colsBox
            // 
            this.colsBox.Location = new System.Drawing.Point(466, 124);
            this.colsBox.Name = "colsBox";
            this.colsBox.Size = new System.Drawing.Size(38, 20);
            this.colsBox.TabIndex = 39;
            // 
            // rowsBox
            // 
            this.rowsBox.Location = new System.Drawing.Point(707, 124);
            this.rowsBox.Name = "rowsBox";
            this.rowsBox.Size = new System.Drawing.Size(38, 20);
            this.rowsBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 177);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ת\"ז שחקן ב:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 177);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "צבע שחקן ב:";
            // 
            // player1ID
            // 
            this.player1ID.FormattingEnabled = true;
            this.player1ID.Location = new System.Drawing.Point(249, 124);
            this.player1ID.Name = "player1ID";
            this.player1ID.Size = new System.Drawing.Size(76, 21);
            this.player1ID.TabIndex = 40;
            // 
            // player2ID
            // 
            this.player2ID.FormattingEnabled = true;
            this.player2ID.Location = new System.Drawing.Point(438, 174);
            this.player2ID.Name = "player2ID";
            this.player2ID.Size = new System.Drawing.Size(76, 21);
            this.player2ID.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(757, 232);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "משך משחק:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 232);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "מספר מהלכים:";
            // 
            // gameSecondBox
            // 
            this.gameSecondBox.Location = new System.Drawing.Point(698, 229);
            this.gameSecondBox.Name = "gameSecondBox";
            this.gameSecondBox.Size = new System.Drawing.Size(58, 20);
            this.gameSecondBox.TabIndex = 41;
            // 
            // gameStepsBox2
            // 
            this.gameStepsBox2.Location = new System.Drawing.Point(446, 229);
            this.gameStepsBox2.Name = "gameStepsBox2";
            this.gameStepsBox2.Size = new System.Drawing.Size(58, 20);
            this.gameStepsBox2.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "בחר צבע";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "בחר צבע";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // player1Start
            // 
            this.player1Start.AutoSize = true;
            this.player1Start.Location = new System.Drawing.Point(290, 228);
            this.player1Start.Name = "player1Start";
            this.player1Start.Size = new System.Drawing.Size(101, 17);
            this.player1Start.TabIndex = 47;
            this.player1Start.Text = "התחיל שחקן א";
            this.player1Start.UseVisualStyleBackColor = true;
            // 
            // Player1Win
            // 
            this.Player1Win.AutoSize = true;
            this.Player1Win.Location = new System.Drawing.Point(137, 228);
            this.Player1Win.Name = "Player1Win";
            this.Player1Win.Size = new System.Drawing.Size(102, 17);
            this.Player1Win.TabIndex = 48;
            this.Player1Win.Text = "ניצחון שחקן א";
            this.Player1Win.UseVisualStyleBackColor = true;
            // 
            // computerPlayer
            // 
            this.computerPlayer.AutoSize = true;
            this.computerPlayer.Location = new System.Drawing.Point(314, 78);
            this.computerPlayer.Name = "computerPlayer";
            this.computerPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.computerPlayer.Size = new System.Drawing.Size(87, 17);
            this.computerPlayer.TabIndex = 49;
            this.computerPlayer.Text = "שחקן מחשב";
            this.computerPlayer.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(748, 273);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "טבלת משחקים";
            // 
            // FormAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(888, 471);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.computerPlayer);
            this.Controls.Add(this.Player1Win);
            this.Controls.Add(this.player1Start);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.GamedataGrid);
            this.Controls.Add(this.label6);
            this.Name = "FormAddGame";
            this.Text = "FormAddGame";
            this.Load += new System.EventHandler(this.FormAddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GamedataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GamedataGrid;
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker GameDate;
        private System.Windows.Forms.DateTimePicker GameTime;
        private System.Windows.Forms.TextBox colsBox;
        private System.Windows.Forms.TextBox rowsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox player1ID;
        private System.Windows.Forms.ComboBox player2ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gameSecondBox;
        private System.Windows.Forms.TextBox gameStepsBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox player1Start;
        private System.Windows.Forms.CheckBox Player1Win;
        private System.Windows.Forms.CheckBox computerPlayer;
        private System.Windows.Forms.Label label12;
    }
}