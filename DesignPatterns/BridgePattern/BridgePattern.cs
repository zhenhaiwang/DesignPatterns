/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

namespace BridgePattern
{
    /// <summary>
    /// 桥接模式是策略模式的扩展
    /// 策略模式: 行为接口 (被调用的行为可变)
    /// 桥接模式: 抽象接口 + 行为接口 (调用者和被调用的行为皆可变)
    /// </summary>

    //计算策略接口
    public interface ComputeImplementor
    {
        int compute(int x, int y);
    }

    //具体计算策略
    public class Addition : ComputeImplementor
    {
        public int compute(int x, int y)
        {
            return x + y;
        }
    }

    public class Multiplication : ComputeImplementor
    {
        public int compute(int x, int y)
        {
            return x * y;
        }
    }

    //抽象计算器类
    public abstract class CalculatorAbstraction
    {
        public ComputeImplementor strategy { set; protected get; }

        public abstract int Compute(int x, int y);
    }

    //具体计算器
    public class Calculator : CalculatorAbstraction
    {
        public override int Compute(int x, int y)
        {
            return strategy.compute(x, y);
        }
    }
}
