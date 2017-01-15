/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections;

namespace CompositePattern
{
    /// <summary>
    /// 树形结构，组合包含组件，组件分为两种: 组合 和 叶节点
    /// 把相同的操作应用在 组合 和 个别 对象上，忽略 对象组合 和 个别对象 的差别
    /// 例如: 菜单 和 菜单项
    /// </summary>

    //菜单组件接口
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }

    //菜单项(叶节点)，不支持 Add Remove GetChild 方法
    public class MenuItem : MenuComponent
    {
        private string _name;

        public MenuItem(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override void Print()
        {
            Console.WriteLine("This is a MenuItem " + _name + ".");
        }
    }

    //菜单(组合)
    public class Menu : MenuComponent
    {
        private ArrayList _menuComponents = new ArrayList();
        private string _name;

        public Menu(string name)
        {
            _name = name;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            if (index >= 0 && index < _menuComponents.Count)
                return _menuComponents[index] as MenuComponent;
            throw new IndexOutOfRangeException();
        }

        public override string GetName()
        {
            return _name;
        }

        public override void Print()
        {
            Console.WriteLine("This is a Menu " + _name + ".");
            
            IEnumerator iEnumerator = _menuComponents.GetEnumerator();  //遍历，打印菜单和所有子菜单/菜单项
            while (iEnumerator.MoveNext())
            {
                MenuComponent component = iEnumerator.Current as MenuComponent;
                component.Print();
            }
        }
    }
}
