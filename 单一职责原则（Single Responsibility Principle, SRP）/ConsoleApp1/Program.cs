using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
       public static void Main(string[] args)
       {
            Order order = new Order { Id = 1, CustomerName = "John Doe" };

            var orderProcessor = new OrderProcessor();
            var orderRepository = new OrderRepository();
            var emailService = new EmailService();

            orderProcessor.ProcessOrder();
            orderRepository.Save(order);
            emailService.SendConfirmationEmail(order);

            Console.ReadKey();
       }
    }
}
/*
 *   - 一个类，只需要负责一种职责
  - main函数所在的类，作为程序的启动入口，职责单一

优势：
职责分离：每个类只负责一个特定的任务。
可维护性：修改某个职责的逻辑不会影响其他职责。
可扩展性：如果需要更换邮件服务或数据库实现，只需修改对应的类。
这样设计让代码更易读、更易测试，同时减少了耦合。
 */
