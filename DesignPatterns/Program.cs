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
//using CommandPattern;
using TemplateMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.SimpleFactory
            //Animal animal = Factory.CreatAnimal("Cat");
            //animal.PrintName();

            //2.FactoryMethod
            //CatFactory cf = new CatFactory();
            //Animal animal = cf.CreatAnimal("");
            //animal.PrintName();

            //3.AbstractFactory
            //BlueCatFactory bcf = new BlueCatFactory();
            //LittleCat cat = bcf.CreatLittleCat("");
            //cat.PrintName();

            //4.SingletonPattern
            //Singleton.instance.Print();

            //5.ObserverPattern
            //ConcreteSubject subject = new ConcreteSubject();
            //ConcreteObserver observer = new ConcreteObserver(subject);
            //subject.SetData("Data is changed!");
            //observer.Destroy();

            //6.StrategyPattern
            //Addition addition = new Addition();
            ////Multiplication multiplication = new Multiplication();
            //Calculator calculator = new Calculator(addition);
            //int result = calculator.Compute(10, 5);
            //Console.WriteLine(result.ToString());

            //7.StatePattern
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

            //8.DecoratorPattern
            //Component blackCoffee = new BlackCoffee();
            //blackCoffee =
            //    new Sugar(                              //4.再加糖
            //        new Milk(                           //3.再加牛奶
            //            new Sugar(                      //2.加糖
            //                new Milk(blackCoffee))));   //1.加牛奶
            //blackCoffee.Print();

            //9.CommandPattern
            //RemoteController controller = new RemoteController();
            //Light light = new Light();
            //TV tv = new TV();

            //LightOnCommand lightOn = new LightOnCommand(light);
            //LightOffCommand lightOff = new LightOffCommand(light);
            //controller.SetCommand(lightOn, lightOff);
            //controller.ClickOn();
            //controller.ClickOff();

            //TVOnCommand tvOn = new TVOnCommand(tv);
            //TVOffCommand tvOff = new TVOffCommand(tv);
            //controller.SetCommand(tvOn, tvOff);
            //controller.ClickOn();
            //controller.ClickOff();

            //10.TemplateMethod
            ConcreteMethod1 method1 = new ConcreteMethod1();
            Console.WriteLine("Execute method1");
            method1.Execute();
            ConcreteMethod2 method2 = new ConcreteMethod2();
            Console.WriteLine("\nExecute method2");
            method2.Execute();

            Console.Read();
        }
    }
}
