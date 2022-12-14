public class CarDealer
{


    List<Car> availebleCars;

    public CarDealer()
    {
        availebleCars = new List<Car>();
        Car car1 = new Car("Volkswagen", "Blue", 2023, 476538);
        Car car2 = new Car("Opel", "Yellow", 2019, 154675);
        Car car3 = new Car("Porsche", "Red", 2022, 1356789);
        Car car4 = new Car("BMW", "MattBlack", 2023, 456789);
        Car car5 = new Car("Mercedes", "White", 2021, 335287);
        Car car6 = new Car("Audi", "Black", 2020, 230605);
        availebleCars.Add(car1);
        availebleCars.Add(car2);
        availebleCars.Add(car3);
        availebleCars.Add(car4);
        availebleCars.Add(car5);
        availebleCars.Add(car6);
    }

    public Car BuyCar(int id){
        Car specificCar = availebleCars[id];
        availebleCars.RemoveAt(id);
        return specificCar;
    }

    public void ShowCars(){
        foreach(Car carinshop in availebleCars){
            carinshop.ShowCar();
        }
    }
}

