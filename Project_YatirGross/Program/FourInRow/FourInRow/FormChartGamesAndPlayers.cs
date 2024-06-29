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
    public partial class FormChartGamesAndPlayers : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrPlayers;
        private int[] arrGamesWin;
        private int[] arrGamesLose;
        public FormChartGamesAndPlayers(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountPlayers();
            arrPlayers = new string[counter];
            arrGamesWin = new int[counter];
            arrGamesLose = new int[counter];
            FillArrPlayers();
            FillArrGames();
            ShowChart();
            EditDataGridView();
        }

        private void CountPlayers()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblPlayers  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblPlayers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FillArrPlayers()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   playerID " +
                                          "FROM     tblPlayers  " +
                                          "ORDER BY playerID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrPlayers[k] = dataReader.GetInt32(0).ToString();
                    k++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPlayers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrGames()
        {
            for (int idx = 0; idx < arrPlayers.Length; idx++)
                CountGames(idx);
        }

        private void CountGames(int idx)
        {
            try
            {
                OleDbCommand datacommand1 = new OleDbCommand();
                datacommand1.Connection = dataConnection;
                datacommand1.CommandText = "SELECT  game1IsWinner " +
                                          "FROM    tblGames  " +
                                          "WHERE    gamePlayerID1 = " + arrPlayers[idx] + "  ";
                OleDbDataReader dataReader1 = datacommand1.ExecuteReader();
                while (dataReader1.Read())
                {
                    if (dataReader1.GetBoolean(0))
                        arrGamesWin[idx]++;
                    else
                        arrGamesLose[idx]++;
                }
                dataReader1.Close();
                OleDbCommand datacommand2 = new OleDbCommand();
                datacommand2.Connection = dataConnection;
                datacommand2.CommandText = "SELECT  gamePlayerCom ,game1IsWinner " +
                                          "FROM    tblGames  " +
                                          "WHERE   gamePlayerID2 = " + arrPlayers[idx] + "  ";
                OleDbDataReader dataReader2 = datacommand2.ExecuteReader();
                while (dataReader2.Read())
                {
                    if (dataReader2.GetBoolean(0))
                        arrGamesLose[idx]++;
                    else
                        arrGamesWin[idx]++;
                }
                dataReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPlayers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                for (int i = 0; i < arrPlayers.Length; i++)
                {
                    chart1.Series["הפסדים"].Points.AddXY(arrPlayers[i], arrGamesLose[i]);
                    chart1.Series["נצחונות"].Points.AddXY(arrPlayers[i], arrGamesWin[i]);     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDataGridView()
        {
            try
            {
                for (int i = 0; i < arrPlayers.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = arrPlayers[i];
                    row.Cells[1].Value = arrGamesWin[i].ToString();
                    row.Cells[2].Value = arrGamesLose[i].ToString();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
