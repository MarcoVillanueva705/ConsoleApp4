﻿using System;

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
//Why Access Modifiers?

//To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private



//By default, all members of a class are private if you don't specify an access modifier:



//class Car

//{

//    string model;  // private

//    string year;   // private

//}



//Private variables can only be accessed within the same class.

//Sometimes we need to access them - and it can be done with properties.



class Person

{

    private string name; //field

    public string Name //property


    //Automatic Properties (shorthand)
    //you do not have to define the field 
    //for the property, and you only have to 
    //write get; and set; inside the property.
    {
        get; set;
    }  
    //longhand version of the above looks like this:
    //public string Name   // property
    //  {
    //    get { return name; }
    //set { name = value; }
    //  }
}



//    static void Main(string[] args)

//    {

//        Person myObj = new Person();

//        Console.WriteLine(myObj.name);

//    }

//}



//We can use the Name property to access and update the private field of the Person class



//Why Encapsulation?

//*Better control of class members (reduce the possibility of yourself (or others) to mess up the code)

//*Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)

//*Flexible: the programmer can change one part of the code without affecting other parts

//*Increased security of data
