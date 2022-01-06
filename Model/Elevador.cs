using System; // Declara as bibliotecas usadas

namespace ProjetoFinal
{
    public class Elevador
    {
        public int capacidade_maxima {get; set;}
        public int total_andares {get; set;}
        public int andar_atual {get; set;}
        public int qtde_passageiros {get; set;}

        public Elevador Inicializar(int capacidade, int andares)
        {
            // Instancia um novo elevador (chamado no main)
            Elevador elevador = new Elevador();

            // Recebe a capacidade total e o total de andares para criar o novo elevador
            elevador.capacidade_maxima = capacidade;
            elevador.total_andares = andares;

            // Inicializa o elevador no térreo e vazio, como solicitado
            elevador.andar_atual = 0;
            elevador.qtde_passageiros = 0;

            return elevador;
        }
        // Método Entrar: Adiciona uma pessoa ao elevador. Caso esteja no máximo, avisa que o elevador está cheio
        public void Entrar()
        {
            if (this.qtde_passageiros < this.capacidade_maxima)
            {
                this.qtde_passageiros += 1;
            } else {
                Console.WriteLine("O elevador está no limite de sua capacidade.");
            }

        }
        // Método Sair: Remove uma pessoa do elevador. Caso esteja vazio, avisa que o elevador está vazio
        public void Sair()
        {
            if (this.qtde_passageiros > 0 )
            {
                this.qtde_passageiros -= 1;
            } else {
                Console.WriteLine("O elevador está vazio.");
            }
        }
        // Método Subir: Sobe um andar. Caso esteja no máximo, avisa que o elevador está no último andar
        public void Subir()
        {
            if (this.andar_atual < this.total_andares)
            {
                this.andar_atual += 1;
            } else {
                Console.WriteLine("O elevador está no último andar");
            }
        }
        // Método Descer: Desce um andar. Caso esteja no térreo, avisa que o elevador está no térreo
        public void Descer()
        {
            if (this.andar_atual > 0)
            {
                this.andar_atual -= 1;
            } else {
                Console.WriteLine("O elevador está no térreo");
            }
        }
    }
}