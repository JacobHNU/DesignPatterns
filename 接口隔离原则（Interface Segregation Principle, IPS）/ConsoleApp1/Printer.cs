using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Printer
    {
        private IPrintable _printable;

        public Printer(IPrintable printable)
        {
            _printable = printable;
        }

        public void Print()
        {
            _printable.PrintContent();
        }
    }
}
