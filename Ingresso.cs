using System;


namespace CinemaControl
{
     public class Ingresso //: Sessao 
    {
        public int NumeroAssento { get; set; }
        public bool IsInteira { get; set; }
        public float Preco { get; set; }
        public Sessao Sessao { get; set;}
        public DateTime HorarioSessao { get; set; }

        public Ingresso(Sessao sessao, /*Filme filme, Sala sala, DateTime horario,*/ int numeroAssento, bool isInteira, float preco) //: base(filme, sala, horario)
        {
            Sessao = sessao;

            if(Sessao.QuantidadeSessao>0)
            {
                NumeroAssento = numeroAssento;
                IsInteira = isInteira;
                Preco = preco;
                HorarioSessao = sessao.Horario;

                //Decrementar assento através da sessão
                Sessao.DecrementarAssento();
            }
                
            
            
            
            
        }
        public override string ToString()
        {
            return $"Filme: {Sessao.Filme.Titulo} - Sala: {Sessao.Sala.Numero}, {(Sessao.Sala.Is3D ? "3D" : "2D")}, {Sessao.Filme.IndicacaoIdade}+ - Sessão:{Sessao.Horario:dd/MM/yy HH:mm} - Assento:{NumeroAssento} - {(IsInteira ? "Inteira" : "Meia")} - R${Preco}";
        }
    }
}