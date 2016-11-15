using AbstractFactorySample;
using AbstractFactorySample2;
using AbstractFactorySample2.ConcreteFactories;
using BuilderSample.Builders.Concrete;
using BuilderSample.Directors.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start testing Abstract Factory Pattern");
            //Trying out Abstract Factory
            IStampingEquipment equipment = new StampingSportsEquipment();
            IDoor door = equipment.StampDoor();
            IHood hood = equipment.StampHood();
            IWheel wheel  = equipment.StampWheel();
            Console.WriteLine("End testing Abstract Factory Pattern");

            Console.WriteLine();

            Console.WriteLine("Start testing Abstract Factory Pattern 2 ");
            //Trying out Abstract Factory again
            ICarFactory fordFactory = new FordFactory();
            ISedan sedan= fordFactory.CreateSedan();
            ISUV suv = fordFactory.CreateSUV();
            AbstractFactorySample2.IConvertible convertible = fordFactory.CreateConvertible();
            sedan.PrintName();
            suv.PrintName();
            convertible.PrintName();
            Console.WriteLine("End testing Abstract Factory Pattern 2");

            Console.WriteLine();

            //Trying out Builder factory again
            Console.WriteLine("Start testing Builder Pattern");
            var director1 = new EverythingDirector(new BasicCoreBuilder(), new BasicMeatBuilder(), new BasicVeggieBuilder());
            var director2 = new VeggieDirector(new BasicCoreBuilder(), new FancyVeggieBuilder());
            Console.WriteLine(director1.MakePizza());
            Console.WriteLine(director2.MakePizza());
            Console.WriteLine("End testing Builder Pattern");


        }
    }
}
