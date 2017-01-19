/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

namespace PrototypePattern
{
    /// <summary>
    /// 创建型模式: 克隆创建(深克隆、浅克隆)
    /// </summary>

    //类成员
    public class Member
    {
        //Has nothing.
    }

    //原型接口
    public interface Prototype
    {
        Prototype Clone(bool deep);
    }

    //具体实例
    public class ConcretePrototype : Prototype
    {
        public Member member { get; set; }

        public Prototype Clone(bool deep)
        {
            if (deep)
            {//深克隆(创建新成员对象，也可以通过序列化/反序列化创建)
                ConcretePrototype prototype = MemberwiseClone() as ConcretePrototype;
                prototype.member = new Member();
                return prototype;
            }
            else
            {//浅克隆(直接拷贝)
                return MemberwiseClone() as ConcretePrototype;
            }
        }
    }
}
