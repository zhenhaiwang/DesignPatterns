/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 命令模式，将“动作的请求者”从“动作的执行者”对象中解耦
    /// </summary>
    
    //命令接口
    public interface Command
    {
        void Execute();
    }

    //具体命令
    public class LightOnCommand : Command   //开灯
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            if (!_light.IsOn())
                _light.On();
        }
    }

    public class LightOffCommand : Command   //关灯
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            if (_light.IsOn())
                _light.Off();
        }
    }

    public class TVOnCommand : Command   //开电视
    {
        private TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            if (!_tv.IsOn())
                _tv.On();
        }
    }

    public class TVOffCommand : Command   //关电视
    {
        private TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            if (_tv.IsOn())
                _tv.Off();
        }
    }

    public class NoCommand : Command   //空命令
    {
        public NoCommand() { }
        public void Execute() { }
    }

    //动作的请求者(遥控器)
    public class RemoteController
    {
        private Command[] _command;

        public RemoteController()
        {
            _command = new Command[2];
        }

        public void SetCommand(Command onCommand, Command offCommand)
        {
            if (onCommand != null)
                _command[0] = onCommand;

            if (offCommand != null)
                _command[1] = offCommand;
        }

        public void ClickOn()
        {
            _command[0].Execute();
        }

        public void ClickOff()
        {
            _command[1].Execute();
        }
    }

    //动作的执行者
    public class Light  //电灯
    {
        private bool _isOn = false;

        public void On()
        {
            _isOn = true;
            Console.WriteLine("Light is On.");
        }

        public void Off()
        {
            _isOn = false;
            Console.WriteLine("Light is Off.");
        }

        public bool IsOn()
        {
            return _isOn;
        }
    }

    public class TV     //电视机
    {
        private bool _isOn = false;

        public void On()
        {
            _isOn = true;
            Console.WriteLine("TV is On.");
        }

        public void Off()
        {
            _isOn = false;
            Console.WriteLine("TV is Off.");
        }

        public bool IsOn()
        {
            return _isOn;
        }
    }
}
