//Mihnea Branch

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

//Buy or sell
while (true)
{
    Text ("Do you want to buy or sell?");
    Console.WriteLine(" ");
    string BuyOrSell = Console.ReadLine();
    if(BuyOrSell == "buy"){
        Buy b = new Buy();
        break;
    }
    if(BuyOrSell == "sell"){
        Sell s = new Sell();
        break;
    }
}