using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Logic
{
  public interface IPersonProcessor
  {
    IPersonModel CreatePerson(string firstName, string lastName, string heightText);
    List<IPersonModel> LoadPeople();
    void SavePerson(IPersonModel person);
    void UpdatePerson(IPersonModel person);
    (bool isValid, double heightInInches) ConvertHeightTextToInches(string heightText);

  }
}
