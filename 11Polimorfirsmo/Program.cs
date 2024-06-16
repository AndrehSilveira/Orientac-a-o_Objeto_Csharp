// See https://aka.ms/new-console-template for more information
 int salarioEstagiario = 1000;
 int salarioAtendente = 2000;
 int salarioGerente = 5000;
 // Instanciar Estagiário
 Imposto objetoE = new Estagiario();
 objetoE.valeAlimentacao(salarioEstagiario);
 objetoE.valeTransporte(salarioEstagiario);
 Console.WriteLine("--------------");

 // Instanciar Gerente
 Imposto objetoG = new Gerente();
 objetoG.valeAlimentacao(salarioGerente);
 objetoG.valeTransporte(salarioGerente);
 Console.WriteLine("--------------");

 // Instanciar Atendente
 Imposto objetoA = new Atendente();
 objetoA.valeAlimentacao(salarioAtendente);
 objetoA.valeTransporte(salarioAtendente);
 Console.WriteLine("--------------");
