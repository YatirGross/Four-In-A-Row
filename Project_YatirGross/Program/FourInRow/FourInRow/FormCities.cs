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
    public partial class FormCities : Form
    {
        public FormCities(bool isManager)
        {
            InitializeComponent();
            if (!isManager)
                saveButton.Enabled = false;
        }

        private void FormCities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetCities changes = (DataSetCities)dataSetCities.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblCities.GetChanges();
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
                int numRows = tblCitiesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetCities.AcceptChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Errors: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetCities.RejectChanges();
            }
        }
    }
}
