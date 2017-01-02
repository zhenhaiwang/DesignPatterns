using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //大猫接口
    public interface LargeCat
    {
        void PrintName();
    }

    //具体大猫
    public class LargeBlueCat : LargeCat
    {
        public void PrintName()
        {
            Console.WriteLine("LargeBlueCat");
        }
    }

    public class LargeRedCat : LargeCat
    {
        public void PrintName()
        {
            Console.WriteLine("LargeRedCat");
        }
    }

    //小猫接口
    public interface LittleCat
    {
        void PrintName();
    }

    //具体小猫
    public class LittleBlueCat : LittleCat
    {
        public void PrintName()
        {
            Console.WriteLine("LittleBlueCat");
        }
    }

    public class LittleRedCat : LittleCat
    {
        public void PrintName()
        {
            Console.WriteLine("LittleRedCat");
        }
    }

    //抽象工厂接口(产品簇)
    public interface Factory
    {
        LargeCat CreatLargeCat(string color);
        LittleCat CreatLittleCat(string color);
    }

    //具体工厂
    public class BlueCatFactory : Factory
    {
        public LargeCat CreatLargeCat(string color)
        {
            return new LargeBlueCat();
        }

        public LittleCat CreatLittleCat(string color)
        {
            return new LittleBlueCat();
        }
    }

    public class RedCatFactory : Factory
    {
        public LargeCat CreatLargeCat(string color)
        {
            return new LargeRedCat();
        }

        public LittleCat CreatLittleCat(string color)
        {
            return new LittleRedCat();
        }
    }
}
