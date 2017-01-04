/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 应用场景:
    /// 1.需要扩展一个类的功能，或者为一个类增加附加责任；
    /// 2.需要动态地为一个对象增加功能，并且可以动态地撤销这些功能；
    /// 3.需要增加由一些基本功能的排列组合而产生的具有一定规模的功能。
    /// 特点:
    /// 1.装饰者模式和继承的目的都是扩展对象的功能，但装饰者模式比继承更具有弹性；
    /// 2.组合代替继承；
    /// 3.对修改关闭，对扩展开放。
    /// </summary>
    
    //抽象组件类
    public abstract class Component
    {
        public abstract void Print();
    }

    //抽象装饰者类
    public abstract class Decorator : Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Print()
        {
            if (_component != null)
                _component.Print();
        }
    }

    //具体组件类
    public class BlackCoffee : Component    //黑咖啡
    {
        public override void Print()
        {
            Console.WriteLine("I'm Black Coffee with nothing.");
        }
    }

    public class WhiteCoffee : Component    //白咖啡
    {
        public override void Print()
        {
            Console.WriteLine("I'm WhiteC Coffee with nothing.");
        }
    }

    //具体装饰者(调料)
    public class Sugar : Decorator  //糖
    {
        public Sugar(Component component) : base(component)
        {
            //do something.
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Add Sugar.");
        }
    }

    public class Milk : Decorator   //牛奶
    {
        public Milk(Component component) : base(component)
        {
            //do something.
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Add Milk.");
        }
    }

    public class Salt : Decorator   //盐
    {
        public Salt(Component component) : base(component)
        {
            //do something.
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Add Salt.");
        }
    }
}
