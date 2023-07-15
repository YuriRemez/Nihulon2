using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Internal namespaces
using Nihulon2.RelationsList;
using Nihulon2.SupervisorsAdministration;

namespace Nihulon2
{
    public partial class Main_View : Form
    {
        // User controls that are included into the main form
        private SupervisorAdministration_View SupervisorsAdministrationView;
        private RelationsList_View RelationsListView;
        public Main_View()
        {
            InitializeComponent();
            InitializeViews(); // create and place views
            InitialiseControllers(); // create controllers and bind them with their views
        }

        // show User Control for Supervisors Administration and hide others
        private void btn_GotoSupervisorsAdministration_Click(object sender, EventArgs e)
        {
            SupervisorsAdministrationView.Visible = true;
            RelationsListView.Visible = false;
        }

        // show User Control for Relations List and hide others
        private void btn_GotoRelationsList_Click(object sender, EventArgs e)
        {
            SupervisorsAdministrationView.Visible = false;
            RelationsListView.Visible = true;
        }

        // show User Control for Reports and hide others
        private void btn_GotoReports_Click(object sender, EventArgs e)
        {
            SupervisorsAdministrationView.Visible = false;
            RelationsListView.Visible = false;
        }

        // Exit system
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            SupervisorsAdministrationView.reloadView();
            RelationsListView.reloadView();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;            
        }

        #region Methods for internal use

        /* Initialize all views, place them on the main form and set the starting view as visible */
        private void InitializeViews()
        {
            // Initialize views
            SupervisorsAdministrationView = new SupervisorAdministration_View();
            RelationsListView = new RelationsList_View();
            // place views on the right side of the main view
            SupervisorsAdministrationView.Location = new System.Drawing.Point(255, 12);
            RelationsListView.Location = new System.Drawing.Point(255, 12);
            // add views to the main view
            this.Controls.Add(SupervisorsAdministrationView);
            this.Controls.Add(RelationsListView);
            // set startihg view as visible and others as invisible
            SupervisorsAdministrationView.Visible = true;
            RelationsListView.Visible = false;
        }
        /* Initialises all controllers and binds them with their views */
        private void InitialiseControllers()
        {
            RelationsList_Controller RelListCtr = new RelationsList_Controller(RelationsListView);
            SupervisorsAdministration_Controller SupervAdmCtr = new SupervisorsAdministration_Controller(SupervisorsAdministrationView);
        }

        #endregion

        
    }
}
