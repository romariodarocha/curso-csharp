using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // É o mesmo que num1 = num1 +10;
            num1 -= 3; // É o mesmo que num1 = num1 - 3;
            num1 *= 5; // É o mesmo que num1 = num1 * 5;
            num1 /= 2; // É o mesmo que num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            Console.WriteLine($"{a} {b}");

            a++; // É o mesmo que a = a + 1;
            b--; // É o mesmo que b = b - 1;

        }
    }
}
