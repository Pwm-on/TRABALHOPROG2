using System;
using System.Collections.Generic;
using System.Text;

namespace TRABALHOPROG2
{
    public abstract class Imovel
    {
        public
            int Quadra;
            string Lote, Situacao;
            double Area, Valor;
            Endereco endereco;
        public Imovel ()
        {
            
        }

        public Imovel(string situacao, double valor)
        {
            Situacao = situacao;
            Valor = valor;
        }

        public abstract double CalcularIPTU();
       
    }
    class Terreno : Imovel
    {
        public
            string situacao;
            double valor;
        public Terreno()
        {
        }
        public Terreno (string situacao, double valor) : base (situacao,valor)
        {
        }
      

        public override double CalcularIPTU()
        {
            return 0.03;
        }

    }
    public class Apartamento : Imovel
    {
        private 
            string Condominio;
            int Andar;
        public override double CalcularIPTU()
        {
            return 0.02;
        }
    }

    class Casa : Imovel
    {
        double AreaConstruida;

        double getValor(double Valor)
        {
            return Valor;
        }
        public override double CalcularIPTU()
        {
            return 0.55;
        }
    }
}

