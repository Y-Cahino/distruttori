using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distruttori
{
    public class Class1
    {
        private string nome;
        private int numero;
        public Class1()
        {
            nome = "";
            numero = 0;
        }
        public Class1(string n,int num)
        {
            setnome(n);
            setnum(num);
        }
        public string getnome()
        {
            return nome;
        }
        public double getnum()
        {
            return numero;
        }
        public void setnum(int num)
        {
            if (num > 0)
            {
                numero = num;
            }
        }
        public void setnome(string n)
        {
            nome = n;
        }
        ~Class1()
        {
            Console.WriteLine("Distruttore in chiamata");
        }
    }
}
