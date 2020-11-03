using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Carlot lot = new Carlot();

            
            Car bmw = new Car();
            lot.CarList.Add(bmw);
            bmw.Year = 2003;
            bmw.Make = "bmw";
            bmw.Model = "328i";
            bmw.EngineNoise = "Waaw!";
            bmw.HonkNoise = "Beeeep";
            bmw.IsDriveable = true;

            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            Car celica = new Car() { Year = 1999, Make = "Toyota", Model = "Celica", EngineNoise = "N/A", HonkNoise = "Whomp" };
            lot.CarList.Add(celica);


            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            Car Titan = new Car(2020, "Nissan", "Titan", "N/A", "Whaaaank");
            lot.CarList.Add(Titan);

            Titan.MakeEngineNoise();
            Titan.MakeHonkNoise();

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year :{car.Year}, Make: {car.Make} Model: {car.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
