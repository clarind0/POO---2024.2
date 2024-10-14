
using System;
using System.Collections.Generic;

namespace CinemaControl
{
    public class Filme
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; } // em minutos
        public bool Dublado { get; set; }
        public bool Is3D { get; set; }
        public string Genero { get; set; }
        public int IndicacaoIdade { get; set; }
        public string Horario { get; set; }


        public Filme(string titulo, int duracao, bool dublado, bool is3D, string genero, int indicacaoIdade, string horario)
        {
            Titulo = titulo;
            Duracao = duracao;
            Dublado = dublado;
            Is3D = is3D;
            Genero = genero;
            IndicacaoIdade = indicacaoIdade;
            Horario = horario;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Duracao} min - {(Dublado ? "Dublado" : "Legendado")} - {(Is3D ? "3D" : "2D")} - Gênero: {Genero} - Indicação: {IndicacaoIdade}+ - Horários: {Horario}";
        }
    }

    public class Sala
    {
        public int Numero { get; set; }
        public int QuantidadeAssentos { get; set; }
        public bool Is3D { get; set; }
        public bool Isvip { get; set; }

        public Sala(int numero, int quantidadeAssentos, bool eh3D, bool isvip)
        {
            Numero = numero;
            QuantidadeAssentos = quantidadeAssentos;
            Is3D = eh3D;
            Isvip = isvip;
        }

        public override string ToString()
        {
            return $"Sala {Numero} - Assentos: {QuantidadeAssentos} - {(Is3D ? "3D" : "2D")} - {(Isvip ? "VIP" : "")}";
        }
    }

    public class Cinema
    {
        public string Nome { get; set; }
        public List<Sala> Salas { get; private set; }
        public List<Filme> Filmes { get; private set; }

        public Cinema(string nome)
        {
            Nome = nome;
            Salas = new List<Sala>();
            Filmes = new List<Filme>();
        }

        public void AdicionarSala(Sala sala)
        {
            Salas.Add(sala);
        }

        public void AdicionarFilme(Filme filme)
        {
            Filmes.Add(filme);
        }

        public void ListarSalas()
        {
            Console.WriteLine("Salas:");
            foreach (var sala in Salas)
            {
                Console.WriteLine(sala);
            }
        }

        public void ListarFilmes()
        {
            Console.WriteLine("Filmes:");
            foreach (var filme in Filmes)
            {
                Console.WriteLine(filme);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cinema = new Cinema("Cineplex");

            // Adicionando salas
            cinema.AdicionarSala(new Sala(1, 50, true, true));
            cinema.AdicionarSala(new Sala(2, 80, false, false));
            cinema.AdicionarSala(new Sala(3, 100, true, false));

            // Adicionando filmes
            cinema.AdicionarFilme(new Filme("Aglis", 125, true, false, "Romance", 18, "13:30 - 15:00 - 19:00"));
            cinema.AdicionarFilme(new Filme("Portugol", 129, false, false, "Fantasia", 0, "14:00 - 17:00 - 19:30"));
            cinema.AdicionarFilme(new Filme("The Jonker", 125, false, true, "Romance", 12, "13:45 - 15:00 - 17:30"));

            // Listando salas e filmes
            cinema.ListarSalas();
            cinema.ListarFilmes();
        }
    }
}