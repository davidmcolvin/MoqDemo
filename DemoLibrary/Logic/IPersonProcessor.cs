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
    PersonModel CreatePerson(string firstName, string lastName, string heightText);
    List<PersonModel> LoadPeople();
    void SavePerson(IPersonModel person);
    void UpdatePerson(IPersonModel person);
    (bool isValid, double heightInInches) ConvertHeightTextToInches(string heightText);

  }
}
