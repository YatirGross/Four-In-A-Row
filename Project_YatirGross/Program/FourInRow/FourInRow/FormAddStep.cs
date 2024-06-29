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
    public partial class FormAddStep : Form
    {
        private OleDbConnection dataConnection;
        bool isManager;
        public FormAddStep(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                AddButton.Enabled = false;
            FillIDCombo();           
        }
        private void FillIDCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT GameID " +
                                          "FROM tblGames " +
                                          "ORDER BY GameID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    GameIdBox.Items.Add(dataReader.GetInt32(0));                   
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill GameID combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddStep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGameSteps.tblGameSteps' table. You can move, or remove it, as needed.
            this.tblGameStepsTableAdapter.Fill(this.dataSetGameSteps.tblGameSteps);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                       ("INSERT INTO tblGameSteps " + 
                       "(stepGameID, stepNum, stepPlayer1, stepAfterSeconds, stepRow, stepCol) " + 
                       " VALUES ( {0}, {1}, {2}, {3}, {4}, {5})",
                       GameIdBox.Text, stepNumber.Text, player1.Checked, afterSeconds.Text, rowBox.Text, colBox.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblGameSteps ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblGameSteps failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
