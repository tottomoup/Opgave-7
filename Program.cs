#region Assignment

#region Constructer and liste
//Constructors example (den vi går videre med)

#endregion



//Main historie
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

Thread.Sleep(3000);

Console.WriteLine("\n");
Text ("What car are you intrested in, we got:");
Console.WriteLine(" ");


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
#endregion
            return;
        default:
            return;
    }
}
*/
#endregion