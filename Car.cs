#region Constructors example (den vi går videre med)
public class Car
{
    public string model;
    public string color;
    public int year;
    public int price;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear, int modelPrice)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
        price = modelPrice;
    }

    public void ShowCar()
    {
        Console.WriteLine("Car " + model + ", " + color + ", " + year + ", " + price);
    }
}

#endregion
