using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Nome = "Willian";
            t.Idade = 28;

            Console.WriteLine(t.Nome + " " + t.sobrenome);
            Console.WriteLine(t.Idade);

            Console.ReadKey();
        }
    }
}
