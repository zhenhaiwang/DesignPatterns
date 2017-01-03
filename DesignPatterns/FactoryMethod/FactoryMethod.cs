/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace FactoryMethod
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

    //工厂接口
    public interface Factory
    {
        Animal CreatAnimal(string type);
    }

    //具体工厂
    public class CatFactory : Factory
    {
        public Animal CreatAnimal(string type)
        {
            return new Cat();
        }
    }

    public class DogFactory : Factory
    {
        public Animal CreatAnimal(string type)
        {
            return new Dog();
        }
    }
}
