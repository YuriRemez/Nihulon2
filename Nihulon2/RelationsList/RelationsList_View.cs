using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nihulon2.Model;
using System.Collections;

namespace Nihulon2.RelationsList
{
    /*
     * The class of view that displays the data of items related to exams
     * like divisions, courses and rooms.
     * IRelationsListView - interface that provides methods to the controller for 
     * displaying the data
     */
    public partial class RelationsList_View : UserControl, IRelationsListView
    {
        // instance of the controller that manages this view
        RelationsList_Controller _controller;
        
        public RelationsList_View()
        {
            InitializeComponent();

            // Fill the combo box with types of related items
            cbo_ItemType.Items.Add("חטיבות/מגמות");
            cbo_ItemType.Items.Add("חדרים");

            // Set names of columns in the data grid
            initialiseDataGridColumns();
        }

        // Shows a message to the user
        public void showMsg(string text)
        {
            MessageBox.Show(text);
        }

        #region Events

        // fill the data grid view with new values when relations type is changed
        private void cbo_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemType = cbo_ItemType.SelectedItem.ToString();

            if (itemType != "")
            {
                // Set mode of working to "Divisions and courses" or "Rooms"
                if(itemType == "חטיבות/מגמות")
                {
                    this.lableDivisionsRooms.Text = "חטיבות";
                    this.showTableWithCourses(true);
                }
                else if(itemType == "חדרים")
                {
                    this.lableDivisionsRooms.Text = "חדרים";
                    this.showTableWithCourses(false);
                }

                _controller.loadDataByType(itemType);
            }
                
        }

