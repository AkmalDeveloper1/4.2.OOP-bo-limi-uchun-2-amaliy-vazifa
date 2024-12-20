using System;
using OOP_Car;

class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car
        (
            model: "Mercedes benz W124 E500",
            year: 1993,
            price: 865_636_200m,
            carSpeed: 250m
        );

        Console.WriteLine(car.GetCarInfo());

        int year = 2024;
        decimal depreciatedPrice = car.CalculateDepreciation(year);
        Console.WriteLine($"{year} - yildagi narx : {depreciatedPrice} so'm");

        year = 2000;
        depreciatedPrice = car.CalculateDepreciation(year);
        Console.WriteLine($"{year} - yildagi narx : {depreciatedPrice} so'm");

        year = 1995;
        depreciatedPrice = car.CalculateDepreciation(year);
        Console.WriteLine($"{year} - yildagi narx : {depreciatedPrice} so'm");
    }
}