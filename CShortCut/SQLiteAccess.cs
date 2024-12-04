using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Windows.Forms;
namespace CShortCut
{
    internal class SQLiteAccess
    {

        
        public static List<CShortCutData> LoadShortCut()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))

            {
                string sql = "select * from shortCutTable";
                var result = conn.Query<CShortCutData>(sql, new DynamicParameters());
                return result.ToList();
            }

        }

        public static dynamic ReadSelectedShortCutKey(long rowIndex)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "select * from shortCutTable where id = @rowIndex ";
                return conn.QuerySingleOrDefault(sql, new { rowIndex });
            }
        }

        public static void InsertShortCutKey(CShortCutData data)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "insert into shortCutTable(ShortCutKey,Definition) values (@ShortCutKey,@Definition)";
                conn.Execute(sql, data);
            }
        }

        public static void DeleteShortCutKey(long rowIndex)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    string sql = "delete from shortCutTable where id = @rowIndex ";
                    conn.Execute(sql, new { rowIndex });

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               

            }
        }

        public static void EditShortCutKey(CShortCutData cShortCutDataTable)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    string sql = "update shortCutTable set ShortCutKey=@ShortCutKey, Definition = @Definition  where id = @id";
                    conn.Execute(sql, new
                    {
                        cShortCutDataTable.id,
                        cShortCutDataTable.ShortCutKey,

                        cShortCutDataTable.Definition
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    

        public static string LoadConnectionString(string id = "shortCut")
        {
           
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        
    }
}
