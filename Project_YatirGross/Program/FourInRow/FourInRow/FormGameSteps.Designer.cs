namespace FourInRow
{
    partial class FormGameSteps
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
            this.tblGameStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGameSteps = new FourInRow.DataSetGameSteps();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGameStepsTableAdapter = new FourInRow.DataSetGameStepsTableAdapters.tblGameStepsTableAdapter();
            this.stepGameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepPlayer1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stepAfterSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameSteps)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblGameStepsBindingSource
            // 
            this.tblGameStepsBindingSource.DataMember = "tblGameSteps";
            this.tblGameStepsBindingSource.DataSource = this.dataSetGameSteps;
            // 
            // dataSetGameSteps
            // 
            this.dataSetGameSteps.DataSetName = "DataSetGameSteps";
            this.dataSetGameSteps.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת מהלכי משחק";
            // 
            // tblGameStepsTableAdapter
            // 
            this.tblGameStepsTableAdapter.ClearBeforeFill = true;
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
            this.stepRowDataGridViewTextBoxColumn.HeaderText = "מספר שורה";
            this.stepRowDataGridViewTextBoxColumn.Name = "stepRowDataGridViewTextBoxColumn";
            // 
            // stepColDataGridViewTextBoxColumn
            // 
            this.stepColDataGridViewTextBoxColumn.DataPropertyName = "stepCol";
            this.stepColDataGridViewTextBoxColumn.HeaderText = "מספר עמודה";
            this.stepColDataGridViewTextBoxColumn.Name = "stepColDataGridViewTextBoxColumn";
            // 
            // FormGameSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGameSteps";
            this.Text = "FormGameSteps";
            this.Load += new System.EventHandler(this.FormGameSteps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGameSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private DataSetGameSteps dataSetGameSteps;
        private System.Windows.Forms.BindingSource tblGameStepsBindingSource;
        private DataSetGameStepsTableAdapters.tblGameStepsTableAdapter tblGameStepsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepGameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stepPlayer1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepAfterSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepColDataGridViewTextBoxColumn;
    }
}