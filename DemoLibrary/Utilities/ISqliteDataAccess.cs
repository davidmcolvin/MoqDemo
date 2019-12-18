using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;

namespace DemoLibrary.Utilities
{
  public interface ISqliteDataAccess
  {
    void UpdateData<T>(T person, string sql);
    void SaveData<T>(T person, string sql);
    List<T> LoadData<T>(string sql);
  }
}
