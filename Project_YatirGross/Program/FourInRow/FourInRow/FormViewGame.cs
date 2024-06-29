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
    public partial class FormViewGame : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private Button[,] arrBtn;
        bool player1step;
        string saveColor1, saveColor2, maxSteps;
        int currentStepID;
        int waitTime;        
        string currentGameID;
        private int lastRow = 0;
        int viewSp;

         public FormViewGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            arrBtn = new Button[6, 7];                       
            FillArrBtn();
            RefreshDataGridView();                                  
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

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
            ShowButton.Enabled = true;
            if (WinnerBox.Text != "" )
            newGame();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
            ShowButton.Enabled = true;
            if (WinnerBox.Text != "")
            newGame();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
            ShowButton.Enabled = true;
            if (WinnerBox.Text != "")
            newGame();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
            ShowButton.Enabled = true;
            if (WinnerBox.Text != "")
            newGame();
        }

        private void FormViewGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);

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
                GameIDbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                currentGameID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                player1step = dataGridView1.SelectedRows[0].Cells[12].Value.ToString() == "True";
                maxSteps = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                saveColor1 = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                saveColor2 = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            viewSp = viewSpeed.Value;
            currentStepID = 1;
            for ( ; currentStepID <= int.Parse(maxSteps) ; currentStepID++)
            {
                GetWaitTime();
                ShowButton.Enabled = false;
                System.Threading.Thread.Sleep(waitTime/viewSp);
                int i = stepPlace()[0] - '0' ;
                int j = stepPlace()[1] - '0' ;
                if(player1step)
                    arrBtn[i, j].BackColor = Color.FromArgb(int.Parse(saveColor1));
                else
                    arrBtn[i, j].BackColor = Color.FromArgb(int.Parse(saveColor2));
                player1step = !player1step;
                this.Refresh();            
            }
            if (player1step)
            {
                WinnerBox.Visible = true;
                WinnerBox.Text = "כל הכבוד ! שחקן ב ניצח ";
                WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor2));
            }
            else
            {
                WinnerBox.Visible = true;
                WinnerBox.Text = "כל הכבוד ! שחקן א ניצח ";
                WinnerBox.ForeColor = Color.FromArgb(int.Parse(saveColor1));
            }
        
        }

        private string stepPlace()
        {
            string place = "";
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  stepRow , StepCol " +
                                            "FROM    tblGameSteps  " +
                                            "WHERE  stepGameID = " + currentGameID + "  AND  stepNum = " + currentStepID.ToString();
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    place = dataReader.GetInt32(0).ToString() + dataReader.GetInt32(1).ToString();                    
                }
                return place; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
            ShowButton.Enabled = true;
            if (WinnerBox.Text != "")
                newGame();
        }
        private void newGame()
        {           
            for (int i = 0; i < arrBtn.GetLength(0); i++)
                for (int j = 0; j < arrBtn.GetLength(1); j++)                
                    arrBtn[i, j].BackColor = SystemColors.Control;
            WinnerBox.Text = "";
            WinnerBox.ForeColor = SystemColors.Control;
            WinnerBox.Visible = false;
        }
        private void GetWaitTime()
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT  stepAfterSeconds " +
                                        "FROM    tblGameSteps  " +
                                        "WHERE  stepGameID = " + currentGameID + "  AND  stepNum = " + currentStepID.ToString();
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            if (dataReader.Read())
            {
                waitTime = dataReader.GetInt32(0);
            }
            dataReader.Close();
        }

        private void viewSpeed_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = viewSpeed.Value.ToString();
        }
    }
}
