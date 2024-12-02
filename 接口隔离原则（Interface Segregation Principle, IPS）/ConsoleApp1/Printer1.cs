using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Printer1
    {
        private Object document;

        public Printer1(Object document)
        {
            this.document = document;
        }

        public void print()
        {
            if (document is Document) {
                ((Document)document).PrintContent();
            } else if (document is ImageDocument) {
                ((ImageDocument)document).PrintContent();
            }
        }
    }
    //这种设计显然不理想，因为每次添加新的文档类型都需要修改 Printer 类，增加了维护的复杂性。
}
