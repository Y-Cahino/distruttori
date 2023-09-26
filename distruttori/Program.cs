using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace distruttori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esempio es= new Esempio();
            Console.WriteLine("Inserire nome");
            string n=Console.ReadLine();
            es.setnome(n);
            Console.WriteLine("Inserire numero intero");
            int num = Convert.ToInt32(Console.ReadLine());
            es.setnum(num);
            es.visualizza();
            es.Dispose();
        }
    }
}
