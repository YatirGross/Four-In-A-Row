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
    public partial class FormGameOnePlayer : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private Button[,] arrBtn;
        private int[,] arr;
        private string saveColor1 = "";
        private string saveColor2 = "";
        private int currentPlayer;
        private string currentGameID;
        private int currentStepID;
        bool player1step;
        DateTime endTime, startTime, startStep, endStep;

        public FormGameOnePlayer(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            arrBtn = new Button[6, 7];
            arr = new int[6, 7];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = 0;
            FillArrBtn();
            FillIDCombo();
        }

        private void FillArrBtn()
        {
            arrBtn[0, 0] = b00;
            arrBtn[0, 1] = b01;
            arrBtn[0, 2] = b02;
            arrBtn[0, 3] = b03;
            arrBtn[0, 4] = b04;
            arrBtn[0, 5] = b05;
            arrBtn[0, 6] = b06;
            arrBtn[1, 0] = b10;
            arrBtn[1, 1] = b11;
            arrBtn[1, 2] = b12;
            arrBtn[1, 3] = b13;
            arrBtn[1, 4] = b14;
            arrBtn[1, 5] = b15;
            arrBtn[1, 6] = b16;
            arrBtn[2, 0] = b20;
            arrBtn[2, 1] = b21;
            arrBtn[2, 2] = b22;
            arrBtn[2, 3] = b23;
            arrBtn[2, 4] = b24;
            arrBtn[2, 5] = b25;
            arrBtn[2, 6] = b26;
            arrBtn[3, 0] = b30;
            arrBtn[3, 1] = b31;
            arrBtn[3, 2] = b32;
            arrBtn[3, 3] = b33;
            arrBtn[3, 4] = b34;
            arrBtn[3, 5] = b35;
            arrBtn[3, 6] = b36;
            arrBtn[4, 0] = b40;
            arrBtn[4, 1] = b41;
            arrBtn[4, 2] = b42;
            arrBtn[4, 3] = b43;
            arrBtn[4, 4] = b44;
            arrBtn[4, 5] = b45;
            arrBtn[4, 6] = b46;
            arrBtn[5, 0] = b50;
            arrBtn[5, 1] = b51;
            arrBtn[5, 2] = b52;
            arrBtn[5, 3] = b53;
            arrBtn[5, 4] = b54;
            arrBtn[5, 5] = b55;
            arrBtn[5, 6] = b56;
            for (int i = 0; i < arrBtn.GetLength(0); i++)
                for (int j = 0; j < arrBtn.GetLength(1); j++)
                    arrBtn[i, j].Enabled = false;

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
                    combo1.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill ID comboboxs failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i = btn.Name[1] - '0';
            int j = btn.Name[2] - '0';
            int k;
            for (k = 0; k < arr.GetLength(0) && arr[k, j] != 0; k++) ;
            if (currentPlayer == 1)
            {
                arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor1));
                arr[k, j] = 1;
                currentPlayer = 2;
            }
            else
            {
                arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                arr[k, j] = 2;
                currentPlayer = 1;
            }
            saveNewStep(k, j);
            arrBtn[k, j].Enabled = false;
            if(CheckWin())
            {
                CheckWinner();
            }  
            else
            {
                currentStepID++;
                MakeComputerStep();
            }      
        }

        private void CheckWinner()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (CheckRow(i) || CheckUpSlant(i, 0) || CheckDownSlant(i, 0))
                {
                    WinnerBox.Visible = true;
                    if (currentPlayer == 1)
                    {
                        WinnerBox.Text = "הפסד ! מחשב ניצח ";
                        WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor2));
                    }
                    else
                    {
                        WinnerBox.Text = "כל הכבוד !  " + firstName1.Text + " ניצח ";
                        WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor1));
                    }
                    for (int a = 0; a < arrBtn.GetLength(0); a++)
                        for (int b = 0; b < arrBtn.GetLength(1); b++)
                            arrBtn[a, b].Enabled = false;
                    newGame.Enabled = true;
                    newGame.Visible = true;
                    endTime = DateTime.Now;
                    startButton.Enabled = false;
                    saveGameResults();
                    return;
                }
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (CheckCol(i) || CheckUpSlant(0, i) || CheckDownSlant(5, i))
                {
                    WinnerBox.Visible = true;
                    if (currentPlayer == 1)
                    {
                        WinnerBox.Text = "הפסד ! מחשב ניצח ";
                        WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor2));
                    }
                    else
                    {
                        WinnerBox.Text = "כל הכבוד !  " + firstName1.Text + " ניצח ";
                        WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor1));
                    }
                    for (int a = 0; a < arrBtn.GetLength(0); a++)
                        for (int b = 0; b < arrBtn.GetLength(1); b++)
                            arrBtn[a, b].Enabled = false;
                    newGame.Enabled = true;
                    newGame.Visible = true;
                    startButton.Enabled = false;                   
                    saveGameResults();
                    return;
                }
            }
        }
        private bool CheckWin()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (CheckRow(i) || CheckUpSlant(i, 0) || CheckDownSlant(i, 0))
                {                                     
                    return true;
                }
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (CheckCol(i) || CheckUpSlant(0, i) || CheckDownSlant(5, i))
                {                  
                    return true;
                }
            }
            return false;
        }

        private bool CheckRow(int i)
        {
            int count1 = 0, count2 = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == 0)
                {
                    count1 = 0;
                    count2 = 0;
                }
                else
                    if (arr[i, j] == 1)
                    {
                        count1++;
                        count2 = 0;
                    }
                    else
                        if (arr[i, j] == 2)
                        {
                            count2++;
                            count1 = 0;
                        }
                if (count1 == 4 || count2 == 4)
                    return true;
            }
            return false;
        }

        private bool CheckCol(int j)
        {
            int count1 = 0, count2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, j] == 0)
                {
                    count1 = 0;
                    count2 = 0;
                }
                else
                    if (arr[i, j] == 1)
                    {
                        count1++;
                        count2 = 0;
                    }
                    else
                        if (arr[i, j] == 2)
                        {
                            count2++;
                            count1 = 0;
                        }
                if (count1 == 4 || count2 == 4)
                    return true;
            }
            return false;
        }
        private bool CheckUpSlant(int i, int j)
        {
            int count1 = 0, count2 = 0;
            for (; i < arr.GetLength(0) && j < arr.GetLength(1); i++, j++)
            {
                if (arr[i, j] == 0)
                {
                    count1 = 0;
                    count2 = 0;
                }
                else
                    if (arr[i, j] == 1)
                    {
                        count1++;
                        count2 = 0;
                    }
                    else
                        if (arr[i, j] == 2)
                        {
                            count2++;
                            count1 = 0;
                        }
                if (count1 == 4 || count2 == 4)
                    return true;
            }
            return false;
        }
        private bool CheckDownSlant(int i, int j)
        {
            int count1 = 0, count2 = 0;
            for (; i >= 0 && j < arr.GetLength(1); i--, j++)
            {
                if (arr[i, j] == 0)
                {
                    count1 = 0;
                    count2 = 0;
                }
                else
                    if (arr[i, j] == 1)
                    {
                        count1++;
                        count2 = 0;
                    }
                    else
                        if (arr[i, j] == 2)
                        {
                            count2++;
                            count1 = 0;
                        }
                if (count1 == 4 || count2 == 4)
                    return true;
            }
            return false;
        }
        private void player1IDbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  playerFirstName, playerLastName " +
                                          "FROM    tblPlayers  " +
                                          "WHERE   playerID = " + combo1.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    firstName1.Text = dataReader.GetString(0);
                    lastName1.Text = dataReader.GetString(1);
                }
                buttonColor1.Enabled = true;
                buttonColor2.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Select1 tblPlayers failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            saveNewGame();
            startTime = DateTime.Now;
            startStep = DateTime.Now;
            for (int i = 0; i < arrBtn.GetLength(0); i++)
                for (int j = 0; j < arrBtn.GetLength(1); j++)
                    arrBtn[i, j].Enabled = true;
            combo1.Enabled = false;
            buttonColor1.Enabled = false;
            buttonColor2.Enabled = false;
            if (start1.Checked)
                currentPlayer = 1;
            else
            {
                currentPlayer = 2;
                MakeComputerStep();
            }


        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor1A.BackColor = cd.Color;
            saveColor1 = buttonColor1A.BackColor.ToArgb().ToString();

        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor2A.BackColor = cd.Color;
            saveColor2 = buttonColor2A.BackColor.ToArgb().ToString();
            if (saveColor1 == saveColor2)
            {
                MessageBox.Show("Both players have Same color");
                saveColor2 = "";
            }
            else
            {
                buttonColor2A.BackColor = cd.Color;
                start1.Enabled = true;
                startComputer.Enabled = true;
            }
        }      

        private void start_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrBtn.GetLength(0); i++)
                for (int j = 0; j < arrBtn.GetLength(1); j++)
                {
                    arrBtn[i, j].Enabled = false;
                    arrBtn[i, j].BackColor = SystemColors.Control;
                    arr[i, j] = 0;
                }
            combo1.Enabled = true;
            buttonColor1.Enabled = false;
            buttonColor2.Enabled = false;
            start1.Enabled = false;
            startComputer.Enabled = false;
            newGame.Enabled = false;
            WinnerBox.Text = "";
            WinnerBox.ForeColor = SystemColors.Control;
            WinnerBox.Visible = false;

        }
        private void saveNewGame()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblGames " +
                                     "(gameDate, gameTime, gamePlayerCom, gameRows, gameCols, gamePlayerID1, gamePlayerColor1," +
                                     "gamePlayerColor2, gamePlayer1Start) " +
                                     " VALUES ( \"{0}\", \"{1}\", {2}, {3}, {4}, \"{5}\",\"{6}\", \"{7}\", {8})",
                                       DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString(), true, 7, 6, combo1.Text, saveColor1, saveColor2, start1.Checked);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                currentStepID = 1;
                GetCurrentGameID();
            }

            catch (Exception err)
            {
                MessageBox.Show("failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetCurrentGameID()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  MAX(gameID) " +
                                          "FROM    tblGames  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                currentGameID = dataReader.GetInt32(0).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(" failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void saveNewStep(int row, int col)
        {
            try
            {
                switch (currentPlayer)
                {
                    case 1: player1step = false; break;

                    case 2: player1step = true; break;
                }
                endStep = DateTime.Now;
                TimeSpan s = endStep - startStep;
                int time;
                if (player1step)
                    time = s.Seconds * 1000 + s.Milliseconds;
                else
                    time = 100;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                      ("INSERT INTO tblGameSteps " +
                      "(stepGameID, stepNum, stepPlayer1, stepAfterSeconds , stepRow, stepCol) " +
                      " VALUES ( {0}, {1}, {2}, {3}, {4}, {5})",
                      currentGameID, currentStepID, player1step, time ,row, col);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                startStep = DateTime.Now;
            }
            catch (Exception err)
            {
                MessageBox.Show("the step failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveGameResults()
        {
            try
            {
                endTime = DateTime.Now;
                TimeSpan st = endTime - startTime;
                int gameSeconds = st.Hours * 3600 + st.Minutes * 60 + st.Seconds;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblGames  \n" +
                                          "SET     gameSeconds      =    " + gameSeconds + "   , \n" +
                                                  "gameSteps        =    " + currentStepID + "   , \n" +
                                                  "Game1IsWinner    =    " + player1step + "     \n" +
                                          "WHERE  GameID = " + currentGameID;
                datacommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(" failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MakeComputerStep()
        {
            if (offensiveMove())
            {
                currentPlayer = 1;
                return;
            }
            if (defensiveMove())
            {
                currentPlayer = 1;
                return;
            }
            if (goodMove())
            {
                currentPlayer = 1;
                return;
            }
            randomMove();                                
        }
        public bool offensiveMove()
        {
            int j, k;
            for (j = 0; j < arr.GetLength(1); j++)
            {
                for (k = 0; k < arr.GetLength(0) && arr[k, j] != 0; k++) ;
                if (k < arr.GetLength(0))
                {
                    arr[k, j] = 2;
                    if (CheckWin())
                    {
                        arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                        currentPlayer = 1;
                        saveNewStep(k, j);
                        arrBtn[k, j].Enabled = false;
                        CheckWinner();
                        currentStepID++;
                        return true;
                    }
                    else
                        arr[k, j] = 0;
                }
           }
            return false;
        }
        public bool defensiveMove()
        {           
            int j, k;
            for (j = 0; j < arr.GetLength(1); j++)
            {
                for (k = 0; k < arr.GetLength(0) && arr[k, j] != 0; k++) ;
                if (k < arr.GetLength(0))
                {
                    arr[k, j] = 1;
                    if (CheckWin())
                    {
                        arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                        arr[k, j] = 2;
                        currentPlayer = 1;
                        saveNewStep(k, j);
                        arrBtn[k, j].Enabled = false;
                        CheckWinner();
                        currentStepID++;
                        return true;
                    }
                    else
                        arr[k, j] = 0;
                }

            }
            return false;
        }
        public bool goodMove()
        {          
            int j, k;
            for (j = 0; j < arr.GetLength(1); j++)
            {
                for (k = 0; k < arr.GetLength(0) && arr[k, j] != 0; k++) ;
                if (k < arr.GetLength(0))
                {                  
                    if (completeToThree(k,j))
                    {
                        arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                        arr[k, j] = 2;
                        currentPlayer = 1;
                        saveNewStep(k, j);
                        arrBtn[k, j].Enabled = false;
                        CheckWinner();
                        currentStepID++;
                        return true;
                    }
                }

            }
            return false;
        }
        public void randomMove()
        {
            Random rnd = new Random();
            int j = rnd.Next(0, 7), k;
            for (k = 0; k < arr.GetLength(0) && arr[k, j] != 0; k++) ;
            if (k < arr.GetLength(0))
            {
                arrBtn[k, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                arr[k, j] = 2;
                currentPlayer = 1;
                saveNewStep(k, j);
                arrBtn[k, j].Enabled = false;
                CheckWinner();
                currentStepID++;
            }
            else
                randomMove();
        }
        public bool completeToThree(int k,int j)
        {      
            if(j > 1)                  
                if (arr[k, j - 1] == 2 && arr[k, j - 2] == 2)
                    return true;
            if(j > 1 && k > 1)
                if (arr[k - 1, j - 1] == 2 && arr[k - 2, j - 2] == 2)
                    return true;
            if(k > 1)
                if (arr[k - 1, j] == 2 && arr[k - 2, j] == 2)
                    return true;
            if(j < 5 && k > 1)
                if (arr[k - 1, j + 1] == 2 && arr[k - 2, j + 2] == 2)
                    return true;
            if (j < 5)
                if (arr[k, j + 1] == 2 && arr[k, j + 2] == 2)
                     return true;
            return false;
        }          
    }
}
