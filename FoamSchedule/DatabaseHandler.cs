using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace FoamSchedule
{
    public class DatabaseHandler
    {

        private string path;
        private SQLiteConnection sqlCon;

        
        public DatabaseHandler(string p)
        {
            this.path = p;
        }

        private void connect()
        {
            this.sqlCon = new SQLiteConnection($"Data Source={this.path};Version=3;New=False;Compress=True;");
        }

        public void executeNonQuery(string query)
        {

            try
            {
                this.connect();
                this.sqlCon.Open();
                SQLiteCommand sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = query;
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }

        public DataTable executeQuery(string query)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            try
            {
                this.connect();
                this.sqlCon.Open();
                sqlCon.CreateCommand();
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, sqlCon);
                da.Fill(ds);
                dt = ds.Tables[0];
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }

            return dt;
        }



    }
}
