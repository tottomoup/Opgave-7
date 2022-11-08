#region Assignment

#region Constructer and liste
//Constructors example (den vi går videre med)
    Car car1 = new Car("Mustang", "Red", 1969);
    Car car2 = new Car("Farari", "Red", 2018);
    Car car3 = new Car(" ", " ", 0);
    Car car4 = new Car(" ", " ", 0);
    Car car5 = new Car(" ", " ", 0);

//Placere informationerne i en liste 
List<string> cars = new List<string>();
cars.Add((car1.model + " " + car1.year + " " + car1.color));
cars.Add((car2.model + " " + car2.year + " " + car2.color));
cars.Add((car3.model + " " + car3.year + " " + car3.color));
cars.Add((car4.model + " " + car4.year + " " + car4.color));
cars.Add((car5.model + " " + car5.year + " " + car5.color));

Console.WriteLine("Count: " + cars.Count);
//Console.WriteLine("Capacity: " + cars.Capacity);

foreach (string a in cars)
    Console.WriteLine(a);

Console.ReadLine();

#endregion

//Main historie
/*

void Text(string text, int time = 50)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
Text ("Welcome to A Literal Dealership");
Console.WriteLine("");

Car toyota_01 = new Car();

//Do you need help loop
while (true)
{
    
Text ("Do you need any help?");
Console.WriteLine("");
string answer = Console.ReadLine();

if (answer == "yes")
{
    break;
}

if (answer == "no")
{
    Thread.Sleep(5000);
}
}

    Text ("Perfect, ill be with you right away");
Console.WriteLine("");

Thread.Sleep(3000);
Text ("What car are you intrested in, we got BMW, Audi, Volkswagen, Porsche, Opel and Mercedes");
Console.WriteLine("");
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
while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            //Car myNewCar = dealer.buy(...);
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }
}
*/
#endregion