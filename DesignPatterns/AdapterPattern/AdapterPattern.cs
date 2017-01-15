/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器模式: 接口转换，解决新旧接口不兼容问题
    /// </summary>

    public interface Enumeration    //枚举器接口
    {
        bool HasMoreElements();
        object NextElement();
    }

    public interface Iteration      //迭代器接口
    {
        bool HasNext();
        object Next();
        void Remove(object obj);
    }

    //将 枚举器接口 适配为 迭代器接口
    public class Adapter : Iteration
    {
        private Enumeration _enumeration;

        public Adapter(Enumeration enumeration)
        {
            _enumeration = enumeration;
        }

        public bool HasNext()
        {
            return _enumeration.HasMoreElements();
        }

        public object Next()
        {
            return _enumeration.NextElement();
        }

        public void Remove(object obj)
        {
            throw new NotSupportedException();  //枚举器不支持此方法，抛出运行时异常
        }
    }

    //具体枚举器
    public class ConcreteEnumeration : Enumeration
    {
        public bool HasMoreElements()
        {
            Console.WriteLine("HasMoreElements() return false.");
            return false;
        }

        public object NextElement()
        {
            Console.WriteLine("NextElement() return null.");
            return null;
        }
    }

    //具体迭代器
    public class ConcreteIteration : Iteration
    {
        public bool HasNext()
        {
            Console.WriteLine("HasNext() return false.");
            return false;
        }

        public object Next()
        {
            Console.WriteLine("Next() return null.");
            return null;
        }

        public void Remove(object obj)
        {
            Console.WriteLine("Remove().");
        }
    }
}
