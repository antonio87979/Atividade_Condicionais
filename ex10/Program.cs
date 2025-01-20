///Cálculo do Desconto
//    Objetivo: Aplicar condições para cálculos.
//o Descrição: Escreva um programa que peça o valor de uma compra e 
//verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% 
//no valor e mostre o valor final. Caso contrário, exiba o valor original.
//o Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: 
//[valor]


		Console.WriteLine("Digite o valor da compra:");
		double valor = double.Parse(Console.ReadLine());

		if (valor > 200 ) {
		double desconto = valor * 0.20;
		double valorfinal = valor - desconto;
		Console.WriteLine($"O valor com desconto especial é: {valorfinal}.");
  }
		else if (valor > 100) {
			double desconto2 = valor * 0.10;
			double valorfinal2 = valor - desconto2;
			Console.WriteLine($"O valor com desconto  é: {valorfinal2}.");
	}
		else {Console.WriteLine($"O valor final é: {valor}.");
  }
