using System;

namespace ConsoleApp4
{
    class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;


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
