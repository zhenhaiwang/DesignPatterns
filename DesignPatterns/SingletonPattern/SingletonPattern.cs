/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

namespace SingletonPattern
{
    //多线程环境下要考虑线程安全问题，同步访问，加锁
    public class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        //注意！构造函数要声明为私有
        private Singleton() { }
    }
}
