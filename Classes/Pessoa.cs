namespace Imobiliaria {
  class Pessoa {
    private string nome, cpf;
    private Endereco endereco;

    public string _cpf { get { return this.cpf; } set { this.cpf = value; } }
    public string _nome { get { return this.nome; } set { this.nome = value; } }
    
    public Pessoa() {}
    public Pessoa(string nome, string cpf, Endereco endereco) {
      this.nome = nome;
      this.cpf = cpf;
      this.endereco = endereco;
    }

    public Pessoa(string nome, string cpf) {
      this.nome = nome;
      this.cpf = cpf;
    }
    
    public virtual string imprimir() {
      string str = String.Format("Pessoa: (\n {0},\n {1},\n)\n",
        this._nome,
        this._cpf
      );
      return str;
    }
  }
}