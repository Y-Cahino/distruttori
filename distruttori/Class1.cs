using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distruttori
{
    class Esempio :IDisposable
    {
        private string nome;
        private int numero;
        private bool disposed = false;
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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //aree virtuali
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // rilascia le risorse gestite qui (qual'ora ci fossero)
            }
            // rilascia le risorse non gestite qui (qual'ora ci fossero)

            disposed = true;
        }

        public void visualizza()
        {
            Console.WriteLine("Nome: " + nome + "\nNumero: " + numero);
        }
        ~Esempio()
        {
            Dispose(false);
            Console.WriteLine("Distruttore in chiamata");
        }
    }
}
