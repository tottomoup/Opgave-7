# Opgave-7

Der skal laves et konsol program hvor man som bruger kan interagere med en "CarDealer", om man sælger, køber, eller hvordan det foregår er er ikke specificeret.
Lav gerne en krav analyse, specifikation og design for at hjælpe jer selv, dette ikke obligatorisk. (Det vil det være senere, så det er god øvelse)

Aflevering foregår via et offentligt github repository (Eller privat hvis du har registreret dig med din skole mail, husk at inviter Jesper-hansenberg til repositoriet)
Alle gruppemedlemmer skal have hver deres branch
Alle gruppemedlemmer skal løse noget af opgaven via push til deres branch
Arbejde skal merges ind i main/master-branchen
HUSK: Hvis man er i tvivl om det man gør er rigtigt, så kan man altid lave manuel backup af filerne

Create a CarDealer program
Minimum requirements:
The CarDealer must have a list of available cars for sale
The CarDealer must have public Buy/Sell methods
These methods must be accessible via console input/output
These methods must change the car dealers available cars
Make use of atleast 5 classes.
These classes must have atleast 1 Field variable each
Classes are usually nouns (navneord, en/et foran), f.x.:
Car, CarDealer, Engine, Person
Make use of atleast 10 methods
5 of these methods must use paramaters
Methods usually describes verbs (udsagnsord, at/jeg foran)
Buy, Sell, Accelerate, Move

Formålet med opgaven er at sikre i har en god forståelse for hvordan Gitkraken virker og sammenhængen imellem klasser og objekter da alt fremadrettet ville bygge videre på forståelsen af disse koncepter. Jeg forventer ikke noget fancy, men at der kan demonstreres brug og forståelse af Object Orientered Programmering. (Så jo flere Klasser og Objekter, jo bedre!)



//Noter
//Noter
//Noter

//Classes Det mr. Big Man lavede
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


//En anden måde at lave clasess på (del 1)

class Car
{
    public string model;
    public string color;
    public int year;
}


//En anden måde at lave clasess på (del 2)

    Car car1 = new Car();
    car1.model = "Ford";
    car1.color = "Yellow";
    car1.year = 2005;

    Console.WriteLine(car1.model);

    Console.ReadLine();


//objekt test

new Car();

Car myObj1 = new Car();
Car myObj2 = new Car();
Console.WriteLine(myObj1.color);
Console.WriteLine(myObj2.color);


//Class with no construcktor

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


// List of string

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

