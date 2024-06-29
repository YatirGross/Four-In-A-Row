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
    public partial class FormAddPlayer : Form
    {
        private OleDbConnection dataConnection;
        bool isManager;
        public FormAddPlayer(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                addButton.Enabled = false;
            FillCityCombo();
        }

        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityBox.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPlayers.tblPlayers' table. You can move, or remove it, as needed.
            this.tblPlayersTableAdapter.Fill(this.dataSetPlayers.tblPlayers);

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            picturelocation.Text = pictureFileName;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblplayers " +
                                     "(playerId, playerFirstName, playerLastName, playerAddress, playerCity, playerCountry, playerPhone, playerMobile, playerPassword, playerIsManager,playerMail, playerPicture) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", {9} , \"{10}\", \"{11}\")",
                                       idBox.Text, firstNameBox.Text, lastNameBox.Text, addressBox.Text, cityBox.Text, countryBox.Text, phoneBox.Text, mobileBox.Text, passwordBox.Text, managercheckBox.Checked, mailBox.Text, picturelocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblplayers ended successfully");
                RefreshDataGridView();
            }

            catch (Exception err)
            {
                MessageBox.Show("Insert into tblplayers failed \n" + err.Message, "Error",
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
                                     "FROM     tblplayers " +
                                     "ORDER BY playerID";
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
