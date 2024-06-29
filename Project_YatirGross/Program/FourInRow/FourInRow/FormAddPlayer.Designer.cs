namespace FourInRow
{
    partial class FormAddPlayer
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
            this.tblPlayersTableAdapter = new FourInRow.DataSetPlayersTableAdapters.tblPlayersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.managercheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.picturelocation = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(780, 147);
            this.dataGridView1.TabIndex = 0;
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
            // tblPlayersTableAdapter
            // 
            this.tblPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ת\"ז:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "עיר:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "נייד:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 173);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "תמונה:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "שם משפחה:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 130);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "טלפון:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 88);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "מדינה:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 45);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "שם פרטי:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 173);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "מייל:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 130);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "סיסמה:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 88);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "כתובת:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(454, 42);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(67, 20);
            this.idBox.TabIndex = 13;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(141, 42);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(67, 20);
            this.lastNameBox.TabIndex = 14;
            // 
            // mobileBox
            // 
            this.mobileBox.Location = new System.Drawing.Point(141, 127);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(67, 20);
            this.mobileBox.TabIndex = 15;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(304, 127);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(67, 20);
            this.phoneBox.TabIndex = 16;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(304, 85);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(67, 20);
            this.countryBox.TabIndex = 17;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(304, 42);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(67, 20);
            this.firstNameBox.TabIndex = 18;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(454, 170);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(67, 20);
            this.mailBox.TabIndex = 19;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(454, 127);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(67, 20);
            this.passwordBox.TabIndex = 20;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(454, 85);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(67, 20);
            this.addressBox.TabIndex = 21;
            // 
            // managercheckBox
            // 
            this.managercheckBox.AutoSize = true;
            this.managercheckBox.Location = new System.Drawing.Point(363, 172);
            this.managercheckBox.Name = "managercheckBox";
            this.managercheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.managercheckBox.Size = new System.Drawing.Size(52, 17);
            this.managercheckBox.TabIndex = 22;
            this.managercheckBox.Text = "מנהל";
            this.managercheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(335, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 30);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(576, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(330, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "הוספת שחקן";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(76, 168);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(45, 23);
            this.buttonBrowse.TabIndex = 26;
            this.buttonBrowse.Text = "עיין";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // picturelocation
            // 
            this.picturelocation.Location = new System.Drawing.Point(127, 170);
            this.picturelocation.Name = "picturelocation";
            this.picturelocation.Size = new System.Drawing.Size(161, 20);
            this.picturelocation.TabIndex = 27;
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(87, 85);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(716, 240);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "טבלת שחקנים";
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.picturelocation);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addButton);
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
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAddPlayer";
            this.Text = "FormAddPlayer";
            this.Load += new System.EventHandler(this.FormAddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPlayers dataSetPlayers;
        private System.Windows.Forms.BindingSource tblPlayersBindingSource;
        private DataSetPlayersTableAdapters.tblPlayersTableAdapter tblPlayersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox managercheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox picturelocation;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label13;
    }
}