/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;
using System.Collections;

namespace ObserverPattern
{
    //观察者接口
    public interface Observer
    {
        void Update(object data);
    }

    //通知者接口
    public interface Subject
    {
        void AttachObserver(Observer observer);
        void DetachObserver(Observer observer);
        void NotifyObservers();
    }

    //具体观察者
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;
        private string _name;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
            _subject.AttachObserver(this);
        }

        public void Update(object data)
        {
            _name = data as string;
            if (_name != null)
                Console.WriteLine(_name);
        }

        public void Destroy()
        {
            _subject.DetachObserver(this);
            _subject = null;
        }
    }

    //具体通知者
    public class ConcreteSubject : Subject
    {
        private ArrayList _observers;
        private string _data;

        public ConcreteSubject()
        {
            _observers = new ArrayList();
        }

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            int length = _observers.Count;
            for (int i = 0; i < length; i++)
            {
                Observer observer = _observers[i] as Observer;
                observer.Update(_data);
            }
        }

        //数据发生改变，通知观察者
        public void SetData(string data)
        {
            _data = data;
            NotifyObservers();
        }
    }
}
