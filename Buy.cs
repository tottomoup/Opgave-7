public class Buy{
   public Buy(){
    void Text(string text, int time = 1) // change to 50
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
    Text ("Perfect, ill be with you right away");

Thread.Sleep(30); // change to 3000
Console.WriteLine(" ");
Text ("What car are you intrested in, we got:");
Console.WriteLine(".");

CarDealer BenDover = new CarDealer();
BenDover.ShowCars();

//Choose a car
String IdCar = Console.ReadLine();
int CarId = Convert.ToInt32(IdCar) - 1;
Car Selected = BenDover.BuyCar(CarId);

Selected.ShowCar();

Console.ReadLine();
   }
}
