using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  public abstract class Imovel {
    public int quadra;
    public string lote, situacao;
    public double area, valor;
    public Endereco endereco;

    public Imovel() { }

    public Imovel(string _situacao, double _valor) {
      situacao = _situacao;
      valor = _valor;
    }

    public abstract double CalcularIPTU();
  }

  class Terreno: Imovel {
    public string situacao;
    public double valor;
    public Terreno() {}
    public Terreno(string situacao, double valor) : base(situacao, valor) {}

    public override double CalcularIPTU() {
      return 0.03;
    }
  }

  public class Apartamento : Imovel {
    private string condominio;
    private int andar;

    public override double CalcularIPTU() {
      return 0.02;
    }
  }

  class Casa : Imovel {
    double AreaConstruida;

    double getValor(double Valor) {
      return Valor;
    }
    public override double CalcularIPTU() {
      return 0.55;
    }
  }
}