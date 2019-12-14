using DemoLibrary.Models;
using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Logic
{
  public class PersonProcessor : IPersonProcessor
  {
    ISqliteDataAccess _database;

    public PersonProcessor(ISqliteDataAccess database)
    {
      _database = database;
    }

    public PersonModel CreatePerson(string firstName, string lastName, string heightText)
    {
      PersonModel output = new PersonModel();

      if (ValidateName(firstName) == true)
      {
        output.FirstName = firstName;
      }
      else
      {
        throw new ArgumentException("The value was not valid", "firstName");
      }


    }

    private bool ValidateName(string firstName)
    {
      throw new NotImplementedException();
    }
  }
}
