using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using SimpleFactory;
//using FactoryMethod;
using AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleFactory
            //Animal animal = Factory.CreatAnimal("Cat");
            //animal.PrintName();

            //FactoryMethod
            //CatFactory cf = new CatFactory();
            //Animal animal = cf.CreatAnimal("");
            //animal.PrintName();

            //AbstractFactory
            BlueCatFactory bcf = new BlueCatFactory();
            LittleCat cat = bcf.CreatLittleCat("");
            cat.PrintName();

            Console.Read();
        }
    }
}
