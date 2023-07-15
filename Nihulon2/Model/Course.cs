using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nihulon2.Model
{
    /* That class is one of the items that are related to exams.
     * Making separate class for it is necessary because it has addition property
       that bounds it to one of the divisions*/
    public class Course : RelatedItem
    {
        private string _divisionName;

        public Course() { } // Default constructor
        public Course(string couseName, string divisionName) : base(couseName)
        {
            _divisionName = divisionName;
        }

        public string DivisionName
        {
            get { return _divisionName; }
            set { _divisionName = value; }
        }
    }
}
