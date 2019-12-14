namespace DemoLibrary.Models
{
  public interface IPerson
  {
    string FirstName { get; set; }
    int Id { get; set; }
    string LastName { get; set; }
  }
}