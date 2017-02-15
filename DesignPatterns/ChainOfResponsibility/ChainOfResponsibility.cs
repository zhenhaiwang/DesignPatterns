/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 解耦请求的发送者与接收者
    /// 职责链中的每个对象扮演处理器，并且有一个后继对象。请求沿着职责链进行传递，直到有一个对象处理它
    /// </summary>

    // 抽象处理器类
    public abstract class Handler
    {
        public Handler next { set; get; }

        public abstract void HandleRequest(string request);
    }

    // 具体处理器1
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("Handler1"))
                Console.WriteLine("{0} handled request {1}", GetType().Name, request);
            else if (next != null)
                next.HandleRequest(request);
        }
    }

    // 具体处理器2
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("Handler2"))
                Console.WriteLine("{0} handled request {1}", GetType().Name, request);
            else if (next != null)
                next.HandleRequest(request);
        }
    }

    // 具体处理器3
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("Handler3"))
                Console.WriteLine("{0} handled request {1}", GetType().Name, request);
            else if (next != null)
                next.HandleRequest(request);
        }
    }
}
