/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace MediatorPattern
{
    /// <summary>
    /// 中介对象封装一系列对象之间的交互关系，集中控制逻辑，类似中间平台(游戏大厅，微信群，聊天室...)
    /// 各个对象之间不需要显式地相互引用，解耦网状结构
    /// 常常被用于协调相关的GUI组件
    /// </summary>

    // 抽象玩家类
    public abstract class Player
    {
        protected string _name { set; get; }

        public void TalkTo(Player other)
        {
            Console.WriteLine(_name + " is talking to " + other._name);
        }
    }

    // 具体玩家A
    public class PlayerA : Player
    {
        public PlayerA(string name)
        {
            _name = name;
        }
    }

    // 具体玩家B
    public class PlayerB : Player
    {
        public PlayerB(string name)
        {
            _name = name;
        }
    }

    // 中介者类
    public class Mediator
    {
        protected PlayerA _playerA;
        protected PlayerB _playerB;

        public Mediator(PlayerA a, PlayerB b)
        {
            _playerA = a;
            _playerB = b;
        }

        public void ATalk()
        {
            _playerA.TalkTo(_playerB);
        }

        public void BTalk()
        {
            _playerB.TalkTo(_playerA);
        }
    }
}
