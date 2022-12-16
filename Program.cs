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

Console.WriteLine("\n");
Text("What car are you intrested in, we got:");
Console.WriteLine(" ");

CarDealer BenDover = new CarDealer();
BenDover.ShowCars();

//prøver at lave en metode for hvordan brugeren kan vælge bilen
String IdCar = Console.ReadLine();
int CarId = Convert.ToInt32(IdCar) - 1;
Car Noget = BenDover.BuyCar(CarId);

Noget.ShowCar();

Console.ReadLine();
#endregion