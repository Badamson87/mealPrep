namespace mealPrep.Models
{
  public class ingredient {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}

    public int Calories {get; set;}

    public int Quantity {get; set;}

      public bool Complete {get; set;}

  }
}