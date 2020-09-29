using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria {
  class Principal {
    public static void Main() {
      Terreno terreninho = new Terreno("Disponível", 1500);
      string disponivel = terreninho.situacao;
      Console.WriteLine(disponivel);

      int op;
      do {
        Console.Clear();
        Console.WriteLine("    Chaves Imobiliaria");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Alugar ou Comprar imóvel");
        Console.WriteLine("2 - Realizar consulta");
        Console.WriteLine("0 - Sair\n");

        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());

        if(op == 1) {

        }

        if(op == 2) {
          int op2;
          Console.Clear();
          Console.WriteLine("1 - Consultar situação dos imóveis");
          Console.WriteLine("2 - Consultar clientes");
          Console.WriteLine("3 - Consultar locações dos imóveis\n");
          Console.Write("Escolha uma opção: ");
          op2 = int.Parse(Console.ReadLine());
        }
      } while (op != 0);
    }
  }
}