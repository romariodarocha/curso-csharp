using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            //Cria uma lista tipo Produto

            carrinho.Add(livro);
            //Adiciona itens à lista

            var combo = new List<Produto>
            //Também adiciona itens à lista, como se fossem parâmetros
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            //Adiciona vários elemntos de uma única vez

            Console.WriteLine(carrinho.Count);
            // ".Count" conta quantos itens há na lista

            carrinho.RemoveAt(3);
            // ".RemoveAt" remove um iten da lista

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                // ".IndexOf()" imprime o Nº do itens de uma lista

                Console.WriteLine($" {item.Nome} {item.Preco}");

                Console.WriteLine(carrinho.Count);
                carrinho.Add(livro);
                Console.WriteLine(carrinho.LastIndexOf(livro));
                // ".LastIndexOf()" imprime o índice do elemento livro
            }

        }
    }
}
