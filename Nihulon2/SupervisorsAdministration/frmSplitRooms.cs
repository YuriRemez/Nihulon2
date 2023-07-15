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
    public partial class frmSplitRooms : Form
    {
        private string[] _rooms;

        public frmSplitRooms(string originalRoomStr, ref string[] rooms)
        {
            InitializeComponent();

            txtOriginal.Text = originalRoomStr;
            _rooms = rooms;

            // Add textboxes if there are more than 2 rooms
            if(_rooms.Length == 3)
            {
                lblRoom3.Visible = true;
                txtRoom3.Visible = true;
            }
            if (_rooms.Length == 4)
            {
                lblRoom3.Visible = true;
                txtRoom3.Visible = true;
                lblRoom4.Visible = true;
                txtRoom4.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            throw new Exception();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _rooms[0] = txtRoom1.Text;
            _rooms[1] = txtRoom2.Text;
            if (_rooms.Length == 3)
                _rooms[2] = txtRoom3.Text;
            else if (_rooms.Length == 4)
            {
                _rooms[2] = txtRoom3.Text;
                _rooms[3] = txtRoom4.Text;
            }                
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            this.Dispose();
        }
    }
}
