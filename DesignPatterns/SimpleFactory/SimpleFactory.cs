/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace SimpleFactory
{
    //动物接口
    public interface Animal
    {
        void PrintName();
    }

    //具体动物
    public class Cat : Animal
    {
        public void PrintName()
        {
            Console.WriteLine("Cat");
        }
    }

    public class Dog : Animal
    {
        public void PrintName()
        {
            Console.WriteLine("Dog");
        }
    }

    //简单工厂
    public class Factory
    {
        public static Animal CreatAnimal(string type)
        {
            Animal animal = null;

            if (type == "Cat")
            {
                animal = new Cat();
            }
            else if (type == "Dog")
            {
                animal = new Dog();
            }

            return animal;
        }
    }
}
