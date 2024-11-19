using System;

class Program {
  public static void Main (string[] args) {

    string SIGA = "VERDE";

  Console.WriteLine(" Semafaro PRESTE ATENÇÃO");
  Console.WriteLine("Qual a cor do semafaro?");
  if(SIGA == "VERDE"){
    Console.WriteLine("Pode passar");
    }
  if(SIGA == "AMARELO"){
      Console.WriteLine("pare");
    }
  if(SIGA == "VERMELHO"){
      Console.WriteLine( "pare");
    }
  }
}