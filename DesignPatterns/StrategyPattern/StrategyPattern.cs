/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

namespace StrategyPattern
{
    //计算策略接口
    public interface ComputeStrategy
    {
        int compute(int x, int y);
    }

    //抽象计算器类
    public abstract class AbstractCalculator
    {
        protected ComputeStrategy strategy;

        public AbstractCalculator() { }

        public abstract int Compute(int x, int y);
    }

    //具体计算策略类
    public class Addition : ComputeStrategy
    {
        public int compute(int x, int y)
        {
            return x + y;
        }
    }

    public class Multiplication : ComputeStrategy
    {
        public int compute(int x, int y)
        {
            return x * y;
        }
    }

    //具体计算器类
    public class Calculator : AbstractCalculator
    {
        public Calculator(ComputeStrategy strategy)
        {
            this.strategy = strategy;
        }

        public override int Compute(int x, int y)
        {
            return strategy.compute(x, y);
        }
    }
}
