//Main historie
void Text(string text, int time = 1) // change to 50
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
Text("Welcome to A Literal Dealership");
Console.WriteLine("");

//Do you need help loop
while (true)
{

    Text("Do you need any help?");
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

Text("Perfect, ill be with you right away");

Thread.Sleep(3000);

//List of cars and CarDealer class
Console.WriteLine("\n");
Text("What car are you intrested in, we got:");
Console.WriteLine(" ");

CarDealer BenDover = new CarDealer();
BenDover.ShowCars();

//Choose a car
String IdCar = Console.ReadLine();
int CarId = Convert.ToInt32(IdCar) - 1;
Car Selected = BenDover.BuyCar(CarId);

Selected.ShowCar();

Console.ReadLine();
}
    Text ("Do you want to Buy or Sell?");
    Console.WriteLine(" ");
    string BuyOrSell = Console.ReadLine();
    if(BuyOrSell == "Buy"){
        Buy b = new Buy();
    }
    if(BuyOrSell == "Sell"){
        Sell s = new Sell();
    }
#endregion