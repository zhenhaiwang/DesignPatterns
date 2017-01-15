/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    //迭代器接口
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }

    //具体迭代器(数组)
    public class ArrayIterator : Iterator
    {
        private object[] _data;
        private int position = 0;

        public ArrayIterator(object[] data)
        {
            _data = data;
        }

        public bool HasNext()
        {
            if (position >= _data.Length || _data[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            return _data[position++];
        }
    }

    //具体迭代器(泛型链表)
    public class ArrayListIterator : Iterator
    {
        private List<object> _data;
        private int position = 0;

        public ArrayListIterator(List<object> data)
        {
            _data = data;
        }

        public bool HasNext()
        {
            if (position >= _data.Count)
                return false;
            else
                return true;
        }

        public object Next()
        {
            return _data[position++];
        }
    }

    //空迭代器(为了解耦具体迭代器类型和业务逻辑实现)
    public class NullIterator : Iterator
    {
        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return null;
        }
    }

    //聚合数据接口
    public interface Aggregate
    {
        Iterator CreateIterator();
    }

    //具体数据
    public class NameData : Aggregate
    {
        private object[] _array;

        public NameData()
        {
            _array = new object[3] { "cat", "dog", "bird" };
        }

        public Iterator CreateIterator()
        {
            return new ArrayIterator(_array);
        }
    }

    public class ColorData : Aggregate
    {
        private List<object> _array;

        public ColorData()
        {
            _array = new List<object>();
            _array.Add("white");
            _array.Add("black");
            _array.Add("gray");
        }

        public Iterator CreateIterator()
        {
            return new ArrayListIterator(_array);
        }
    }
}
