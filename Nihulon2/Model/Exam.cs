using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nihulon2.Model
{
    // The class that represents the exam from the data base
    public class Exam
    {
        #region Properties

        public int Id
        {
            get;
            set;
        }
        [DisplayName("מבוטל")]
        public bool isCanceled
        {
            get;
            set;
        }
        [DisplayName("תאריך")]
        public DateTime Date
        {
            get;
            set;
        }
        [DisplayName("שם משגיח")]
        public string SupervisorName
        {
            get;
            set;
        }
        [DisplayName("חטיבה")]
        public string division
        {
            get;
            set;
        }
        [DisplayName("מגמה")]
        public string course
        {
            get;
            set;
        }
        [DisplayName("קבוצה")]
        public string GroupName
        {
            get;
            set;
        }
        [DisplayName("מקצוע")]
        public string DisciplineName
        {
            get;
            set;
        }
        [DisplayName("חדר")]
        public string room
        {
            get;
            set;
        }
        [DisplayName("שעת התייצבות")]
        public string StartTime
        {
            get;
            set;
        }
        [DisplayName("שעת סיום")]
        public string EndingTime
        {
            get;
            set;
        }
        [DisplayName("תוספת זמן")]
        public bool hasExtraTime
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public DateTime dateOfCreation
        {
            get;
            set;
        }
        public bool hasOverlap
        {
            get;
            set;
        }
        #endregion

        public void Clone(Exam other)
        {
            this.Comments = other.Comments;
            this.course = other.course;
            this.Date = other.Date;
            this.dateOfCreation = other.dateOfCreation;
            this.DisciplineName = other.DisciplineName;
            this.division = other.division;
            this.EndingTime = other.EndingTime;
            this.GroupName = other.GroupName;
            this.hasExtraTime = other.hasExtraTime;
            this.hasOverlap = other.hasOverlap;
            this.isCanceled = other.isCanceled;
            this.room = other.room;
            this.StartTime = other.StartTime;
            this.SupervisorName = other.SupervisorName;            
        }
    }
}