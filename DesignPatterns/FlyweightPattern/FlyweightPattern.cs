/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System.Collections;

namespace FlyweightPattern
{
    /// <summary>
    /// 享元(蝇量)模式
    /// 使用共享技术，支持系统中存在的大量的细粒度对象，而这些对象的大多数状态都可以转变为外部状态，主要目的是减小内存开销
    /// 1.例如游戏场景中存在的大量的树木，通常树木和数木之间只有尺寸和角度的不同
    /// 2.例如仅仅使用26个英文字母就可以表示一篇文档，文章中大量的英文字母之间只有尺寸、斜体和颜色等的不同
    /// </summary>

    // 抽象享元树木类
    public abstract class FlyweightTree
    {
        protected string _name = "tree";
        public string name { get { return _name; } }

        public float height = 3.0f;
        public float orientation = 0.0f;

        public override string ToString()
        {
            return _name + " (height: " + height.ToString() + ", orientation: " + orientation.ToString() + ")";
        }
    }

    // 杨树
    public class PoplarTree : FlyweightTree
    {
        public PoplarTree()
        {
            _name = "Poplar";
        }
    }

    // 柳树
    public class WillowTree : FlyweightTree
    {
        public WillowTree()
        {
            _name = "Willow";
        }
    }

    // 树木工厂类(共享池)
    public class FlyweightFactory
    {
        private Hashtable _trees = new Hashtable();

        public FlyweightFactory()
        {
            PoplarTree poplar = new PoplarTree();
            WillowTree willow = new WillowTree();
            _trees.Add(poplar.name, poplar);
            _trees.Add(willow.name, willow);
        }

        public FlyweightTree GetTree(string name)
        {
            return ((FlyweightTree)_trees[name]);
        }
    }
}
