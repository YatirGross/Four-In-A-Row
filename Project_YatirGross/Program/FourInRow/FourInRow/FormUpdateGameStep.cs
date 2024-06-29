using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FourInRow
{
    public partial class FormUpdateGameStep : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateGameStep(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;           
            RefreshDataGridView();
        }
       
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblGameSteps " +
                                     "ORDER BY stepGameID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FormUpdateGameStep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGameSteps.tblGameSteps' table. You can move, or remove it, as needed.
            this.tblGameStepsTableAdapter.Fill(this.dataSetGameSteps.tblGameSteps);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblGameSteps  \n" +
                                          "SET     stepPlayer1      =    " + player1.Checked   + " , \n" +
                                                  "stepAfterSeconds =    " + afterSeconds.Text + " , \n" +
                                                  "stepRow          =    " + rowBox.Text       + " , \n" +
                                                  "stepCol          =    " + colBox.Text       + "   \n" +
                                          "WHERE  stepGameID = " + GameIdBox.Text + "  AND  stepNum = " + stepNumber.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblGameSteps ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblGameSteps failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }
        private void FillSelectedRow()
        {
            try
            {
                GameIdBox.Text    = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                stepNumber.Text   = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();                
                player1.Checked   = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "True";
                afterSeconds.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                rowBox.Text       = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                colBox.Text       = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();               
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

    }
}
