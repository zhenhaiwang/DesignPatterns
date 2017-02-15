/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary>
    /// 主要用来创建组合结构，封装复杂对象的创建过程，允许对象通过多个过程创建，并可以改变过程的实现
    /// 类似模板方法模式，一个封装算法的执行过程，一个封装复杂对象的创建过程
    /// Director规定了创建一个对象所需要的步骤和次序，Builder则提供了一系列完成具体步骤的抽象方法，ConcreteBuilder给出了方法的具体实现，是对象的直接创建者
    /// </summary>

    // 抽象生成器类
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetFinalProduct();
    }

    // 具体生成器1
    public class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA-Builder1");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB-Builder1");
        }

        public override Product GetFinalProduct()
        {
            return _product;
        }
    }

    // 具体生成器2
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA-Builder2");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB-Builder2");
        }

        public override Product GetFinalProduct()
        {
            return _product;
        }
    }

    // 产品类
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Print()
        {
            Console.WriteLine("Product Parts: ");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    // Builder uses a complex series of steps
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
