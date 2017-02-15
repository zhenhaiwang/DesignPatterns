/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    /// <summary>
    /// 主要用于实现简单的语言，封装语法规则
    /// </summary>

    // 例子:中英文对照字典
    public static class ChineseEnglishDictionary
    {
        private static Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        static ChineseEnglishDictionary()
        {
            _dictionary.Add("this", "这");
            _dictionary.Add("is", "是");
            _dictionary.Add("an", "一个");
            _dictionary.Add("apple", "苹果");
        }

        public static string GetEnglish(string chinese)
        {
            return _dictionary[chinese];
        }
    }

    // 抽象表达式接口
    public interface IExpression
    {
        void Interpret(StringBuilder sb);
    }

    // 具体表达式类(文字)
    public class WordExpression : IExpression
    {
        private string _value;

        public WordExpression(string value)
        {
            _value = value;
        }

        public void Interpret(StringBuilder sb)
        {
            sb.Append(ChineseEnglishDictionary.GetEnglish(_value.ToLower()));
        }
    }

    // 具体表达式类(标点符号)
    public class SymbolExpression : IExpression
    {
        private string _value;

        public SymbolExpression(string value)
        {
            _value = value;
        }

        public void Interpret(StringBuilder sb)
        {
            switch (_value)
            {
                case ".":
                    sb.Append("。");
                    break;
            }
        }
    }

    // 中英文翻译器
    public static class Translator
    {
        public static string TranslateToChinese(string sentense)
        {
            StringBuilder sb = new StringBuilder();
            List<IExpression> expressions = new List<IExpression>();

            string[] elements = sentense.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string element in elements)
            {
                string[] words = element.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    expressions.Add(new WordExpression(word));
                }
                expressions.Add(new SymbolExpression("."));
            }

            foreach (IExpression expression in expressions)
            {
                expression.Interpret(sb);
            }

            return sb.ToString();
        }
    }
}
