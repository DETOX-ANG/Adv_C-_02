using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods {
    class Program {
        static void Main(string[] args) {

            string msg = "angelo Rocha";

            Console.WriteLine(ExtensionString.FirstToUpper(msg));
            Console.ReadKey();
        }
    }
}