        // Call to the controller's method that inserts new related item into the DB and reloads the grid
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            // Get name of the item from the text box
            string newItemName = txtAddNewItem.Text;
            if (newItemName != "")
            {
                // Insert the new item and clear the text box
                _controller.addNewItem(newItemName);
                txtAddNewItem.Text = "";
            }
        }

        // Change status of the selected item to disabled/not disabled
        private void btn_Disable_Click(object sender, EventArgs e)
        {
            // If there is selected row at the table
            if (dgvItems.SelectedRows.Count != 0)
            {
                // Get the name of selected item from data grid
                string nameOfItem = "";
                DataGridViewRow row = dgvItems.SelectedRows[0];
                nameOfItem = row.Cells[0].Value.ToString();

                if (nameOfItem != "") // if there is a name in the selected row
                {
                    _controller.changeStatusOfItem(nameOfItem);
                }
            }
        }

        // Change status of the selected course to disabled/not disabled
        private void btnDisableCourse_Click(object sender, EventArgs e)
        {
            // If there is selected row at the table
            if (dgvCourses.SelectedRows.Count != 0)
            {
                // Get the name of selected item from data grid
                string nameOfCourse = "";
                DataGridViewRow row = dgvCourses.SelectedRows[0];
                nameOfCourse = row.Cells[0].Value.ToString();

                if (nameOfCourse != "") // if there is a name in the selected row
                {
                    _controller.changeStatusOfCourse(nameOfCourse);
                }
            }
        }

        /*
         * Toggle between two modes:
         * - show related items without disabled
         * - show all related
         */
        private void cbShowDisabled_CheckedChanged(object sender, EventArgs e)
        {
            // Set the flag at the controller
            _controller.ShowDisabled = cbShowDisabled.Checked;
            // Reload data from the DB
            _controller.loadDataByType(cbo_ItemType.SelectedItem.ToString());
        }

        // Disable the button of creation if the txt fields are not filled
        private void txtAddNewItem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddNewItem.Text))
                btnAddNewItem.Enabled = false;
            else
                btnAddNewItem.Enabled = true;
        }
        private void txtAddNewCourse_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddNewCourse.Text))
                btnAddNewCourse.Enabled = false;
            else
                btnAddNewCourse.Enabled = true;

        }

        #endregion

        #region Interface
        // binds the view with its controller
        public void setController(RelationsList_Controller controller)
        {
            _controller = controller;
        }

        // fill the data grid with related items
        public void fillDataGrid(RelatedItem[] items)
        {           

            // Fill the grid
            for (int i = 0; i < items.Length; i++)
            {
                // Create new row
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());

                // Add values to the new row
                row.Cells[0].Value = items[i].Name.ToString();
                if (items[i].IsDisabled)
                    row.Cells[0].Value += "    (מבוטל)";

                // Add created row to the data grid
                dgvItems.Rows.Add(row);
            }
        }

        // Clear the data grid
        public void clearDataGrid()
        {
            dgvItems.Rows.Clear();
        }

        // fill the data grid with courses
        public void fillCourses(Course[] courses)
        {
            // Fill the grid with courses
            for (int i = 0; i < courses.Length; i++)
            {
                // Create new row
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());

                // Add values to the new row
                row.Cells[0].Value = courses[i].Name.ToString();
                if (courses[i].IsDisabled)
                    row.Cells[0].Value += "    (מבוטל)";

                // Add created row to the data grid
                dgvCourses.Rows.Add(row);
            }
        }

        // Clear the data grid with courses
        public void clearCourses()
        {
            dgvCourses.Rows.Clear();
        }

        // Set a type of related items as selected at the combo box
        public void setRelatedItemsType(string type)
        {
            cbo_ItemType.SelectedItem = type;
        }

        // Reload the view
        public void reloadView()
        {
            _controller.reload();
        }

        #endregion

        #region Private methods

        // Set names and other parameters for the dataGrid columns
        private void initialiseDataGridColumns()
        {
            dgvItems.ColumnCount = 1;
            dgvCourses.ColumnCount = 1;

            // Set names of the columns
            dgvItems.Columns[0].HeaderText = "שם";
            dgvItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCourses.Columns[0].HeaderText = "שם";
            dgvCourses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Set visible or not the part of the view that is related to the courses 
        private void showTableWithCourses(bool show)
        {
            if (show)
            {
                dgvCourses.Visible = true;
                btnAddNewCourse.Visible = true;
                txtAddNewCourse.Visible = true;
                labelCourses.Visible = true;
                btnDisableCourse.Visible = true;
                btnChangeDiv.Visible = true;
            }
            else
            {
                dgvCourses.Visible = false;
                btnAddNewCourse.Visible = false;
                txtAddNewCourse.Visible = false;
                labelCourses.Visible = false;
                btnDisableCourse.Visible = false;
                btnChangeDiv.Visible = false;
            }
        }

        #endregion

        // When division selected, get its name and fill the table of courses related to the division
        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (cbo_ItemType.SelectedItem.ToString() == "חטיבות/מגמות")
            {
                if(dgvItems.SelectedCells.Count > 0)
                {
                    string selectedRow = dgvItems.SelectedCells[0].Value.ToString();

                    _controller.loadCourses(selectedRow);
                }                
            }            
        }

        // Call to the controller's method that inserts new course into the DB,
        // binds the new course to its division and reloads the grid
        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            // Get name of the course and the division
            string newCourseName = txtAddNewCourse.Text;
            string divisionName = dgvItems.SelectedCells[0].Value.ToString();
            if (newCourseName != "" && divisionName != "")
            {
                // Insert the new course and clear the text box
                _controller.addNewCourse(newCourseName, divisionName);
                txtAddNewCourse.Text = "";
            }
        }

        // Move a course to another division
        private void btnChangeDiv_Click(object sender, EventArgs e)
        {
            List<string> divisions = _controller.loadAllDivisions();
            frmChooseDivision chooseDivisionForm = new frmChooseDivision(divisions);

            // Event called when user has chosen the division
            chooseDivisionForm.onDivisionChosen += divisionForMovingChoosen;

            chooseDivisionForm.StartPosition = FormStartPosition.CenterParent;
            chooseDivisionForm.ShowDialog();
        }

        // When the user has chosen the division at the form of moving
        // a course to another division
        private void divisionForMovingChoosen(string divisionName)
        {
            string course = dgvCourses.SelectedCells[0].Value.ToString();
            _controller.moveCourseToDivision(course, divisionName);
        }


    }
}
