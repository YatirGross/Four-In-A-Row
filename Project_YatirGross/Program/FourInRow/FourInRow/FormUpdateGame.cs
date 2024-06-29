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
    public partial class FormUpdateGame : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillIDCombo();
            RefreshDataGridView();
        }


        private void FormUpdateGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);

        }
        private void FillIDCombo()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT playerID " +
                                          "FROM tblPlayers " +
                                          "ORDER BY playerID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    player1ID.Items.Add(dataReader.GetInt32(0));
                    player2ID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill ID comboboxs failed \n" + err.Message, "Error",
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonPlayer1.BackColor = cd.Color;
            colorPlayer1.Text = buttonPlayer1.BackColor.ToArgb().ToString();
                 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonPlayer2.BackColor = cd.Color;
            colorPlayer2.Text = buttonPlayer2.BackColor.ToArgb().ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblGames  \n" +
                                          "SET     gameDate         =  \"" + GameDate.Text          + "\" , \n" +
                                                  "gameTime         =  \"" + GameTime.Text          + "\" , \n" +
                                                  "gamePlayerCom    =    " + computerPlayer.Checked + "   , \n" +
                                                  "gameRows         =    " + rowsBox.Text           + "   , \n" +
                                                  "gameCols         =    " + colsBox.Text           + "   , \n" +
                                                  "gamePlayerID1    =    " + player1ID.Text         + "   , \n" +
                                                  "gamePlayerColor1 =  \"" + colorPlayer1.Text      + "\" , \n" +
                                                  "gamePlayerID2    =    " + player2ID.Text         + "   , \n" +
                                                  "gamePlayerColor2 =  \"" + colorPlayer2.Text      + "\" , \n" +
                                                  "gameSeconds      =    " + gameSecondBox.Text     + "   , \n" +
                                                  "gameSteps        =    " + gameStepsBox2.Text     + "   , \n" +
                                                  "gamePlayer1Start =    " + player1Start.Checked   + "   , \n" +
                                                  "Game1IsWinner    =    " + player1Win.Checked     + "     \n" +
                                          "WHERE  GameID = " + GameIDBox.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblGames ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblGames failed \n" + err.Message, "Error",
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
                GameIDBox.Text         = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                GameDate.Text          = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                GameTime.Text          = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                computerPlayer.Checked = dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "True";
                rowsBox.Text           = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                colsBox.Text           = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                player1ID.Text         = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                colorPlayer1.Text      = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                player2ID.Text         = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                colorPlayer2.Text      = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                gameSecondBox.Text     = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                gameStepsBox2.Text     = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                player1Start.Checked   = dataGridView1.SelectedRows[0].Cells[12].Value.ToString() == "True";
                player1Win.Checked     = dataGridView1.SelectedRows[0].Cells[13].Value.ToString() == "True" ;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
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
        
    }
}
