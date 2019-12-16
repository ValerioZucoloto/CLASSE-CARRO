using System;




class MainClass {
  public static void Main (string[] args) {

    Carro Volkswagen = new Carro();
    Console.WriteLine(Volkswagen.GetAno());
    Console.WriteLine(Volkswagen.GetCor());
    Console.WriteLine(Volkswagen.GetModelo());
    Volkswagen.SetAno("2018");
    Volkswagen.SetCor("Prata");
    Volkswagen.SetModelo("Fox");
    Console.WriteLine(Volkswagen.GetAno());
    Console.WriteLine(Volkswagen.GetCor());
    Console.WriteLine(Volkswagen.GetModelo());

    Carro seiNao = new Carro("Gol", "Vermelho", "2010");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine(seiNao.GetAno());
    Console.WriteLine(seiNao.GetCor());
    Console.WriteLine(seiNao.GetModelo());

    Console.ReadKey();
  }
    
}