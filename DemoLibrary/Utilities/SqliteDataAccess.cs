using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DemoLibrary.Models;

namespace DemoLibrary.Utilities
{
  public class SqliteDataAccess : ISqliteDataAccess
  {
    public List<T> LoadData<T>(string sql)
    {
      using (IDbConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
      {
        return connection.Query<T>(sql).ToList();
      }
    }

    public void SaveData(IPersonModel person, string sql)
    {
      using (IDbConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
      {
        List<IPersonModel> people = new List<IPersonModel>();
        people.Add(person);

        connection.Execute(sql, people);
      }
    }

    public void UpdateData(IPersonModel person, string sql)
    {
      var p = new DynamicParameters();
      using (IDbConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
      {
        connection.Execute(sql, person);
      }
    }
  }
}
