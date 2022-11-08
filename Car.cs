
//Det mr. Big Man lavede
/*
public class Car
{
    public static List<string> Possibles = new List<string>(){
        "Toyota", "BMW", "AUDI"
    };

    public string color = "red";
    public string Brand;

    public Car(string brand){
        Brand = brand;
    }
}
*/


//En anden måde at lave clasess på
/*
class Car
{
    public string model;
    public string color;
    public int year;
}
*/


//Constructors example (den vi går videre med)
class Car
{
  public string model;
  public string color;
  public int year;

  // Create a class constructor with multiple parameters
  public Car(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;
  }
}