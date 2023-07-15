using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Nihulon2.Model;
using Nihulon2.Model.DbAccess;

namespace Nihulon2.RelationsList
{

    /* The class that assumes the layer between the view and DataBase.
    * It provides methods that get data from the dbConnector and
    * calls the view methods to fill its controls with the new data.
    * This controller works with the items related to the exam
    * like divisions, courses and rooms */
    public class RelationsList_Controller
    {               
        private IRelationsListView _view; // An instance of the view for data visualization
        private DbConnector dbConn; // An instance of the class that provides connection to the DB
        private RelatedItem[] relatedItems; // Items that are in the data grid of RelationsList_View
        private Course[] courses;
        private string selectedType; // The type that is selected in the combo box of the view

        // Defines if disabled related items are going to be shown
        public bool ShowDisabled
        {
            get;
            set;
        }

        /* The constructor. It initializes instances of the dbConnector and
        * the view classes, and sets default values for flags and comboBoxes
        * view - The instance of a view that will work with this controller */
        public RelationsList_Controller(IRelationsListView view)
        {
            // Initializing connection to DB            
            dbConn = DbConnector.Instance;

            ShowDisabled = false; // Don't show disabled related items by default

            // Binding with view
            _view = view;
            _view.setController(this);
            // set divisions as default related items and fill the data grid of the view
            selectedType = "חטיבות/מגמות";
            _view.setRelatedItemsType(selectedType);
        }
        #region Interface

        /* Gets array of items from DB according to the type and
        * calls the method of the view that fills grid with the items
        * itemType - The type of items that will be loaded from the DB */
        public void loadDataByType(string itemType)
        {
            selectedType = itemType;
            /* Get an array of related items from DB
               itemType - The type of needed items (Divisions, Courses, Rooms)
               ShowDisabled - True or false. If we need the array including disabled items*/
            
            if(itemType == "חטיבות/מגמות")
                relatedItems = dbConn.GetRelatedItemsByType("חטיבות", ShowDisabled);
            else
                relatedItems = dbConn.GetRelatedItemsByType("חדרים", ShowDisabled);            

            _view.clearDataGrid();
            _view.fillDataGrid(relatedItems);
        }

        // Takes name of a division and load all courses related to the division
        public void loadCourses(string divisionName)
        {
            this.courses = dbConn.getCourses(divisionName, ShowDisabled);

            _view.clearCourses();
            _view.fillCourses(courses);
        }

        // Returns a list of all not disabled divisions
        public List<string> loadAllDivisions()
        {
            RelatedItem[] listOfDivisions;
            listOfDivisions = dbConn.GetRelatedItemsByType("חטיבות", false);

            List<string> divisionsNames = new List<string>();

            foreach(RelatedItem division in listOfDivisions)
                divisionsNames.Add(division.Name);

            return divisionsNames;
        }

        // Move a course to another division and reload the view
        public void moveCourseToDivision(string courseName, string divisionName)
        {
            dbConn.changeDivisionForCourse(courseName, divisionName);

            loadDataByType(selectedType);
        }


        /* Adds new related item to the DB
        * newItemName - The name of the new item */
        public void addNewItem(string newItemName)
        {
            try
            {
                if (!string.IsNullOrEmpty(newItemName))
                {
                    // Insert new division or room
                    if (selectedType == "חטיבות/מגמות")
                    {
                        if (!dbConn.checkIfItemExists(newItemName, "חטיבות"))
                            dbConn.insertRelatedItem(newItemName, "חטיבות");
                        else
                            _view.showMsg("החטיבה כבר קיימת\n(ייתכן בתוך החטיבות המבוטלות)");
                    }                        
                    else
                    {
                        if (!dbConn.checkIfItemExists(newItemName, "חדרים"))
                            dbConn.insertRelatedItem(newItemName, "חדרים");
                        else
                            _view.showMsg("החדר כבר קיים\n(ייתכן בתוך החדרים המבוטלים)");
                    }
                        
                }                   
            }
            catch { };
                
            loadDataByType(selectedType); // reload the data grid after the new item was inserted           
        }

        /* Adds new course to the DB
        * newCourseName - The name of the new course
        * divisionName - the name of the division that the new
          course is related to*/
        public void addNewCourse(string newCourseName, string divisionName)
        {
            try
            {
                if (!string.IsNullOrEmpty(newCourseName) && !string.IsNullOrEmpty(divisionName))
                {
                    if (!dbConn.checkIfItemExists(newCourseName, "מגמות"))
                        dbConn.insertCourse(newCourseName, divisionName);
                    else
                        _view.showMsg("המגמה כבר קיימת\n(ייתכן בתוך המגמות המבוטלות)");
                    // Insert new course
                    
                }

            }
            catch { };

            // reload the data grid after the new item was inserted
            loadDataByType(selectedType);  
        }

        // Takes a name of item and changes its status (disabled or not) at the DB and reload the data grid
        public void changeStatusOfItem(string nameOfItem)
        {
            if(!string.IsNullOrEmpty(nameOfItem)) // if the instance was found
            {
                if (selectedType == "חטיבות/מגמות")
                    dbConn.changeStatusToRelatedItem(nameOfItem, "חטיבות");
                else
                    dbConn.changeStatusToRelatedItem(nameOfItem, "חדרים");

                loadDataByType(selectedType); // reload the data grid after the item was changed                
            }
        }

        // Takes a name of course and changes its status (disabled or not) at the DB and reload the data grid
        public void changeStatusOfCourse(string nameOfCourse)
        {
            if (!string.IsNullOrEmpty(nameOfCourse)) // if the instance was found
            {
                dbConn.changeStatusToRelatedItem(nameOfCourse, "מגמות");

                loadDataByType(selectedType); // reload the data grid after the item was changed                
            }
        }

        // Get data from the DB and reload the view
        public void reload()
        {
            this.loadDataByType(selectedType);
        }
        #endregion
    }
}