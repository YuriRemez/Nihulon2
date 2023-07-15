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
    /* The form of changing exams.
    * Has controls for changing different properties of an exam
    * and two buttons for canceling and saving the changes */
    public partial class frmChangeExam : Form
    {
        private SupervisorsAdministration_Controller _controller;
        // Event handler that is called when the user clicks the button
        // "save changes"
        public delegate void saveChangesHandler(Exam exam);
        public event saveChangesHandler onSaveChanges;

        Exam exam; // The exam for changing

        public frmChangeExam(SupervisorsAdministration_Controller controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        // Fill the comboboxes with divisions and rooms
        public void fillComboBoxes(ObjectCollection divisions, ObjectCollection rooms)
        {
            for (int i = 0; i < divisions.Count; i++)
                cboDivision.Items.Add(divisions[i]);
            for (int i = 0; i < rooms.Count; i++)
                cboRoom.Items.Add(rooms[i]);
        }

        // Take an exam and fill all fields of the form
        public void setExam(Exam examForChanging)
        {
            exam = examForChanging;

            // Get datetime from strings
            DateTime date = Convert.ToDateTime(exam.Date);
            DateTime startTime = Convert.ToDateTime(exam.StartTime);
            DateTime endingTime = Convert.ToDateTime(exam.EndingTime);

            // fill the fields of the form with data of the exam that is
            // needed to be changed
            try
            {
                DatePicker.Value = date;
                FromTimePicker.Value = startTime;
                ToTimePicker.Value = endingTime;
                cboDivision.SelectedItem = exam.division;

                // Fill the combobox with courses
                cboCourse.Items.Clear();
                List<string> courses = _controller.getCoursesByDivision(exam.division);
                foreach (string course in courses)
                    cboCourse.Items.Add(course);

                cboCourse.SelectedItem = exam.course;
                cboRoom.SelectedItem = exam.room;
                txtDiscipline.Text = exam.DisciplineName;
                txtGroup.Text = exam.GroupName;
                txtSupervisor.Text = exam.SupervisorName;
                cbExtraTime.Checked = exam.hasExtraTime;
            }
            catch { }
        }

        // Close the form without exam changing
        private void btnCancelChanging_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Save the new values at the exam and send a message with
        // the new exam to subscribers
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            exam.course = cboCourse.Text;
            exam.Date = DatePicker.Value;
            exam.DisciplineName = txtDiscipline.Text;
            exam.division = cboDivision.Text;
            exam.EndingTime = ToTimePicker.Text;
            exam.GroupName = txtGroup.Text;
            exam.hasExtraTime = cbExtraTime.Checked;
            exam.room = cboRoom.Text;
            exam.StartTime = FromTimePicker.Text;
            exam.SupervisorName = txtSupervisor.Text;

            // Send the message that the exam was changed
            if (onSaveChanges != null)
                onSaveChanges(exam);

            this.Dispose();
        }
        // Called when one of the time pickers at the form of creating
        // new exams has been changed.
        // Checks if the "from" date is earlier than "to" date
        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ToTimePicker.Value < FromTimePicker.Value)
            {
                ToTimePicker.Value = FromTimePicker.Value;
            }
        }

        // When the user choose a division, fill the combobox of courses with relevant courses
        private void cboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> coursesNames = _controller.getCoursesByDivision(cboDivision.Text);

            cboCourse.Items.Clear();

            foreach (string name in coursesNames)
                cboCourse.Items.Add(name);
        }

        // When user enters text at the comboboxes, check if the input is correct
        // if not, disable the submit button
        private void comboBoxes_TextChanged(object sender, EventArgs e)
        {
            checkRequiredFields();
        }

        // Check if all the required fields of changing form are filled
        private void checkRequiredFields()
        {
            if (cboCourse.SelectedIndex != -1 && cboDivision.SelectedIndex != -1 &&
                cboRoom.SelectedIndex != -1)
            {
                btnSaveChanges.Enabled = true;
            }
            else
                btnSaveChanges.Enabled = false;
        }
    }
}