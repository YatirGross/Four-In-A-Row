using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourInRow
{
    public partial class FormPlayers : Form
    {
        public FormPlayers(bool isManager)
        {
            InitializeComponent();
            if (!isManager)
                saveButton.Enabled = false;
        }

        private void FormPlayers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPlayers.tblPlayers' table. You can move, or remove it, as needed.
            this.tblPlayersTableAdapter.Fill(this.dataSetPlayers.tblPlayers);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetPlayers changes = (DataSetPlayers)dataSetPlayers.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblPlayers.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                // find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg, "please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //no error found, update the database
                int numRows = tblPlayersTableAdapter.Update(changes);
                MessageBox.Show("Update " + numRows + " rows", "Success");
                dataSetPlayers.AcceptChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetPlayers.RejectChanges();
            }
        }
    }
}
