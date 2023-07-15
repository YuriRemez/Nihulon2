using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nihulon2.Model;

namespace Nihulon2.RelationsList
{
    /*
     * interface that provides methods to the controller for 
     * displaying the data
     */
    public interface IRelationsListView
    {
        // binds the view with its controller
        void setController(RelationsList_Controller controller);

        // fill the data grid with related items
        void fillDataGrid(RelatedItem[] items);

        // fill the data grid with courses
        void fillCourses(Course[] courses);

        // Clear the data grid
        void clearDataGrid();

        // Clear the data grid with courses
        void clearCourses();

        // Set a type of related item as selected in the combo box
        void setRelatedItemsType(string type);

        // Reload the view
        void reloadView();

        // Shows the message to the user
        void showMsg(string text);
    }
}
