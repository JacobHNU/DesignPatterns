using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Document:IPrintable
    {
        public void PrintContent()
        {
            Console.WriteLine("Printing document content");
        }
    }
}
