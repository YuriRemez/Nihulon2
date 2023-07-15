using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nihulon2.Model
{
    /*The class that represents items related to exams (Divisions, Rooms)*/
    public class RelatedItem
    {
        private string _name;
        private bool _disabledStatus;

        // Default constructor
        public RelatedItem() { }
        // Constructor that set the name of the item
        public RelatedItem(string name)
        {
            _name = name;
            _disabledStatus = false;
        }

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public bool IsDisabled
        {
            get { return _disabledStatus; }
            set { _disabledStatus = value; }
        }
        #endregion
    }
}
