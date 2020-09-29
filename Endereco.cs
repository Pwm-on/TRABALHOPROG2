using System;

namespace Imobiliaria {
  public class Endereco {
    private
    string Logradouro,
    Bairro,
    Cidade,
    Estado,
    CEP;
    int Numero;

    public Endereco() {}

    public Endereco(string logradouro, string bairro, string cidade, string estado, string cEP, int numero) {
      Logradouro = logradouro;
      Bairro = bairro;
      Cidade = cidade;
      Estado = estado;
      CEP = cEP;
      Numero = numero;
    }

  }
}