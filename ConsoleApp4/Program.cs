using System;

namespace ConsoleApp4
{
    class Program
    {
        //Constructors can also take parameters, which is used to initialize fields.
        class Car
        {
            public string model;
            public string color;
            public int year;

            //The following example adds a string modelName parameter to the constructor
            // Create a class constructor with a parameter
            public Car(string modelName, string carColor, int carYear)
            {
                model = modelName;
                color = carColor;
                year = carYear;

            }

            static void Main(string[] args)
            {
                Car BMW = new Car("320i", "midnight", 2008);

                Console.WriteLine(BMW.model +" "+ BMW.color +" "+ BMW.year);
            }
        }
    }
}
