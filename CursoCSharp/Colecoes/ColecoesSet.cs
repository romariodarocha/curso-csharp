using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            //Cria uma lista tipo Produto

            carrinho.Add(livro);
            //Adiciona itens à lista

            var combo = new HashSet<Produto>
            //Também adiciona itens à lista, como se fossem parâmetros
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            //Une os itens do Carrinho com os itens do Combo

            Console.WriteLine(carrinho.Count);
            // ".Count" conta quantos itens há na lista

            foreach (var item in carrinho)
            {
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);

            carrinho.Add(livro);
            /* Esse item não será contado, porque já foi dicionado acima
             * E o Set não aceita repetição de item com o mesmo nome*/
                  
            Console.WriteLine(carrinho.Count);
        }
        
    }
}
