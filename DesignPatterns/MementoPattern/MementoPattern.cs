/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections.Generic;

namespace MementoPattern
{
    //联系人类(数据)
    public class ContactPerson
    {
        public string name { get; set; }
        public string number { get; set; }
    }

    //备忘录类(还原点)
    public class Memento
    {
        public List<ContactPerson> contactPersonList;

        public Memento(List<ContactPerson> persons)
        {
            contactPersonList = persons;
        }
    }

    //管理类(多个还原点)
    public class Caretaker
    {
        //key=时间戳, value=备忘录
        public Dictionary<string, Memento> contactMementoDic { get; set; }

        public Caretaker()
        {
            contactMementoDic = new Dictionary<string, Memento>();
        }
    }

    //发起人类
    public class Originator
    {
        //当前内部状态
        public List<ContactPerson> contactPersonList { get; set; }

        public Originator(List<ContactPerson> persons)
        {
            contactPersonList = persons;
        }

        //创建备忘录  
        public Memento CreateMemento()
        {
            //这里应该用序列化的方式传递深拷贝，new List的方式传递的是浅拷贝，如果ContactPerson包含非string的引用类型就会出问题。
            return new Memento(new List<ContactPerson>(contactPersonList));
        }

        //还原到某个备忘录状态
        public void RestoreMemento(Memento memento)
        {
            if (memento != null)
            {
                // 这里也应该用序列化的方式传递深拷贝
                contactPersonList = memento.contactPersonList;
            }
        }

        public void Print()
        {
            int length = contactPersonList.Count;
            Console.WriteLine("联系人列表中有{0}个人，他们是: ", length);
            for (int i = 0; i < length; i++)
                Console.WriteLine("姓名: {0}, 联系方式: {1}", contactPersonList[i].name, contactPersonList[i].number);
        }
    }
}
