using System;

namespace Imobiliaria {
  public class Endereco {
    private string logradouro, bairro, cidade, estado, cep;
    private int numero;

    public Endereco() {}

    public Endereco(string logradouro, string bairro, string cidade, 
    string estado, string cep, int numero) {
      this.logradouro = logradouro;
      this.bairro = bairro;
      this.cidade = cidade;
      this.estado = estado;
      this.cep = cep;
      this.numero = numero;
    }
  }
}