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
    public partial class FormGames : Form
    {
        public FormGames(bool isManager)
        {
            InitializeComponent();
            if (!isManager)
                saveButton.Enabled = false;
        }

        private void FormGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetGames changes = (DataSetGames)dataSetGames.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblGames.GetChanges();
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
                    MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // no errors found, update the database
                int numRows = tblGamesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetGames.AcceptChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Errors: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetGames.RejectChanges();
            }
        }
    }
}
