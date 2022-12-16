public class Sell{
    public Sell(){
        void Text(string text, int time = 1) //change to 50
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
Text("abous");
Console.ReadLine();
    }
}