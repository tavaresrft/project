using System; // Declara as bibliotecas usadas
using static ProjetoFinal.Elevador;

namespace ProjetoFinal
{
    class Programa
    {
        static void Main(string[] args) //declaração padrão, para indicar onde a execução vai começar.
        {
            // Lê a capacidade total de elevadores
            Console.WriteLine("Escolha a capacidade máxima do Elevador.");
            int capacidade = Int32.Parse(Console.ReadLine());

            // Lê o total de andares
            Console.WriteLine("Escolha a quantidade total de andares.");
            int andares = Int32.Parse(Console.ReadLine());

            // Cria um novo objeto da classe Elevador
            Elevador elevador = new Elevador();

            // Instancia o elevador com a capacidade máxima e o total de andares
            elevador = elevador.Inicializar(capacidade, andares);

            //Chama os métodos Subir, Descer, Entrar, Sair
            elevador.Subir();
            elevador.Subir();
            elevador.Subir();
        }        
    }
} 