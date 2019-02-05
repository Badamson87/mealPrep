namespace mealPrep.Models
{
  public class meal {
    public int Id {get; set;}
    public string Name {get; set;}

    public string Img {get; set;}

    public string Description {get; set;} 

    public int Calories {get; set;}

    public bool Complete {get; set;}

  }
}