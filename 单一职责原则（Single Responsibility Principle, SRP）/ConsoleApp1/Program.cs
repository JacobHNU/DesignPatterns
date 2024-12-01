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
 */
