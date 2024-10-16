using System;


namespace CinemaControl
{
      public class Sessao
    {
        public Filme Filme { get; set;}
        public Sala Sala { get ; set; }   
        public DateTime Horario { get; set; }
        public int QuantidadeSessao { get; set; }

        public Sessao(Filme filme, Sala sala, DateTime horario)
        {
            Filme = filme;
            Sala = sala;
            Horario = horario;
            QuantidadeSessao = sala.QuantidadeAssentos;
        }

        public void DecrementarAssento()
        {
            if(QuantidadeSessao>0)
            {
                QuantidadeSessao -= 1;
            }else Console.WriteLine("INGRESSOS ESGOTADOS!");
        }
        public override string ToString()
        {
            return $"Filme: {Filme.Titulo} - Sala: {Sala.Numero} Assentos Disponíveis: {QuantidadeSessao}, {(Sala.Is3D ? "3D" : "2D")}, {Filme.IndicacaoIdade}+ - Sessão: {Horario:HH:mm}";
        }
    }
}