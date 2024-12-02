using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailSender = new EmailSender();
            Notification notification = new Notification(emailSender);
            notification.Notify("Hello via Email!");

            IMessageSender smsSender = new SmsSender();
            notification = new Notification(smsSender);
            notification.Notify("Hello via SMS!");
        }
    }

    /*
     * 在这个示例中：
    IMessageSender 是一个抽象接口，高层模块 Notification 和低层模块 EmailSender、SmsSender 都依赖于这个抽象接口。

    Notification 类通过构造函数注入的方式接收一个 IMessageSender 实例，从而实现了依赖倒置原则。
    
    这样，如果以后需要添加新的消息发送方式（例如推送通知），只需要实现 IMessageSender 接口，
    并在 Notification 类中注入新的实现即可，而不需要修改现有的高层模块代码。

    这种设计不仅遵循了依赖倒置原则，还体现了开闭原则（Open/Closed Principle），
    即软件实体（类、模块、函数等）应该对扩展开放，对修改关闭。
     */
}
