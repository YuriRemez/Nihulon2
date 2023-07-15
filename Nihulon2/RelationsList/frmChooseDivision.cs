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

namespace Nihulon2.RelationsList
{
    /*
     * The form for choosing the name of division
     * for mooving a course to this division
     */
    public partial class frmChooseDivision : Form
    {

        // Event handler that is called when the user 
        // confirms the choice
        public delegate void DivisionChosenHandler(string divisionName);
        public event DivisionChosenHandler onDivisionChosen;

        private List<string> divisionsList;

        public frmChooseDivision(List<string> divisions)
        {
            divisionsList = divisions;
            InitializeComponent();

            // Load the combobox of divisions
            cboDivisions.DataSource = divisionsList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (onDivisionChosen != null)
                onDivisionChosen(cboDivisions.SelectedItem.ToString());

            this.Dispose();
        }
    }
}
