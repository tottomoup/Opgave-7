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

#region Constructer and liste
//Constructors example (den vi går videre med)

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

    Car car1 = new Car("Volkswagen","Blue", 2023, 476538);
    Car car2 = new Car("Opel", "Yellow", 2019, 154675);
    Car car3 = new Car("Porsche", "Red", 2022, 1356789);
    Car car4 = new Car("BMW", "MattBlack", 2023, 456789);
    Car car5 = new Car("Mercedes", "White", 2021, 335287);
    Car car6 = new Car("Audi", "Black", 2020, 230605);

//Placere informationerne i en liste 
List<string> cars = new List<string>();
cars.Add(("\n" + car1.model + " " + car1.year + " " + car1.color + " " + car1.price + "kr"));
cars.Add(("\n" + car2.model + " " + car2.year + " " + car2.color + " " + car2.price + "kr"));
cars.Add(("\n" + car3.model + " " + car3.year + " " + car3.color + " " + car3.price + "kr"));
cars.Add(("\n" + car4.model + " " + car4.year + " " + car4.color + " " + car4.price + "kr"));
cars.Add(("\n" + car5.model + " " + car5.year + " " + car5.color + " " + car5.price + "kr"));
cars.Add(("\n" + car6.model + " " + car6.year + " " + car6.color + " " + car6.price + "kr"));


//How many cars are in the list
//Console.WriteLine("Count: " + cars.Count);

//Console.WriteLine("Capacity: " + cars.Capacity);
foreach (string a in cars)
    Text(a);

Console.ReadLine();
*/

#endregion

Er jeg i live?


Tobias Text ("Perfect, ill be with you right away");

Thread.Sleep(3000);

Text ("What car are you intrested in, we got:");
Console.WriteLine(".");


    Car car1 = new Car("Volkswagen","Blue", 2023, 476538);
    Car car2 = new Car("Opel", "Yellow", 2019, 154675);
    Car car3 = new Car("Porsche", "Red", 2022, 1356789);
    Car car4 = new Car("BMW", "MattBlack", 2023, 456789);
    Car car5 = new Car("Mercedes", "White", 2021, 335287);
    Car car6 = new Car("Audi", "Black", 2020, 230605);

//Placere informationerne i en liste 
List<string> cars = new List<string>();
cars.Add(("1." + car1.model + " " + car1.year + " " + car1.color + " " + car1.price + "kr"));
cars.Add(("2." + car2.model + " " + car2.year + " " + car2.color + " " + car2.price + "kr"));
cars.Add(("3." + car3.model + " " + car3.year + " " + car3.color + " " + car3.price + "kr"));
cars.Add(("4." + car4.model + " " + car4.year + " " + car4.color + " " + car4.price + "kr"));
cars.Add(("5." + car5.model + " " + car5.year + " " + car5.color + " " + car5.price + "kr"));
cars.Add(("6." + car6.model + " " + car6.year + " " + car6.color + " " + car6.price + "kr"));

//How many cars are in the list
//Console.WriteLine("Count: " + cars.Count);

//Console.WriteLine("Capacity: " + cars.Capacity);
foreach (string a in cars)
    Console.WriteLine(a);

Console.ReadLine();
Text ("What number are you intrested in?");
Console.WriteLine(" ");
Console.ReadLine();


//Create a CarDealer program
//Minimum requirements:
//The CarDealer must have a list of available cars for sale
//The CarDealer must have public Buy/Sell methods
//These methods must be accessiable via console input/output
//These methods must change the car dealers available cars
//Make use of atleast 5 classes.
//These classes must have atleast 1 Field variable each
//Classes are usually nouns (navneord, en/et foran), f.x.:
//Car, CarDealer, Engine, Person
//Make use of atleast 10 methods
//5 of these methods must use paramaters
//Methods usually describes verbs (udsagnsord, at/jeg foran)
//Buy, Sell, Accelerate, Move


// Suggestion to get started on user interaction in the console


//CarDealer dealer = new CarDealer(); //This class you need to create yourself!
//while(true){

  //Console.WriteLine("Write an action [buy, sell, exit]");
    //string input = Console.ReadLine();

    //switch (input)
    //{
        //case "buy":
            //Car myNewCar = dealer.buy(...);
            //break;
        //case "sell":
            //break;
        //case "exit":
            //return;
        //default:
            //return;
    //}
//}
/*/