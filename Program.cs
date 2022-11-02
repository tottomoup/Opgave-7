#region Assignment

new Car();

Car myObj1 = new Car();
Car myObj2 = new Car();
Console.WriteLine(myObj1.color);
Console.WriteLine(myObj2.color);



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