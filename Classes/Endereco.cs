using System;

namespace Imobiliaria {
  public class Endereco {
    private string logradouro, bairro, cidade, estado, cep;
    private int numero;

    public string _logradouro { get { return this.logradouro; } set { this.logradouro = value; } }
    public string _bairro { get { return this.bairro; } set { this.bairro = value; } }
    public string _cidade { get { return this.cidade; } set { this.cidade = value; } }
    public string _estado { get { return this.estado; } set { this.estado = value; } }
    public string _cep { get { return this.cep; } set { this.cep = value; } }
    public int _numero { get { return this.numero; } set { this.numero = value; } }

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

    public virtual string imprimir() {
      string str = String.Format("Endereco: (\n {0},\n {1},\n {2},\n {3},\n {4},\n {5},\n {6}\n)\n",
        this._logradouro,
        this._bairro,
        this._cidade,
        this._estado,
        this._cep,
        this._numero
      );
      return str;
    }
  }
}