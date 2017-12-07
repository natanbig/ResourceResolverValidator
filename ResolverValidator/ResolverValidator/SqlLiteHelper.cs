using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ResolverValidator
{
    public class SqlLiteHelper:Form1
    {
         SQLiteConnection sql_con;
         SQLiteCommand sql_cmd;
        private void SetConnection()
        {
         string connectionParameter = string.Format(@"Data Source = C:\Program Files\Websense\Websense Endpoint\ResourceResolver\ResourceResolverSlimMaster.db;Version=3;Read Only=True;");
         sql_con = new SQLiteConnection(connectionParameter, true);
            sql_cmd = new SQLiteCommand();
            
        }

        public List<ImportedTableData> StartConnection(string sqlQuery )
        {
            SetConnection(); 
            List<ImportedTableData> table = new List<ImportedTableData>();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = sqlQuery;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                table.Add(new ImportedTableData( Convert.ToInt16(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                
            }
            sql_con.Close();
            return new List<ImportedTableData>(table);
        }

        


    }
}
