using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Nihulon2.Model.DbAccess
{
    // The class that provides the connection to the DB
    // end execution of different queries
    public class DbAccess
    {
        #region Constructor + Members
        protected OleDbConnection _conn = null;

        public DbAccess(string connectionstring)
        {
            _conn = new OleDbConnection(connectionstring);
        }
        #endregion

        #region Protected Methods
        // Open a connection with the DB
        protected void Connect()
        {
            if(_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }
        // Close the connection
        protected void Disconnect()
        {
            _conn.Close();
        }
        // Execute a query that doesn't returns any result
        protected void ExecuteSimpleQuery(OleDbCommand command)
        {            
            lock(_conn){
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    Disconnect();
                }
            }
        }
        // Execute a query that returns an integer value
        protected int ExecuteScalarIntquery(OleDbCommand command)
        {
            int ret = -1;
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }
        // Execute a query that returns complex result
        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataset = new DataSet();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataset;
        }
        #endregion
    }
}

