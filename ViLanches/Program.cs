using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViLanches
{
    internal class Program
    {
        // Struct
        struct Pedido
        {
            public string Nome;
            public string Codigo;
            public string Valor;

            public Pedido(string nome, string codigo, string valor)
            {
                Nome = nome;
                Codigo = codigo;
                Valor = valor;  
            }
            public void ExibirDados()
            {
                Console.WriteLine($"Nome..: {Nome} \nCodigo: {Codigo} \nValor.: {Valor}");
            }
        }
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            pedidos.Add(new Pedido("X-Churrasco", "01", "R$15,00"));
            pedidos.Add(new Pedido("X-Bacon", "02", "R$12,00"));
            pedidos.Add(new Pedido("X-Tudo", "03", "R$18,00"));
            foreach (Pedido pedido in pedidos)
            {
                pedido.ExibirDados();
                Console.WriteLine();
            }
         Queue<string> fila = new Queue<string>();
            fila.Enqueue("X-Churrasco");
            fila.Enqueue("X-Bacon");
            fila.Enqueue("X-Tudo");
            Console.WriteLine($"Numero de pedidos: {fila.Count}");
            Console.WriteLine($"Proximo pedido a ser feito {fila.Peek()}");
            Console.WriteLine($"Numero de pessoas na fila: {fila.Count}");
            Console.WriteLine($"O {fila.Dequeue()} está pronto");
            Console.Write($"Elias entrou na fila e");
            Console.WriteLine($" pediu um X-Bacon");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"O {fila.Dequeue()} está pronto");



            Console.ReadKey();
        }
    }
}
