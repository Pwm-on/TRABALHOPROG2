using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  // Inicio do programa
  // Contém todos os objetos instânciados aqui 
  class Imobiliaria {
      public Imobiliaria() {
        // Lista de endereços
        List<Endereco> enderecos = new List<Endereco>();

        // Lista de pessoas
        List<Pessoa> pessoas =  new List<Pessoa>();
        List<Cliente> clientes =  new List<Cliente>();
        List<Funcionario> funcionarios =  new List<Funcionario>();

        // Lista de imóveis        
        List<Casa> casas =  new List<Casa>();
        List<Apartamento> apartamentos =  new List<Apartamento>();
        List<Terreno> terrenos =  new List<Terreno>();
      }
      // Busca por um objeto específico nas listas
      public void busca() {}
      // Realiza a ação de compra e venda
      public void realizarCompra() {}
      // Realiza a ação de aluguel
      public void realizarAluguel() {}
      // Realiza o cadastro de pessoa
      private void cadastrarPessoa() {}
      // Realiza o cadastro de vendedor
      public void cadastrarVendedor() {}
      // Realiza o cadastro de Cliente
      public void cadastrarCliente() {}
      // Realiza o cadastro de imóvel
      public void cadastrarImovel() {}
  }
  class Principal {
    public static void Main() {
      Imobiliaria imob = new Imobiliaria();

      int op, op2;
      do {
        Console.Clear();
        Console.WriteLine("    Chaves Imobiliaria");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Alugar ou Comprar imóvel");
        Console.WriteLine("2 - Realizar consulta");
        Console.WriteLine("3 - Cadastrar Pessoa");
        Console.WriteLine("4 - Cadastrar Imóvel");
        Console.WriteLine("5 - Cadastrar Imóvel");
        Console.WriteLine("0 - Sair\n");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());

        if(op == 1) {
          do{
            Console.Clear();
            Console.WriteLine("1 - Comprar imóvel");
            Console.WriteLine("2 - Alugar imóvel\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
          } while(op2 != 0);
        }

        if(op == 2) {
          do{
            Console.Clear();
            Console.WriteLine("1 - Consultar situação dos imóveis");
            Console.WriteLine("2 - Consultar clientes");
            Console.WriteLine("3 - Consultar locações dos imóveis\n");
            Console.WriteLine("0 - Voltar\n");
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
          } while(op2 != 0);
        }
      } while (op != 0);
    }
  }
}