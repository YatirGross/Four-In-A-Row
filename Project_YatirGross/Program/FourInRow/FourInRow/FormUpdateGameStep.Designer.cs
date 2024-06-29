namespace FourInRow
{
    partial class FormUpdateGameStep
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
            this.player1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stepNumber = new System.Windows.Forms.TextBox();
            this.afterSeconds = new System.Windows.Forms.TextBox();
            this.colBox = new System.Windows.Forms.TextBox();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stepGameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepPlayer1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stepAfterSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGameStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGameStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGameSteps = new FourInRow.DataSetGameSteps();
            this.tblGameStepsTableAdapter = new FourInRow.DataSetGameStepsTableAdapters.tblGameStepsTableAdapter();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.GameIdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(184, 76);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(65, 17);
            this.player1.TabIndex = 51;
            this.player1.Text = "שחקן א";
            this.player1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 81);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "מספר מהלך";
            // 
            // stepNumber
            // 
            this.stepNumber.Enabled = false;
            this.stepNumber.Location = new System.Drawing.Point(270, 76);
            this.stepNumber.Name = "stepNumber";
            this.stepNumber.Size = new System.Drawing.Size(50, 20);
            this.stepNumber.TabIndex = 49;
            // 
            // afterSeconds
            // 
            this.afterSeconds.Location = new System.Drawing.Point(36, 76);
            this.afterSeconds.Name = "afterSeconds";
            this.afterSeconds.Size = new System.Drawing.Size(50, 20);
            this.afterSeconds.TabIndex = 47;
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(276, 127);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(50, 20);
            this.colBox.TabIndex = 46;
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(431, 127);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(50, 20);
            this.rowBox.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 131);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "עמודה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "שורה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "כחלוף שניות:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 80);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "מספר משחק:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(235, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "עדכון מהלך";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepGameIDDataGridViewTextBoxColumn,
            this.stepNumDataGridViewTextBoxColumn,
            this.stepPlayer1DataGridViewCheckBoxColumn,
            this.stepAfterSecondsDataGridViewTextBoxColumn,
            this.stepRowDataGridViewTextBoxColumn,
            this.stepColDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGameStepsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 140);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stepGameIDDataGridViewTextBoxColumn
            // 
            this.stepGameIDDataGridViewTextBoxColumn.DataPropertyName = "stepGameID";
            this.stepGameIDDataGridViewTextBoxColumn.HeaderText = "מספר משחק";
            this.stepGameIDDataGridViewTextBoxColumn.Name = "stepGameIDDataGridViewTextBoxColumn";
            // 
            // stepNumDataGridViewTextBoxColumn
            // 
            this.stepNumDataGridViewTextBoxColumn.DataPropertyName = "stepNum";
            this.stepNumDataGridViewTextBoxColumn.HeaderText = "מספר מהלך";
            this.stepNumDataGridViewTextBoxColumn.Name = "stepNumDataGridViewTextBoxColumn";
            // 
            // stepPlayer1DataGridViewCheckBoxColumn
            // 
            this.stepPlayer1DataGridViewCheckBoxColumn.DataPropertyName = "stepPlayer1";
            this.stepPlayer1DataGridViewCheckBoxColumn.HeaderText = "שחקן א";
            this.stepPlayer1DataGridViewCheckBoxColumn.Name = "stepPlayer1DataGridViewCheckBoxColumn";
            // 
            // stepAfterSecondsDataGridViewTextBoxColumn
            // 
            this.stepAfterSecondsDataGridViewTextBoxColumn.DataPropertyName = "stepAfterSeconds";
            this.stepAfterSecondsDataGridViewTextBoxColumn.HeaderText = "כחלוף שניות";
            this.stepAfterSecondsDataGridViewTextBoxColumn.Name = "stepAfterSecondsDataGridViewTextBoxColumn";
            // 
            // stepRowDataGridViewTextBoxColumn
            // 
            this.stepRowDataGridViewTextBoxColumn.DataPropertyName = "stepRow";
            this.stepRowDataGridViewTextBoxColumn.HeaderText = "שורה";
            this.stepRowDataGridViewTextBoxColumn.Name = "stepRowDataGridViewTextBoxColumn";
            // 
            // stepColDataGridViewTextBoxColumn
            // 
            this.stepColDataGridViewTextBoxColumn.DataPropertyName = "stepCol";
            this.stepColDataGridViewTextBoxColumn.HeaderText = "עמודה";
            this.stepColDataGridViewTextBoxColumn.Name = "stepColDataGridViewTextBoxColumn";
            // 
            // tblGameStepsBindingSource
            // 
            this.tblGameStepsBindingSource.DataMember = "tblGameSteps";
            this.tblGameStepsBindingSource.DataSource = this.dataSetGameStepsBindingSource;
            // 
            // dataSetGameStepsBindingSource
            // 
            this.dataSetGameStepsBindingSource.DataSource = this.dataSetGameSteps;
            this.dataSetGameStepsBindingSource.Position = 0;
            // 
            // dataSetGameSteps
            // 
            this.dataSetGameSteps.DataSetName = "DataSetGameSteps";
            this.dataSetGameSteps.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGameStepsTableAdapter
            // 
            this.tblGameStepsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(476, 205);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 53;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(395, 205);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 54;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(244, 205);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 55;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(163, 205);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 56;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(13, 185);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 43);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // GameIdBox
            // 
            this.GameIdBox.Enabled = false;
            this.GameIdBox.Location = new System.Drawing.Point(420, 75);
            this.GameIdBox.Name = "GameIdBox";
            this.GameIdBox.Size = new System.Drawing.Size(61, 20);
            this.GameIdBox.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(498, 234);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "טבלת מהלכים";
            // 
            // FormUpdateGameStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GameIdBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stepNumber);
            this.Controls.Add(this.afterSeconds);
            this.Controls.Add(this.colBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormUpdateGameStep";
            this.Text = "FormUpdateGameStep";
            this.Load += new System.EventHandler(this.FormUpdateGameStep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox player1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stepNumber;
        private System.Windows.Forms.TextBox afterSeconds;
        private System.Windows.Forms.TextBox colBox;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetGameStepsBindingSource;
        private DataSetGameSteps dataSetGameSteps;
        private System.Windows.Forms.BindingSource tblGameStepsBindingSource;
        private DataSetGameStepsTableAdapters.tblGameStepsTableAdapter tblGameStepsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepGameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stepPlayer1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepAfterSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepColDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox GameIdBox;
        private System.Windows.Forms.Label label7;
    }
}