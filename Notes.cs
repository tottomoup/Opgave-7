//Classes Det mr. Big Man lavede
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

//En anden måde at lave clasess på (del 1)
/*
class Car
{
    public string model;
    public string color;
    public int year;
}
*/

//En anden måde at lave clasess på (del 2)
/*
    Car car1 = new Car();
    car1.model = "Ford";
    car1.color = "Yellow";
    car1.year = 2005;

    Console.WriteLine(car1.model);

    Console.ReadLine();
*/

//objekt test
/*
new Car();

Car myObj1 = new Car();
Car myObj2 = new Car();
Console.WriteLine(myObj1.color);
Console.WriteLine(myObj2.color);
*/

//Class with no construcktor
/*
class Car 
{
  string model;
  string color;
  int year;

  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model +" "+ Ford.color +" "+ Ford.year);
    Console.WriteLine(Opel.model);

Console.ReadLine();

  }
  
}
*/

// List of string
/*
List<string> authors = new List<string>();
authors.Add("Toyota Igo");
authors.Add("Mercedes Dense");
authors.Add("Porse Pan");
authors.Add("Mini Maxi");
authors.Add("Niisan GTS");
authors.Add("FolkeVogn");
authors.Add("Ford Poney");

Console.WriteLine("Count: " + authors.Count);
Console.WriteLine("Capacity: " + authors.Capacity);

foreach (string a in authors)
    Console.WriteLine(a);

Console.ReadLine();

*/