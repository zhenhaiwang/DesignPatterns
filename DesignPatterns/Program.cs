/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

//using SimpleFactory;
//using FactoryMethod;
//using AbstractFactory;
//using SingletonPattern;
//using ObserverPattern;
//using StrategyPattern;
//using StatePattern;
//using DecoratorPattern;
using CommandPattern;

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
            //BlueCatFactory bcf = new BlueCatFactory();
            //LittleCat cat = bcf.CreatLittleCat("");
            //cat.PrintName();

            //ObserverPattern
            //ConcreteSubject subject = new ConcreteSubject();
            //ConcreteObserver observer = new ConcreteObserver(subject);
            //subject.SetData("Data is changed!");
            //observer.Destroy();

            //StrategyPattern
            //Addition addition = new Addition();
            ////Multiplication multiplication = new Multiplication();
            //Calculator calculator = new Calculator(addition);
            //int result = calculator.Compute(10, 5);
            //Console.WriteLine(result.ToString());

            //StatePattern
            //PlayerController controller = new PlayerController(7);
            //while (true)
            //{
            //    ConsoleKeyInfo input = Console.ReadKey();
            //    switch (input.KeyChar)
            //    {
            //        case 'A':
            //            controller.PressA();
            //            break;
            //        case 'B':
            //            controller.PressB();
            //            break;
            //        case 'C':
            //            controller.PressC();
            //            break;
            //        case 'Q':
            //            return;
            //    }
            //}

            //DecoratorPattern
            //Component blackCoffee = new BlackCoffee();
            //blackCoffee =
            //    new Sugar(                              //4.再加糖
            //        new Milk(                           //3.再加牛奶
            //            new Sugar(                      //2.加糖
            //                new Milk(blackCoffee))));   //1.加牛奶
            //blackCoffee.Print();

            //CommandPattern
            RemoteController controller = new RemoteController();
            Light light = new Light();
            TV tv = new TV();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            controller.SetCommand(lightOn, lightOff);
            controller.ClickOn();
            controller.ClickOff();

            TVOnCommand tvOn = new TVOnCommand(tv);
            TVOffCommand tvOff = new TVOffCommand(tv);
            controller.SetCommand(tvOn, tvOff);
            controller.ClickOn();
            controller.ClickOff();

            Console.Read();
        }
    }
}
