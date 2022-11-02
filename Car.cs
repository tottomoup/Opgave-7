public class Car
{
    public static List<string> Possibles = new List<string>(){
        "Toyota", "BMW", "AUDI"
    };

    public string color = "red";
    public string Brand;

    public Car(string brand){
        Brand = brand;
    }
}