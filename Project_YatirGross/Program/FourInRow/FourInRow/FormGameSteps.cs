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
    public partial class FormGameSteps : Form
    {
        public FormGameSteps(bool isManager)
        {
            InitializeComponent();
            if (!isManager)
                saveButton.Enabled = false;
        }

        private void FormGameSteps_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGameSteps.tblGameSteps' table. You can move, or remove it, as needed.
            this.tblGameStepsTableAdapter.Fill(this.dataSetGameSteps.tblGameSteps);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetGameSteps changes = (DataSetGameSteps)dataSetGameSteps.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblGameSteps.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                // find the errors and tell the user
                if(badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach(DataRow row in badRows)
                    {
                        foreach(DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // no errors found, update the database
                int numRows = tblGameStepsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetGameSteps.AcceptChanges();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Errors: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetGameSteps.RejectChanges();
            }
        }
    }
}
