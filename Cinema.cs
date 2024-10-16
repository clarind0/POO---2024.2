using System;


namespace CinemaControl
{
    public class Cinema
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Sala> Salas { get; private set; }
        public List<Filme> Filmes { get; private set; }
        public List<Sessao> Sessoes { get; private set; }
        public List<Ingresso> Ingressos { get; set; }

        public Cinema(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Salas = new List<Sala>();
            Filmes = new List<Filme>();
            Sessoes = new List<Sessao>();
            Ingressos = new List<Ingresso>();
        }

        public void AdicionarSala(Sala sala)
        {
            Salas.Add(sala);
        }

        public void AdicionarFilme(Filme filme)
        {
            Filmes.Add(filme);
        }

        public void AdicionarSessao(Sessao sessao)
        {
            Sessoes.Add(sessao);
        }

        public void AdicionarIngresso(Ingresso ingresso)
        {
            Ingressos.Add(ingresso);
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

        public void ListarSessoes()
        {
            Console.WriteLine("Sessões:");
            foreach (var sessao in Sessoes)
            {
                Console.WriteLine(sessao);
            }
        } 

        public void ListarIngressos()
        {
            Console.WriteLine("Ingressos:");
            foreach (var ingresso in Ingressos)
            {
                Console.WriteLine(ingresso);
            }
        }
        
    }
}