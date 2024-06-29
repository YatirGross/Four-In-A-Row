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
    public partial class FormRptGamesOfPlayer : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int counter;
        private string saveColor = "";
        private int lastRow = 0;
        private string gameID;
        private string gameDate;
        private string gameTime;
        private string gamePlayerComp;
        private string gameRows;
        private string gameCols;
        private string gamePlayerID1;
        private string gameColor1;
        private string gamePlayerID2;
        private string gameColor2;
        private string gameSeconds;
        private string gameSteps;
        private string gamePlayer1Start;
        private string gamePlayer1Winner;
       
        public FormRptGamesOfPlayer(OleDbConnection dataConnection, bool isManager)
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
                                     "FROM     tblPlayers " +
                                     "ORDER BY PlayerID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblPlayers table failed \n" + err.Message, "Error",
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


        private void FormRptGamesOfPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPlayers.tblPlayers' table. You can move, or remove it, as needed.
            this.tblPlayersTableAdapter.Fill(this.dataSetPlayers.tblPlayers);

        }  
        
        private void FillSelectedRow()
        {
            textboxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            EnableButtons();
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
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

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }


        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            counter = 0;
            try
            {                
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   GameID, gameDate, gameTime, gamePlayerCom, gameRows, gameCols, gamePlayerID1, gamePlayerColor1, " + 
                                                    "gamePlayerID2, gamePlayerColor2, gameSeconds, gameSteps, gamePlayer1Start, Game1IsWinner " +
                                          "FROM     tblGames   " +
                                          "WHERE    gamePlayerID1 = " + textboxID.Text + " OR gamePlayerID2 = " + textboxID.Text + "  " +
                                          "ORDER BY GameID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    gameID = dataReader.GetInt32(0).ToString();
                    gameDate = dataReader.GetDateTime(1).ToShortDateString();
                    gameTime = dataReader.GetDateTime(2).ToShortTimeString();
                    gamePlayerComp = dataReader.GetBoolean(3).ToString();
                    gameRows = dataReader.GetInt32(4).ToString();
                    gameCols = dataReader.GetInt32(5).ToString();
                    gamePlayerID1 = dataReader.GetInt32(6).ToString();
                    gameColor1 = dataReader.GetString(7);
                    if (gamePlayerComp == "False")
                        gamePlayerID2 = dataReader.GetInt32(8).ToString();
                    else
                        gamePlayerID2 = "";
                    gameColor2 = dataReader.GetString(9);
                    gameSeconds = dataReader.GetInt32(10).ToString();
                    gameSteps = dataReader.GetInt32(11).ToString();
                    gamePlayer1Start = dataReader.GetBoolean(12).ToString();
                    gamePlayer1Winner = dataReader.GetBoolean(13).ToString();
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
                string[] arr = new string[15]; 
                if (counter == 1)                             
                    arr[0] = textboxID.Text;
                arr[1] = gameID;
                arr[2] = gameDate;        
                arr[3] = gameTime;
                arr[4] = gamePlayerComp;
                arr[5] = gameRows;
                arr[6] = gameCols;
                arr[7] = gamePlayerID1;
                arr[8] = gameColor1;
                arr[9] = gamePlayerID2;
                arr[10] = gameColor2;
                arr[11] = gameSeconds;
                arr[12] = gameSteps;
                arr[13] = gamePlayer1Start;
                arr[14] = gamePlayer1Winner;
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog Cd = new ColorDialog();
            Cd.ShowDialog();
            ColorButton.BackColor = Cd.Color;
            saveColor = ColorButton.BackColor.ToArgb().ToString();
        } 
    }
}
