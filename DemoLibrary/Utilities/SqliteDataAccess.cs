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
    string _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

    public List<T> LoadData<T>(string sql)
    {
      using (IDbConnection connection = new SQLiteConnection(_connectionString))
      {
        return connection.Query<T>(sql).ToList();
      }
    }

    public void SaveData<T>(T model, string sql)
    {
      using (IDbConnection connection = new SQLiteConnection(_connectionString))
      {
        connection.Execute(sql, model);
      }
    }

    public void UpdateData<T>(T model, string sql)
    {
      using (IDbConnection connection = new SQLiteConnection(_connectionString))
      {
        connection.Execute(sql, model);
      }
    }
  }
}
