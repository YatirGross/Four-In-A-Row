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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormMenu(OleDbConnection dataConnention, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnention;
            this.isManager = isManager;
            if (!isManager)
            {
                playersToolStripMenuItem.Enabled = false;
                playerToolStripMenuItem.Enabled = false;
                playerToolStripMenuItem1.Enabled = false;
            }
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            this.Hide();
            FormPlayers frPlayer = new FormPlayers(isManager);
            frPlayer.Show();
            frPlayer.Disposed += new EventHandler(Form_Disposed);
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void CitiesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormCities frCities = new FormCities(isManager);
            frCities.Show();
            frCities.Disposed += new EventHandler(Form_Disposed);
        }

        private void GamesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormGames frGames = new FormGames(isManager);
            frGames.Show();
            frGames.Disposed += new EventHandler(Form_Disposed);
        }

        private void GameStepsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormGameSteps frGameSteps = new FormGameSteps(isManager);
            frGameSteps.Show();
            frGameSteps.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddPlayerClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPlayer frAddPlayer = new FormAddPlayer(dataConnection, isManager);
            frAddPlayer.Show();
            frAddPlayer.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCity frAddCity = new FormAddCity(dataConnection, isManager);
            frAddCity.Show();
            frAddCity.Disposed += new EventHandler(Form_Disposed);
        }

        private void AddGameClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddGame frAddGame = new FormAddGame(dataConnection, isManager);
            frAddGame.Show();
            frAddGame.Disposed += new EventHandler(Form_Disposed);
        }

        private void gameStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddStep frAddStep = new FormAddStep(dataConnection, isManager);
            frAddStep.Show();
            frAddStep.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePlayerClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePlayer frUpdatePlayer = new FormUpdatePlayer(dataConnection, isManager);
            frUpdatePlayer.Show();
            frUpdatePlayer.Disposed += new EventHandler(Form_Disposed);
        }

        private void gameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateGame frUpdateGame = new FormUpdateGame(dataConnection, isManager);
            frUpdateGame.Show();
            frUpdateGame.Disposed += new EventHandler(Form_Disposed);
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateGameStep frUpdateGameStep = new FormUpdateGameStep(dataConnection, isManager);
            frUpdateGameStep.Show();
            frUpdateGameStep.Disposed += new EventHandler(Form_Disposed);
        }

        private void gamesOfPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptGamesOfPlayer frRptGamesOfPlayer = new FormRptGamesOfPlayer(dataConnection, isManager);
            frRptGamesOfPlayer.Show();
            frRptGamesOfPlayer.Disposed += new EventHandler(Form_Disposed);        
        }

        private void RptStepsInGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptStepsInGame frRptStepsInGame = new FormRptStepsInGame(dataConnection, isManager);
            frRptStepsInGame.Show();
            frRptStepsInGame.Disposed += new EventHandler(Form_Disposed);        
        }

        private void RPTGamesByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptGamesByDate frRptGamesByDate = new FormRptGamesByDate(dataConnection, isManager);
            frRptGamesByDate.Show();
            frRptGamesByDate.Disposed += new EventHandler(Form_Disposed);  
        }

        private void twoPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGameTwoPlayers frGameTwoPlayers = new FormGameTwoPlayers(dataConnection, isManager);
            frGameTwoPlayers.Show();
            frGameTwoPlayers.Disposed += new EventHandler(Form_Disposed);
        }

        private void viewGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewGame frViewGame = new FormViewGame(dataConnection, isManager);
            frViewGame.Show();
            frViewGame.Disposed += new EventHandler(Form_Disposed);
        }

        private void onePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGameOnePlayer frGameOnePlayer = new FormGameOnePlayer(dataConnection, isManager);
            frGameOnePlayer.Show();
            frGameOnePlayer.Disposed += new EventHandler(Form_Disposed);
        }

        private void gamesAndPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartGamesAndPlayers frChartGamesAndPlayers = new FormChartGamesAndPlayers(dataConnection);
            frChartGamesAndPlayers.Show();
            frChartGamesAndPlayers.Disposed += new EventHandler(Form_Disposed);
        }


      

       
        }
      
        }
    

