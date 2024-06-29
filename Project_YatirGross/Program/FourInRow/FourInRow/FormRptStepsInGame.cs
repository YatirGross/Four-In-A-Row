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
    public partial class FormRptStepsInGame : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int counter;
        private int lastRow = 0;
        private string stepNum;
        private string stepPlayer1;
        private string stepAfterSeconds;
        private string stepRow;
        private string stepCol;
        private string saveColor = "";
       
        public FormRptStepsInGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblGames " +
                                     "ORDER BY GameID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblGames table failed \n" + err.Message, "Error",
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

        private void FormRptStepsInGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);

        }

        private void FillSelectedRow()
        {
            gameIDBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();            
            EnableButtons();
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

        private void gameIDBox_TextChanged(object sender, EventArgs e)
        {

            counter = 0;
            try
            {                
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stepNum, stepPlayer1, stepAfterSeconds, stepRow, stepCol " + 
                                          "FROM     tblGameSteps   " +
                                          "WHERE    stepGameID = " + gameIDBox.Text + " " +
                                          "ORDER BY stepGameID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    stepNum = dataReader.GetInt32(0).ToString();                    
                    stepPlayer1 = dataReader.GetBoolean(1).ToString();
                    stepAfterSeconds = dataReader.GetInt32(2).ToString();
                    stepRow = dataReader.GetInt32(3).ToString();
                    stepCol = dataReader.GetInt32(4).ToString();                  
                    counter++;
                   EditListView();                  
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblGames failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditListView()
        {            
            try
            {
                string[] arr = new string[6]; 
                if (counter == 1)                             
                    arr[0] = gameIDBox.Text;
                arr[1] = stepNum;
                arr[2] = stepPlayer1;        
                arr[3] = stepAfterSeconds;
                arr[4] = stepRow;
                arr[5] = stepCol;              
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog Cd = new ColorDialog();
            Cd.ShowDialog();
            ColorButton.BackColor = Cd.Color;
            saveColor = ColorButton.BackColor.ToArgb().ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        

    }
}
