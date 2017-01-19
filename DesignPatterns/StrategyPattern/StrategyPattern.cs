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

    //计算器类
    public class Calculator
    {
        private ComputeStrategy _strategy;

        public Calculator(ComputeStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Compute(int x, int y)
        {
            return _strategy.compute(x, y);
        }
    }
}
