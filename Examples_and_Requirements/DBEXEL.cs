using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Questionnaire
{
    //התחברות לאקסל
    public class DBEXEL
    {
        #region Constructor + Members

        protected OleDbConnection _conn = null;
        public DBEXEL(string connstring)
        {
            _conn = new OleDbConnection(connstring);
        }
        #endregion

        #region
        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }

        protected void Disconnect()
        {
            _conn.Close();
        }

        protected DataTable GetMultiple(OleDbCommand command)
        {
            DataTable dt = new DataTable();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dt;
        }

        #endregion
    }
}
