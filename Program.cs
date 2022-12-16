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
