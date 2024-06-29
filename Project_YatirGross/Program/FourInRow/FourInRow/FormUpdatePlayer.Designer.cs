namespace FourInRow
{
    partial class FormUpdatePlayer
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
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.picturelocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.managercheckBox = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
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
            this.tblPlayersTableAdapter = new FourInRow.DataSetPlayersTableAdapters.tblPlayersTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(59, 112);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 53;
            // 
            // picturelocation
            // 
            this.picturelocation.Location = new System.Drawing.Point(99, 197);
            this.picturelocation.Name = "picturelocation";
            this.picturelocation.Size = new System.Drawing.Size(161, 20);
            this.picturelocation.TabIndex = 52;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(48, 195);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(45, 23);
            this.buttonBrowse.TabIndex = 51;
            this.buttonBrowse.Text = "עיין";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(548, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // managercheckBox
            // 
            this.managercheckBox.AutoSize = true;
            this.managercheckBox.Location = new System.Drawing.Point(335, 199);
            this.managercheckBox.Name = "managercheckBox";
            this.managercheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managercheckBox.Size = new System.Drawing.Size(52, 17);
            this.managercheckBox.TabIndex = 49;
            this.managercheckBox.Text = "מנהל";
            this.managercheckBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(426, 112);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(67, 20);
            this.addressBox.TabIndex = 48;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(426, 154);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(67, 20);
            this.passwordBox.TabIndex = 47;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(426, 197);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(67, 20);
            this.mailBox.TabIndex = 46;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(276, 69);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(67, 20);
            this.firstNameBox.TabIndex = 45;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(276, 112);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(67, 20);
            this.countryBox.TabIndex = 44;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(276, 154);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(67, 20);
            this.phoneBox.TabIndex = 43;
            // 
            // mobileBox
            // 
            this.mobileBox.Location = new System.Drawing.Point(113, 154);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(67, 20);
            this.mobileBox.TabIndex = 42;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(113, 69);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(67, 20);
            this.lastNameBox.TabIndex = 41;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(426, 69);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(67, 20);
            this.idBox.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(499, 115);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "כתובת:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 157);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "סיסמה:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 200);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "מייל:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 72);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "שם פרטי:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 115);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "מדינה:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 157);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "טלפון:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 72);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "שם משפחה:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 200);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "תמונה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "נייד:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 115);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "עיר:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ת\"ז:";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(458, 232);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(50, 30);
            this.buttonFirst.TabIndex = 54;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(402, 232);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 30);
            this.buttonNext.TabIndex = 55;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(293, 232);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(50, 30);
            this.buttonLast.TabIndex = 56;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(237, 232);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(50, 30);
            this.buttonPrev.TabIndex = 57;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(83, 232);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 58;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(796, 150);
            this.dataGridView1.TabIndex = 59;
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
            this.playerPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמה";
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
            this.playerMailDataGridViewTextBoxColumn.HeaderText = "דואר אלקטרוני";
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
            // tblPlayersTableAdapter
            // 
            this.tblPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(344, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 60;
            this.label6.Text = "עדכון שחקן";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(723, 266);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "טבלת שחקנים";
            // 
            // FormUpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.picturelocation);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.managercheckBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePlayer";
            this.Text = "FormUpdatePlayer";
            this.Load += new System.EventHandler(this.FormUpdatePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox picturelocation;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox managercheckBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label13;
    }
}