using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Informe a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("A nota é maior do que 10? {0}", nota>10);
            Console.WriteLine("A nota é menor que zero? {0}", nota<0.0);
            Console.WriteLine("A nota é igual a 10? {0}", nota==10);
            Console.WriteLine("É possível melhorar a nota? {0}", nota!=10);
            Console.WriteLine("A nota é maior ou igual que a nota de corte? {0}", nota>=notaDeCorte);
            Console.WriteLine("Precisará fazer recuperação? {0}", nota<notaDeCorte);
            Console.WriteLine("O aluno foi reprovado na prova? {0}", nota<=3);
        }
    }
}
