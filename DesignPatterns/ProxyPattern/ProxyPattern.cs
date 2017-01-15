/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace ProxyPattern
{
    //远程代理接口
    public interface ProxyInterface
    {
        void Request();
    }

    //被代理的真实业务类
    public class Subject : ProxyInterface
    {
        public void Request()
        {
            Console.WriteLine("Do Request.");
        }
    }


    //远程代理类
    public class Proxy : ProxyInterface
    {
        private Subject _subject;   //被代理的真实业务对象

        public static Proxy RegisterProxy(string url)   //注册代理服务
        {
            if (!string.IsNullOrEmpty(url))
                return new Proxy();
            return null;
        }

        private Proxy()
        {
            _subject = new Subject();
        }

        private void PreRequest()
        {
            Console.WriteLine("Pre Request.");
        }

        public void Request()
        {
            PreRequest();
            _subject.Request(); //调用真正业务对象的方法
            EndRequest();
        }

        private void EndRequest()
        {
            Console.WriteLine("End Request.");
        }
    }
}
