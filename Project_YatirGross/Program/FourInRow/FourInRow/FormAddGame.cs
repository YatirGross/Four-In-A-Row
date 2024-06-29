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
    public partial class FormAddGame : Form
    {
        private OleDbConnection dataConnection;
        bool isManager;
        public FormAddGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                addButton.Enabled = false;
            FillIDCombo();           
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
        private void FormAddGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAddGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblGames " +
                                     "(gameDate, gameTime, gamePlayerCom, gameRows, gameCols, gamePlayerID1, gamePlayerColor1, gamePlayerID2, " + 
                                     "gamePlayerColor2, gameSeconds, gameSteps, gamePlayer1Start, game1IsWinner) " +
                                     " VALUES ( \"{0}\", \"{1}\", {2}, {3}, {4}, {5}, \"{6}\", {7}, \"{8}\", {9} , {10}, {11} ,{12})",
                                       GameDate.Value.ToShortDateString(), GameTime.Value.ToShortTimeString(), computerPlayer.Checked , rowsBox.Text, colsBox.Text, player1ID.Text, button1.BackColor.ToArgb().ToString(),
                                       player2ID.Text, button2.BackColor.ToArgb().ToString(), gameSecondBox.Text, gameStepsBox2.Text, player1Start.Checked, Player1Win.Checked);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblGames ended successfully");
                RefreshDataGridView();
            }

            catch (Exception err)
            {
                MessageBox.Show("Insert into tblGames failed \n" + err.Message, "Error",
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
                GamedataGrid.DataSource = tbl;
                GamedataGrid.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            button1.BackColor = cd.Color;           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            button2.BackColor = cd.Color;
        }

    }
}
