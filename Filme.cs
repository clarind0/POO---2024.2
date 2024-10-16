using System;


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


        public Filme(string titulo, int duracao, bool dublado, bool is3D, string genero, int indicacaoIdade)
        {
            Titulo = titulo;
            Duracao = duracao;
            Dublado = dublado;
            Is3D = is3D;
            Genero = genero;
            IndicacaoIdade = indicacaoIdade;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Duracao} min - {(Dublado ? "Dublado" : "Legendado")} - {(Is3D ? "3D" : "2D")} - Gênero: {Genero} - Indicação: {IndicacaoIdade}+";
        }
    }
}