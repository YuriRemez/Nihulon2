using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace Questionnaire
{
    public class DBXLS :DBEXEL
    {
        private int cntXlsRows;

        public int CntXlsRows
        {
            get { return cntXlsRows; }
        }
        static List<FileInfo> fileList = new List<FileInfo>();
        private string classString;
        private List<string> courseList;
        private List<string> teachersList;
        private DataTable courseDt;
        private DataTable classesDt;
        private DataTable teacherDt;

        public DBXLS(string connstring):base(connstring)
        {
            courseList = new List<string>();
            teachersList = new List<string>();
        }

        public static void setFilesToList(string pathFile)
        {
            
            foreach (string file in Directory.GetFiles(pathFile))
            {
                FileInfo f = new FileInfo(file);
                fileList.Add(f);
            }
        }

        public void readCourseFromFileList()
        {
           string cmCourse = "Select המקצוע from [" + "sheet1$]";
            using(OleDbCommand command = new OleDbCommand(cmCourse))
            {
                courseDt = GetMultiple(command);
            }
            //Fill course list with all the courses are in xls file
            foreach (DataRow item in courseDt.Rows)
            {
                if (item[0].ToString() == "")
                    break;
                this.courseList.Add(item[0].ToString());
                cntXlsRows++;
            }
        }

        public void readClassFromFileList()
        {
            
            string cmClass = "Select קבוצה from [" + "sheet1$]";
            using (OleDbCommand command = new OleDbCommand(cmClass))
            {
                classesDt = GetMultiple(command);
            }
            //get class string from xls file(all rows have the same class)
            foreach (DataRow item in classesDt.Rows)
            {
                ClassString = item[0].ToString();
                break;//need only one class
            }
        }
        public void readTeacherFromFileList()
        {
            
            string cmTeacher = "Select המרצה from [" + "sheet1$]";
            using (OleDbCommand command = new OleDbCommand(cmTeacher))
            {
                teacherDt = GetMultiple(command);
            }
            //Fill techers list with all the teachers are in xls file
            foreach (DataRow item in teacherDt.Rows)
            {
                if (item[0].ToString().CompareTo("")==0)
                    break;
                teachersList.Add(item[0].ToString());
            }
        }

        public static List<FileInfo> FileList
        {
            get { return fileList; }
        }

        public List<string> TeachersList
        {
            get { return teachersList; }
        }

        public List<string> CourseList
        {
            get { return courseList; }
        }

        public DataTable TeacherDt
        {
            get { return teacherDt; }
        }

        public string ClassString
        {
            get { return classString; }
            set { classString = value; }
        }

        public DataTable ClassesDt
        {
            get { return classesDt; }
        }

        public DataTable CourseDt
        {
            get { return courseDt; }
        }
        
    }
}
