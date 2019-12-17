namespace DemoLibrary.Models
{
  public interface IPersonModel
  {
    int Id { get; set; }
    string FirstName { get; set; }
    string HeightText { get; set; }
    string LastName { get; set; }
    double HeightInInches { get; set; }
  }
}