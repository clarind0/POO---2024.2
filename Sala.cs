using System;


namespace CinemaControl
{
    public class Sala
    {
        public int Numero { get; set; }
        public int QuantidadeAssentos { get; private set; }
        public bool Is3D { get; set; }
        public bool Isvip { get; set; }

        public Sala(int numero, int quantidadeAssentos, bool is3D, bool isvip)
        {
            Numero = numero;
            QuantidadeAssentos = quantidadeAssentos;
            Is3D = is3D;
            Isvip = isvip;
        }

        public override string ToString()
        {
            return $"Sala {Numero} - Assentos: {QuantidadeAssentos} - {(Is3D ? "3D" : "2D")}  {(Isvip ? "- VIP" : "")}";
        }
    }
}