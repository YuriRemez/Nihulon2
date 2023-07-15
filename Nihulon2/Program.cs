using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nihulon2.Model;
using Nihulon2.RelationsList;
using Nihulon2.SupervisorsAdministration;
using Nihulon2.Model.DbAccess;
using System.Configuration;
using System.IO;

namespace Nihulon2
{  

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the connection string. May be changed in App.config
            DbConnector.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Create a folder for Excel files if not exists
            string location = System.Windows.Forms.Application.StartupPath;
            location += @"\אקסל";
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_View());
        }
    }
}
