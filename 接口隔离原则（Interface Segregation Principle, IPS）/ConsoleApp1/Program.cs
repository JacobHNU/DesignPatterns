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
            IPrintable document = new Document();
            Printer documentPrinter = new Printer(document);
            documentPrinter.Print();

            IPrintable imageDocument = new ImageDocument();
            Printer imagePrinter = new Printer(imageDocument);
            imagePrinter.Print();

            Console.ReadKey();
        }
    }
}
/*
 * 解耦合：Printer 类不再依赖于具体的 Document 或 ImageDocument 类，而是依赖于 Printable 接口。这使得 Printer 类与具体的文档实现解耦合。不再让Printer类中依赖 Document 或 ImageDocument 类，而是定义一个最小接口Printable接口，来让 Document 或 ImageDocument 类实现Printable接口，然后让Pirnter类依赖Pirntable接口，让其对象进行变化即可。
多态性：Printer 类可以处理任何实现了 Printable 接口的对象，无需修改自身代码。
可测试性：可以轻松地使用模拟对象来测试 Printer 类，而不需要依赖具体的文档实现。
扩展性：添加新的文档类型时，只需实现 Printable 接口，而不需要修改 Printer 类。
通过这种方式，Printer 类变得更加灵活和可维护，能够更好地适应变化和扩展需求。
 */