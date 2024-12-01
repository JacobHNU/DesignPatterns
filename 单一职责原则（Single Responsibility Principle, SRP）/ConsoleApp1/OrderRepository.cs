using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine("Saving order to database...");
            // 保存到数据库逻辑
        }
    }
}
