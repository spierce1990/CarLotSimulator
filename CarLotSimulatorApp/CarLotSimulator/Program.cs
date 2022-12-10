using System;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)


        {
            Car car1 = new Car();
            car1.Make = "Pontiac";
            car1.Model = "G6";
            car1.Year = "2007";
            car1.IsDrivable = "yes";
            car1.EngineNoise = "beep";
            Car Car2 = new Car() { Make = "bmw", Model = "5", Year = "2022", IsDrivable = "yes", EngineNoise = "bang" };
            Car Car3 = new Car() { Make = "volvo", Model = "volvo 9", Year = "2024", IsDrivable = "yes", EngineNoise = "boom" };

            Console.WriteLine($"The maker of the car is {car1.Make}");
            Console.WriteLine($"The model of the car is {car1.Model}");
            Console.WriteLine($"The  year  of the car is {car1.Year}");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(Car2.Make);
            Console.WriteLine(Car2.Model);
            Console.WriteLine(Car2.Year);

            Console.WriteLine("-----------------------------------------");

            car1.CarHOnk();
            Car2.CarHOnk();
            Car3.CarHOnk();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
