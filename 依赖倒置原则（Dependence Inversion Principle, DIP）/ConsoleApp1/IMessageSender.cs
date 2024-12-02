using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //抽象层
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}
