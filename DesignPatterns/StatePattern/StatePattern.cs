/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

namespace StatePattern
{
    /// <summary>
    /// 
    /// 此处应该有图...
    /// 
    /// 游戏手柄有三种操作: 
    /// 1.奔跑按钮 A
    /// 2.停止按钮 B
    /// 3.开枪按钮 C
    /// 
    /// 角色有三种状态:
    /// 1.奔跑状态 Run
    /// 2.静止状态 Stand
    /// 3.攻击状态 Fire
    /// 
    /// 规则如下:
    /// 1.Stand状态下，点击A按钮，切换到Run状态
    /// 2.Stand状态下，点击C按钮，切换到Fire状态，并立即开一枪
    /// 3.Fire状态下，点击A按钮，切换到Run状态
    /// 4.Fire状态下，点击B按钮，切换到Stand状态
    /// 5.Fire状态下，点击C按钮，立即开一枪
    /// 6.Run状态下，点击B按钮，切换到Stand状态
    /// 7.Run状态下，无法开枪
    /// 8.初始为Stand状态，有n颗子弹，不能补给
    /// 9.子弹为0无法开枪，并自动切换回Stand状态
    /// 
    /// </summary>

    //角色状态接口
    public interface State
    {
        //进入状态触发
        void Enter();

        //离开状态触发
        void Leave();

        //手柄按钮接口
        void PressA();
        void PressB();
        void PressC();
    }

    //具体状态类
    public class RunState : State
    {
        private PlayerController _controller;

        public RunState(PlayerController controller)
        {
            _controller = controller;
        }

        public void Enter()
        {
            Console.WriteLine("\nEnter Run state.");
        }

        public void Leave()
        {
            Console.WriteLine("\nLeave Run state.");
        }

        public void PressA()
        {
            Console.WriteLine("\nYou are already in Run state.");
        }

        public void PressB()
        {
            _controller.SetState(_controller.standState);
        }

        public void PressC()
        {
            Console.WriteLine("\nYou can't fire in Run state.");
        }
    }

    public class StandState : State
    {
        private PlayerController _controller;

        public StandState(PlayerController controller)
        {
            _controller = controller;
        }

        public void Enter()
        {
            Console.WriteLine("\nEnter Stand state.");
        }

        public void Leave()
        {
            Console.WriteLine("\nLeave Stand state.");
        }

        public void PressA()
        {
            _controller.SetState(_controller.runState);
        }

        public void PressB()
        {
            Console.WriteLine("\nYou are already in Stand state.");
        }

        public void PressC()
        {
            if (_controller.BulletEmpty())
            {
                Console.WriteLine("\nYour bullet is empty, can't switch to Fire state.");
            }
            else
            {
                _controller.SetState(_controller.fireState);
            }
        }
    }

    public class FireState : State
    {
        private PlayerController _controller;

        public FireState(PlayerController controller)
        {
            _controller = controller;
        }

        public void Enter()
        {
            Console.WriteLine("\nEnter Fire state.");
            PressC();   //进入Fire状态，立即开一枪
        }

        public void Leave()
        {
            Console.WriteLine("\nLeave Fire state.");
        }

        public void PressA()
        {
            _controller.SetState(_controller.runState);
        }

        public void PressB()
        {
            _controller.SetState(_controller.standState);
        }

        public void PressC()
        {
            if (_controller.BulletEmpty() == false)
            {
                int reserve = _controller.FireBullet();
                Console.WriteLine("\nFire bullet, reserve num is " + reserve.ToString() + ".");
            }

            if (_controller.BulletEmpty())
            {
                _controller.SetState(_controller.standState);
            }
        }
    }

    //角色控制类
    public class PlayerController
    {
        public State standState { get; private set; }
        public State runState { get; private set; }
        public State fireState { get; private set; }

        private State _state;
        private int _bulletNum = 0;

        public PlayerController(int bulletNum)
        {
            _bulletNum = bulletNum;

            standState = new StandState(this);
            runState = new RunState(this);
            fireState = new FireState(this);

            SetState(standState);
        }

        public bool BulletEmpty()
        {
            return _bulletNum <= 0;
        }

        public int FireBullet()
        {
            if (_bulletNum > 0)
                _bulletNum--;

            return _bulletNum;
        }

        public void PressA()
        {
            if (_state != null)
                _state.PressA();
        }

        public void PressB()
        {
            if (_state != null)
                _state.PressB();
        }

        public void PressC()
        {
            if (_state != null)
                _state.PressC();
        }

        public void SetState(State state)
        {
            if (_state != null)
                _state.Leave();

            _state = state;

            if (_state != null)
                _state.Enter();
        }
    }
}
