/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace FacadePattern
{
    /// <summary>
    /// 提供整洁而统一的接口，用来访问子系统中的一群接口，将客户的实现从子系统中解耦
    /// </summary>

    //外观类
    public class Facade
    {
        private SubSystem1 _sys1;
        private SubSystem2 _sys2;
        private SubSystem3 _sys3;

        public Facade(SubSystem1 sys1, SubSystem2 sys2, SubSystem3 sys3)
        {
            _sys1 = sys1;
            _sys2 = sys2;
            _sys3 = sys3;
        }

        public void Execute()
        {
            _sys1.Method1();
            _sys2.Method2();
            _sys2.Method3();
            _sys3.Method4();
            _sys3.Method5();
            _sys3.Method6();
        }
    }

    //各个子系统
    public class SubSystem1
    {
        public void Method1()
        {
            Console.WriteLine("Do method 1.");
        }
    }

    public class SubSystem2
    {
        public void Method2()
        {
            Console.WriteLine("Do method 2.");
        }

        public void Method3()
        {
            Console.WriteLine("Do method 3.");
        }
    }

    public class SubSystem3
    {
        public void Method4()
        {
            Console.WriteLine("Do method 4.");
        }

        public void Method5()
        {
            Console.WriteLine("Do method 5.");
        }

        public void Method6()
        {
            Console.WriteLine("Do method 6.");
        }
    }
}
