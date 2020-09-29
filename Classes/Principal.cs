using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  // Inicio do programa
  // Contém todos os objetos instânciados aqui 
  // class Imobiliaria {
  //     public Imobiliaria() {
  //       // List<Pessoa> pessoas =  new List<Pessoa>();
  //     }
  // }
  class Principal {
    public static void Main() {
      // Terreno terreninho = new Terreno("Disponível", 1500);
      // string disponivel = terreninho.situacao;
      // Console.WriteLine(disponivel);

      int op, op2;
      do {
        Console.Clear();
        Console.WriteLine("    Chaves Imobiliaria");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Alugar ou Comprar imóvel");
        Console.WriteLine("2 - Realizar consulta");
        Console.WriteLine("3 - Cadastrar Vendedor");
        Console.WriteLine("4 - Cadastrar Imóvel");
        Console.WriteLine("5 - Cadastrar Pessoa");
        Console.WriteLine("6 - Cadastrar Vendedor");
        Console.WriteLine("0 - Sair\n");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());

        if(op == 1) {
          do{
            Console.Clear();
            Console.WriteLine("1 - Comprar imóvel");
            Console.WriteLine("2 - Alugar imóvel");
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
            Console.Write("Escolha uma opção: ");
            op2 = int.Parse(Console.ReadLine());
          } while(op2 != 0);
        }
      } while (op != 0);
    }
  }
}