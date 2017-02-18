/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections;

namespace VisitorPattern
{
    /// <summary>
    /// 如果系统有比较稳定的数据结构，而又有易于变化的算法时，可以考虑使用访问者模式
    /// 将有关元素对象的访问行为集中到一个访问者对象中，易于增加或修改访问操作，避免污染元素对象
    /// </summary>

    // 抽象数据元素类
    public abstract class Element
    {
        public abstract void Accept(Vistor vistor);
        public abstract void Print();
    }

    // 具体数据元素A
    public class ElementA : Element
    {
        public override void Accept(Vistor vistor)
        {
            vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("Element A.\n");
        }
    }

    // 具体数据元素B
    public class ElementB : Element
    {
        public override void Accept(Vistor vistor)
        {
            vistor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("Element B.\n");
        }
    }

    // 数据元素清单类
    public class ElementList
    {
        private ArrayList _elements = new ArrayList();
        public ArrayList elements { get { return _elements; } }

        public ElementList()
        {
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                int ranNum = ran.Next(0, 2);    // 随机生成元素列表
                if (ranNum > 0) elements.Add(new ElementA());
                else elements.Add(new ElementB());
            }
        }
    }

    // 访问者接口
    public interface Vistor
    {
        /// <summary>
        /// 如果增加数据元素，在这里增加访问操作
        /// </summary>

        void Visit(ElementA e);
        void Visit(ElementB e);
    }

    // 访问者1
    public class ConcreteVistor1 : Vistor
    {
        public void Visit(ElementA e)
        {
            Console.WriteLine("ConcreteVistor1.Visit ElementA:");
            e.Print();
        }

        public void Visit(ElementB e)
        {
            Console.WriteLine("ConcreteVistor1.Visit ElementB:");
            e.Print();
        }
    }

    // 访问者2
    public class ConcreteVistor2 : Vistor
    {
        public void Visit(ElementA e)
        {
            Console.WriteLine("ConcreteVistor2.Visit ElementA:");
            e.Print();
        }

        public void Visit(ElementB e)
        {
            Console.WriteLine("ConcreteVistor2.Visit ElementB:");
            e.Print();
        }
    }
}
