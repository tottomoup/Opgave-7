public class Sell
{
    public Car SellCar;
    public Sell()
    {
        void Text(string text, int time = 1) //change to 50
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(time);
            }
        }

        Text("So what car is it you want to sell?");
        Console.WriteLine(" ");
        string Answer = Console.ReadLine();

        Text("What year is the " + Answer + " from");
        Console.WriteLine(" ");
        string year = Console.ReadLine();

        Text("You can get money for the " + Answer + " from " + year);
        Console.WriteLine(" ");
        Console.ReadLine();

        SellCar = new Car(Answer, year, 2022, 123);
    }
}