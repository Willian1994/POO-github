using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();

            //c.Acelerou();
            //b.Acelerou();
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("\nHumano");

            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");

            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");

            c.Olhos();
            c.Cabelos();


            Console.ReadKey();

             
        }
    }
}
