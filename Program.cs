
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CinemaControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinema = new Cinema("Cineplex", "Rua principal, 10");

            // Adicionando salas
            cinema.AdicionarSala(new Sala(1, 50, true, true));
            cinema.AdicionarSala(new Sala(2, 80, false, false));
            cinema.AdicionarSala(new Sala(3, 100, true, false));

            // Adicionando filmes
            cinema.AdicionarFilme(new Filme("Aglis", 125, true, false, "Romance", 18));
            cinema.AdicionarFilme(new Filme("Portugol", 129, false, false, "Fantasia", 0));
            cinema.AdicionarFilme(new Filme("The Jonker", 125, false, true, "Romance", 12));

            // Adicionando sessões
            cinema.AdicionarSessao(new Sessao(cinema.Filmes[1], cinema.Salas[1], new DateTime(2024,10,10,13,30,0)));
            cinema.AdicionarSessao(new Sessao(cinema.Filmes[0], cinema.Salas[0], new DateTime(2024,10,10,15,45,0)));
            cinema.AdicionarSessao(new Sessao(cinema.Filmes[0], cinema.Salas[0], new DateTime(2024,10,10,18,30,0)));
            cinema.AdicionarSessao(new Sessao(cinema.Filmes[2], cinema.Salas[2], new DateTime(2024,10,10,20,45,0)));
            cinema.AdicionarSessao(new Sessao(cinema.Filmes[0], cinema.Salas[0], new DateTime(2024,10,10,22,30,0)));

            // Adicionando ingressos
            // cinema.AdicionarIngresso(new Ingresso(cinema.Sessoes[2], cinema.Filmes[0], cinema.Salas[0], cinema.Sessoes[2].HorarioSessao, 25, true, 30.00f));
            // cinema.AdicionarIngresso(new Ingresso(cinema.Sessoes[2], cinema.Filmes[0], cinema.Salas[0], new DateTime(2024,10,10,18,30,0), 26, false, 15.00f));
            cinema.AdicionarIngresso(new Ingresso(cinema.Sessoes[2], 25, true, 30.00f));

            // Listando salas e filmes
            cinema.ListarSalas();
            cinema.ListarFilmes();
            cinema.ListarSessoes();
            cinema.ListarIngressos();
        }
    }
}                           