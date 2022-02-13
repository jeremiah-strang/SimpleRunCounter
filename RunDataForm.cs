using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRunCounter
{
    public partial class RunDataForm : Form
    {
        BindingSource runDataSource;

        public RunDataForm(BindingSource source)
        {
            InitializeComponent();
            runDataSource = source;
            runDataGrid.DataSource = source;
            runDataGrid.Columns["RunNumber"].DisplayIndex = 0;
            runDataGrid.Columns["SessionRunNumber"].DisplayIndex = 1;
            runDataGrid.Columns["DurationRounded"].DisplayIndex = 2;
            runDataGrid.Columns["Description"].DisplayIndex = 3;
            runDataGrid.Columns["Notes"].DisplayIndex = 4;
            runDataGrid.Columns["Started"].DisplayIndex = 5;
            runDataGrid.Columns["Ended"].DisplayIndex = 6;
            runDataGrid.Columns["Duration"].Visible = false;
            runDataGrid.Columns["DurationStr"].Visible = false;

            runDataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            runDataGrid.Columns["RunNumber"].ReadOnly = true;
            runDataGrid.Columns["DurationRounded"].Name = "Duration";
            runDataGrid.Columns["RunNumber"].Name = "Run";
            runDataGrid.Columns["SessionRunNumber"].Name = "Session";

            runDataGrid.AllowUserToAddRows = false;
            runDataGrid.AllowUserToDeleteRows = true;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            runDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            runDataGrid.SelectAll();
            DataObject dataObj = runDataGrid.GetClipboardContent();
            Clipboard.SetDataObject(dataObj, true);
        }
    }
}
