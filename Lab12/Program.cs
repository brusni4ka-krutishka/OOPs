using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace Lab12
{
    class Program
    {
        static void Main()
        {
            Printer printer = new("Canon 16", "Да", 15);
            Scanner scanner = new("Canon pixma", "Нет", 0);
            Computer computer = new("Hyper PC", "Да", 45);
            Tablet tablet = new("Prestigio", "Да", 99);

            Reflector.AllClassContent(printer);
            Reflector.FieldsAndProperties(scanner);
            Reflector.Interfaces(computer);
            Reflector.PublicMethods(tablet);
            
            Reflector.Create();
            Reflector.Invoke("Lab12.TestParams", "showParams");

            Console.ReadKey();
        }
    }
}
