using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nihulon2.Model;

namespace Nihulon2.SupervisorsAdministration
{
    /*
     * Interface that provides methods to the controller for 
     * displaying the data
     */
    public interface ISupervisorsAdministrationView
    {
        // binds the view with its controller
        void setController(SupervisorsAdministration_Controller controller);

        // Binds the list of exams at the controller with the table at the view
        void bindExamsWithTable(ref SortableBindingList<Exam> examsList);

        // Fill the combo box of the filter by division
        void fillDivisionsCbo(string[] divisionsNames);

        // Fill the combo box of the filter by course
        void fillCoursesCbo(string[] coursesNames);

        // Fill the combo box of the filter by room
        void fillRoomsCbo(string[] roomsNames);

        // Clear all combo boxes
        void clearComboBoxes();

        // Reload all data at the view
        void reloadView();

        // Show message to the user if exams with time overlaps have been found
        void showOverlapsWarning(bool hasOverlaps);

        // Shows the message to the user
        void showMsg(string text);

        // Set the exam as selected by its ID
        void setSelected(int selectedId);
    }
}
