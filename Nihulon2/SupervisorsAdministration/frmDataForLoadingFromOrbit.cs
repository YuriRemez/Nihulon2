using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nihulon2.Model;
using Nihulon2.SupervisorsAdministration;
using static System.Windows.Forms.ComboBox;

namespace Nihulon2.SupervisorsAdministration
{
    /* The form takes the data about exams that
     * will be loaded from the Orbit excel
     * (Division, course, group) */
    public partial class frmDataForLoadingFromOrbit : Form
    {
        private SupervisorsAdministration_Controller _controller;

        public frmDataForLoadingFromOrbit(SupervisorsAdministration_Controller controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        // Fill the comboboxes with related items sent as parameters
        public void fillComboBoxes(ObjectCollection divisions, ObjectCollection courses)
        {
            for (int i = 0; i < divisions.Count; i++)
                cboDivisions.Items.Add(divisions[i]);
            for (int i = 0; i < courses.Count; i++)
                cboCourses.Items.Add(courses[i]);
        }

        // Close the form without loading new exams
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboDivisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCourses.SelectedIndex = -1;
            List<string> coursesNames = _controller.getCoursesByDivision(cboDivisions.Text);

            cboCourses.Items.Clear();

            foreach (string name in coursesNames)
                cboCourses.Items.Add(name);

            this.checkFormIfFilled();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Create a folder for Excel files if not exists
            string location = System.Windows.Forms.Application.StartupPath;
            location += @"\אקסל";

            // Open the file dialog from the folder with Excel files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = location;
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.CheckFileExists)
            {
                txtPath.Text = openFileDialog.FileName;
                this.checkFormIfFilled(); // Enable the submit button if all fields ate filled               
            }
        }

        // Enable the submit button if all the fields are set 
        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkFormIfFilled();
        }
        private void txtGroup_TextChanged(object sender, EventArgs e)
        {
            this.checkFormIfFilled();
        }

        private void checkFormIfFilled()
        {
            if(!string.IsNullOrEmpty(txtPath.Text) && cboDivisions.SelectedIndex != -1 && 
                cboCourses.SelectedIndex != -1 && !string.IsNullOrEmpty(txtGroup.Text))
            {
                btnSubmit.Enabled = true;
            }
            else
                btnSubmit.Enabled = false;
        }

        // Sent all the data to the controller 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            _controller.loadFromExcelOfOrbit(txtPath.Text, cboDivisions.SelectedItem.ToString(),
                cboCourses.SelectedItem.ToString(), txtGroup.Text);

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;

            this.Dispose();
        }
    }
}
