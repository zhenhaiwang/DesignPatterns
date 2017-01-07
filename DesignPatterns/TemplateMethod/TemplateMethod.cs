/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace TemplateMethod
{
    //算法模板(骨架)
    public abstract class AbstractMethod
    {
        public void Execute()
        {
            //算法执行步骤
            Operation1();   //子类实现
            Operation2();   //子类可选实现
            Operation3();   //通用算法，父类实现
        }

        protected abstract void Operation1();

        protected virtual void Operation2()
        {
            //do something or not.
        }

        protected void Operation3()
        {
            Console.WriteLine("Do Operation3() in AbstractMethod.");
        }
    }

    //具体算法
    public class ConcreteMethod1 : AbstractMethod
    {
        protected override void Operation1()
        {
            Console.WriteLine("Do Operation1() in ConcreteMethod1.");
        }
    }

    public class ConcreteMethod2 : AbstractMethod
    {
        protected override void Operation1()
        {
            Console.WriteLine("Do Operation1() in ConcreteMethod2.");
        }

        protected override void Operation2()
        {
            //base.Operation2();
            Console.WriteLine("Do Operation2() in ConcreteMethod2.");
        }
    }
}
