using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nihulon2.SupervisorsAdministration
{
    /*
     * The form for entering the name of Excel file
     * with exam table
     */
    public partial class frmGetNameOfExcelFile : Form
    {
        // Event handler that is called when the user 
        // confirms the name of Excel file
        public delegate void fileNameConfirmedHandler(string fileName);
        public event fileNameConfirmedHandler onFileNameConfirm;

        public frmGetNameOfExcelFile()
        {
            InitializeComponent();
        }

        // Close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Sends the message to subscribers with the name of Excel file
        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            if (onFileNameConfirm != null)
                onFileNameConfirm(txtName.Text);

            this.Dispose();
        }
    }
}
