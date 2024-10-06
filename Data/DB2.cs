using System;
//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingSystem.Properties;//***needs to be added to be able to use the Settings property

namespace BookingSystem.Data
{
    public class DB2
    {
        #region Variable declaration
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.BookingDatabaseConnectionString;
        public SqlConnection cnMain;
        public DataSet dsMain;
        public SqlDataAdapter daMain;
        #endregion

        #region Constructor
        public DB2()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error trying to Open a connection & create a new dataset object!");
                return;
            }
        }

        #endregion

        #region Update the DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();

                // Only clear the specific table if it exists, otherwise the dataset is left intact
                if (dsMain.Tables.Contains(aTable))
                {
                    dsMain.Tables[aTable].Clear();
                }

                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();
                //***update the database table via the data adapter
                daMain.Update(dsMain, table);
                //---close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
