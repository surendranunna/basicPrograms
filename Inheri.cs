using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    //example for the mutl-level of inheritance
    class Inheri
    {
        static void Main(string[] args)
        {
            Scooter sc = new Scooter();
            sc.ScooterType();

            Car c = new Car();
            c.CarType();

            Console.ReadKey();
        }
    }
    // Base Class
    class Tyre
    {
        public void TyreType()
        {
            Console.WriteLine("This is Tubeless Tyre");
        }
    }
    // Child Class 1
    class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter Color is Red");
            TyreType();
        }
    }
    //Child Class 2
    class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car Type : Ferrari");
            TyreType();
        }
    }
}


