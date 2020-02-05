using System;

namespace inClassFour
{
    class Program
    {
        string color = "white";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Console.WriteLine(myObj1.color);

            Car myObj2 = new Car();
            Console.WriteLine(myObj2.color);

            MyClass myObj3 = new MyClass();
            myObj3.fullThrottle();


            CarDetails Ford = new CarDetails();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            CarDetails Opel = new CarDetails();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            CarCar Fords = new CarCar("Mustang", "Red", 1969);
            Console.WriteLine(Fords.color + " " + Fords.year + " " + Fords.model);


            // Create a myCar object
            Mustang myCar = new Mustang();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);


        }
    }

    class Car
    {
        public string color = "red";
    }

    class MyClass
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }


    class CarDetails
    {
        public string model;
        public string color;
        public int year;

    }


    class CarConstructor
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public CarConstructor()
        {
            model = "Mustang"; // Set the initial value for model
        }
    }


    class CarCar
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public CarCar(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Mustang : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
}



class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}


