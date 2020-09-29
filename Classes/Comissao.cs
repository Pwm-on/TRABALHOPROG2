namespace Imobiliaria {
  class Comissao : Funcionario {
    public double CalcularComissao(double valor) {
      return valor * 0.03;
    }
  }
}