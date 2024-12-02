using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //高层模块，依赖接口
    public class Notification
    {
        private readonly IMessageSender _messageSender;
        //通过构造函数注入依赖
        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }
        //通过接口的对象来调用接口的方法
        public void Notify(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
    //Notification 类通过构造函数注入的方式接收一个 IMessageSender 实例，从而实现了依赖倒置原则。
}
