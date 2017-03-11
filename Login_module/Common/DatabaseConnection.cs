using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace AcademicManagementSystem.Common
{
    public class DatabaseConnection
    {

        public OleDbConnection conectionObject;

        public DatabaseConnection()
        {
        }

        #region 'Public  Methods'

        public void OpenConection()
        {
            conectionObject = new OleDbConnection(connectionString());
            conectionObject.Open();
        }

        public void CloseConnection()
        {
            conectionObject.Close();
        }

        public bool ExecuteQueries(string strQuery)
        {
            try
            {
                OpenConection();
                OleDbCommand cmd = new OleDbCommand(strQuery, conectionObject);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //Later release should Log the Exception
                return false;
            }
        }

        public OleDbDataReader SelectDataReader(string query)
        {
            try
            {
                OpenConection();
                OleDbCommand cmd = new OleDbCommand(query, conectionObject);
                OleDbDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                //Later release should Log the Exception  
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object SelectCollectionDataReader(string query)
        {
            try
            {
                OpenConection();
                OleDbDataAdapter dr = new OleDbDataAdapter(query, conectionObject);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                object dataum = ds.Tables[0];
                return dataum;
            }
            catch (Exception ex)
            {
                //Later release should Log the Exception
                return null;
            }

        }

        #endregion

        #region 'Private Variable'

        private readonly string _connectionStringValue = Properties.Settings.Default["ConnectionString"].ToString();

        #endregion

        #region 'Private Methods'


        private string connectionString()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dbDir = Directory.GetParent(Directory.GetParent(currentDir).FullName).FullName;
            return String.Format(_connectionStringValue, dbDir);
        }

        #endregion
    }
}
