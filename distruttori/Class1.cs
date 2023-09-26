using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distruttori
{
    public class Esempio
    {
        private string nome;
        private int numero;
        public Esempio()
        {
            nome = "";
            numero = 0;
        }
        public Esempio(string n,int num)
        {
            setnome(n);
            setnum(num);
        }
        #region metodi_accessor
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
        #endregion
        public void visualizza()
        {
            Console.WriteLine("Nome: " + nome + "\nNumero: " + numero);
        }
        ~Esempio()
        {
            Console.WriteLine("Distruttore in chiamata");
        }
    }
}
