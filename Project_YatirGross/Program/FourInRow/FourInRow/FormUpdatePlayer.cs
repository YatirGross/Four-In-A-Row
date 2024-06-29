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
    public partial class FormUpdatePlayer : Form
    {
       private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdatePlayer(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillCityCombo();
            RefreshDataGridView();
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


        private void FormUpdatePlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPlayers.tblPlayers' table. You can move, or remove it, as needed.
            this.tblPlayersTableAdapter.Fill(this.dataSetPlayers.tblPlayers);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblPlayers  \n" +
                                          "SET     playerFirstName    =  \"" + firstNameBox.Text        + "\" , \n" +
                                                  "playerLastName     =  \"" + lastNameBox.Text         + "\" , \n" +
                                                  "playerAddress      =  \"" + addressBox.Text          + "\" , \n" +
                                                  "playerCountry      =  \"" + countryBox.Text          + "\" , \n" +
                                                  "playerCity         =  \"" + cityBox.Text             + "\" , \n" +
                                                  "playerPassword     =  \"" + passwordBox.Text         + "\" , \n" +
                                                  "playerIsManager    =    " + managercheckBox.Checked  + "   , \n" + 
                                                  "playerPhone        =  \"" + phoneBox.Text            + "\" , \n" +
                                                  "playerMobile       =  \"" + mobileBox.Text           + "\" , \n" +
                                                  "playerMail         =  \"" + mailBox.Text             + "\" , \n" +
                                                  "playerPicture      =  \"" + picturelocation.Text     + "\"   \n" +
                                          "WHERE  playerID = " + idBox.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblPlayers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblPlayers failed \n" + err.Message, "Error",
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
                                     "FROM     tblPlayers " +
                                     "ORDER BY playerID";
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

        private void FillSelectedRow()
        {
            try
            {
                idBox.Text              = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firstNameBox.Text       = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastNameBox.Text        = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                addressBox.Text         = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                countryBox.Text         = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cityBox.Text            = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                passwordBox.Text        = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                managercheckBox.Checked = dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "True";
                phoneBox.Text           = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                mobileBox.Text          = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                mailBox.Text            = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                picturelocation.Text    = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                pictureBox1.ImageLocation = picturelocation.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            picturelocation.Text = pictureFileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }


    }
}
