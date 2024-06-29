namespace FourInRow
{
    partial class FormRptGamesOfPlayer
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
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIsManagerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPlayers = new FourInRow.DataSetPlayers();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblPlayersTableAdapter = new FourInRow.DataSetPlayersTableAdapters.tblPlayersTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.playerFirstNameDataGridViewTextBoxColumn,
            this.playerLastNameDataGridViewTextBoxColumn,
            this.playerAddressDataGridViewTextBoxColumn,
            this.playerCountryDataGridViewTextBoxColumn,
            this.playerCityDataGridViewTextBoxColumn,
            this.playerPasswordDataGridViewTextBoxColumn,
            this.playerIsManagerDataGridViewCheckBoxColumn,
            this.playerPhoneDataGridViewTextBoxColumn,
            this.playerMobileDataGridViewTextBoxColumn,
            this.playerMailDataGridViewTextBoxColumn,
            this.playerPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPlayersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "playerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // playerFirstNameDataGridViewTextBoxColumn
            // 
            this.playerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "playerFirstName";
            this.playerFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.playerFirstNameDataGridViewTextBoxColumn.Name = "playerFirstNameDataGridViewTextBoxColumn";
            // 
            // playerLastNameDataGridViewTextBoxColumn
            // 
            this.playerLastNameDataGridViewTextBoxColumn.DataPropertyName = "playerLastName";
            this.playerLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.playerLastNameDataGridViewTextBoxColumn.Name = "playerLastNameDataGridViewTextBoxColumn";
            // 
            // playerAddressDataGridViewTextBoxColumn
            // 
            this.playerAddressDataGridViewTextBoxColumn.DataPropertyName = "playerAddress";
            this.playerAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.playerAddressDataGridViewTextBoxColumn.Name = "playerAddressDataGridViewTextBoxColumn";
            // 
            // playerCountryDataGridViewTextBoxColumn
            // 
            this.playerCountryDataGridViewTextBoxColumn.DataPropertyName = "playerCountry";
            this.playerCountryDataGridViewTextBoxColumn.HeaderText = "מדינה";
            this.playerCountryDataGridViewTextBoxColumn.Name = "playerCountryDataGridViewTextBoxColumn";
            // 
            // playerCityDataGridViewTextBoxColumn
            // 
            this.playerCityDataGridViewTextBoxColumn.DataPropertyName = "playerCity";
            this.playerCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.playerCityDataGridViewTextBoxColumn.Name = "playerCityDataGridViewTextBoxColumn";
            // 
            // playerPasswordDataGridViewTextBoxColumn
            // 
            this.playerPasswordDataGridViewTextBoxColumn.DataPropertyName = "playerPassword";
            this.playerPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמא";
            this.playerPasswordDataGridViewTextBoxColumn.Name = "playerPasswordDataGridViewTextBoxColumn";
            // 
            // playerIsManagerDataGridViewCheckBoxColumn
            // 
            this.playerIsManagerDataGridViewCheckBoxColumn.DataPropertyName = "playerIsManager";
            this.playerIsManagerDataGridViewCheckBoxColumn.HeaderText = "מנהל";
            this.playerIsManagerDataGridViewCheckBoxColumn.Name = "playerIsManagerDataGridViewCheckBoxColumn";
            // 
            // playerPhoneDataGridViewTextBoxColumn
            // 
            this.playerPhoneDataGridViewTextBoxColumn.DataPropertyName = "playerPhone";
            this.playerPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.playerPhoneDataGridViewTextBoxColumn.Name = "playerPhoneDataGridViewTextBoxColumn";
            // 
            // playerMobileDataGridViewTextBoxColumn
            // 
            this.playerMobileDataGridViewTextBoxColumn.DataPropertyName = "playerMobile";
            this.playerMobileDataGridViewTextBoxColumn.HeaderText = "נייד";
            this.playerMobileDataGridViewTextBoxColumn.Name = "playerMobileDataGridViewTextBoxColumn";
            // 
            // playerMailDataGridViewTextBoxColumn
            // 
            this.playerMailDataGridViewTextBoxColumn.DataPropertyName = "playerMail";
            this.playerMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.playerMailDataGridViewTextBoxColumn.Name = "playerMailDataGridViewTextBoxColumn";
            // 
            // playerPictureDataGridViewTextBoxColumn
            // 
            this.playerPictureDataGridViewTextBoxColumn.DataPropertyName = "playerPicture";
            this.playerPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.playerPictureDataGridViewTextBoxColumn.Name = "playerPictureDataGridViewTextBoxColumn";
            // 
            // tblPlayersBindingSource
            // 
            this.tblPlayersBindingSource.DataMember = "tblPlayers";
            this.tblPlayersBindingSource.DataSource = this.dataSetPlayers;
            // 
            // dataSetPlayers
            // 
            this.dataSetPlayers.DataSetName = "DataSetPlayers";
            this.dataSetPlayers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(227, 46);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(80, 40);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(141, 46);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(80, 40);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(481, 46);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 40);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(395, 46);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 40);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(434, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "דוח משחקים של שחקן";
            // 
            // textboxID
            // 
            this.textboxID.Enabled = false;
            this.textboxID.Location = new System.Drawing.Point(669, 46);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 20);
            this.textboxID.TabIndex = 7;
            this.textboxID.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(775, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ת\"ז:";
            // 
            // tblPlayersTableAdapter
            // 
            this.tblPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.Location = new System.Drawing.Point(33, 251);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1187, 252);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "תז";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר מזהה";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "תאריך";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שעה";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שחקן מחשב";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "מספר שורות";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "מספר עמודות";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ת\"ז שחקן א";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "צבע שחקן א";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ת\"ז שחקן ב";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "צבע שחקן ב";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "משך המשחק";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "מספר מהלכים";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "התחיל שחקן א";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "ניצחון שחקן א";
            this.columnHeader15.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1024, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 218);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(1225, 251);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 33);
            this.ColorButton.TabIndex = 10;
            this.ColorButton.Text = "צבע";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1225, 290);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 33);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "ניקוי";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(917, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "טבלת שחקנים";
            // 
            // FormRptGamesOfPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1322, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRptGamesOfPlayer";
            this.Text = "FormRptGamesOfPlayer";
            this.Load += new System.EventHandler(this.FormRptGamesOfPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label label2;
        private DataSetPlayers dataSetPlayers;
        private System.Windows.Forms.BindingSource tblPlayersBindingSource;
        private DataSetPlayersTableAdapters.tblPlayersTableAdapter tblPlayersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn playerIsManagerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
    }
}