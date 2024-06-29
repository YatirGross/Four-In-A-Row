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
    public partial class FormRptGamesByDate : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int counter;
        private string saveColor = "";
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
        public FormRptGamesByDate(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
        }

        private void FormRptGamesByDate_Load(object sender, EventArgs e)
        {

        }

        private void ShowBotton_Click(object sender, EventArgs e)
        {
            counter = 0;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   GameID, gameDate, gameTime, gamePlayerCom, gameRows, gameCols, gamePlayerID1, gamePlayerColor1, " +
                                                    "gamePlayerID2, gamePlayerColor2, gameSeconds, gameSteps, gamePlayer1Start, Game1IsWinner " +
                                          "FROM     tblGames   " +
                                          "WHERE    gameDate BETWEEN #" + fromDate.Value.ToShortDateString() + "#  AND #" + toDate.Value.ToShortDateString() + "#  " +
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
                string[] arr = new string[16];
                if (counter == 1)
                {
                    arr[0] = fromDate.Value.ToString();
                    arr[1] = toDate.Value.ToString(); 
                }                   
                arr[2] = gameID;
                arr[3] = gameDate;
                arr[4] = gameTime;
                arr[5] = gamePlayerComp;
                arr[6] = gameRows;
                arr[7] = gameCols;
                arr[8] = gamePlayerID1;
                arr[9] = gameColor1;
                arr[10] = gamePlayerID2;
                arr[11] = gameColor2;
                arr[12] = gameSeconds;
                arr[13] = gameSteps;
                arr[14] = gamePlayer1Start;
                arr[15] = gamePlayer1Winner;
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
