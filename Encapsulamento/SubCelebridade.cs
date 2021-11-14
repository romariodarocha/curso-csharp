using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Pode ser acessado por todos
        public string InfoPublica = "Tenho um instagram!";

        //Acessado somente por herança
        protected string CorDoOlho = "Verde";

        //Acessado somente pelo mesmo projeto (Assembly)
        internal ulong NumeroCelular = 5511999999999;

        //Acessado por herança ou pelo mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Acessado pela mesma classe, ou por herança dentro do mesmo projeto (C# versão >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() 
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
