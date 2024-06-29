namespace FourInRow
{
    partial class FormPlayers
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
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
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת שחקנים";
            // 
            // FormPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormPlayers";
            this.Text = "FormPlayers";
            this.Load += new System.EventHandler(this.FormPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}