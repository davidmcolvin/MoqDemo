using DemoLibrary.Logic;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  public class Application : IApplication
  {
    IPersonProcessor _personProcessor;

    public Application(IPersonProcessor personProcessor)
    {
      _personProcessor = personProcessor;
    }

    public void Run()
    {
      IdentifyNextStep();
    }

    private void IdentifyNextStep()
    {
      string selectedAction = "";

      do
      {
        selectedAction = GetActionChoice();

        Console.WriteLine();

        switch (selectedAction)
        {
          case "1":
            DisplayPeople(_personProcessor.LoadPeople());
            break;
          case "2":
            AddPerson();
            break;
          case "3":
            Console.WriteLine("Thanks for using this application");
            break;
          default:
            Console.WriteLine("That was an invalid choice.  Hit enter and try again.");
            break;
        }

        Console.WriteLine("Hit return to continue...");
        Console.ReadLine();
      } while (selectedAction != "3");
    }

    private string GetActionChoice()
    {
      string output = "";

      Console.WriteLine("MENU OPTIONS:");
      Console.WriteLine("Press 1 to display people");
      Console.WriteLine("Press 2 to add a person");
      Console.WriteLine("Press 3 to exit");

      output = Console.ReadLine();
      return output;
    }

    private void AddPerson()
    {
      Console.Write("What is the person's first name: ");
      string firstName = Console.ReadLine();
      Console.Write("What is the person's last name: ");
      string lastName = Console.ReadLine();
      Console.Write("What is the person's height: ");
      string height = Console.ReadLine();

      var person = _personProcessor.CreatePerson(firstName, lastName, height);
      _personProcessor.SavePerson(person);
    }

    private void DisplayPeople(List<IPersonModel> list)
    {
      var people = _personProcessor.LoadPeople();

      foreach (IPersonModel person in people)
      {
        Console.WriteLine($"{person.FirstName} {person.LastName} is { person.HeightInInches } inches tall.");
      }
    }
  }
}
