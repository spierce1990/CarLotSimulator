
using CarLotSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
        }
        public Car(string make, string model, string year, string engineNoise, string isDrivable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDrivable = isDrivable;
            EngineNoise = engineNoise;


        }

        public string Make { get; set; } = "Car make";
        public string Model { get; set; } = "Car model";
        public string Year { get; set; } = "Car year";
        public string IsDrivable { get; set; } = "Car isDrivable";
        public string EngineNoise { get; set; }

        public void CarHOnk() { Console.WriteLine($" Car {Make} goes honk honk"); }
        public void EngineNoises() { Console.WriteLine("Car says honkie honkie"); }
    }
}
/*  public Car(string make, string model, string year)

   Make = make;
    Model = model;
    Year = year;*/

//TODO

//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property


//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car
