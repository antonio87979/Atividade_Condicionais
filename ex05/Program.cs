// de Idade
//    Objetivo: Aplicar condições para classificar dados.
//o Descrição: Desenvolva um programa que solicite a idade de uma pessoa e 
//determine se ela é maior de idade (18 anos ou mais) ou menor de idade. 
//Utilize if e else para mostrar a mensagem apropriada.
//o Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade.


		Console.WriteLine("Indique sua Idade:");
		int idade = int.Parse(Console.ReadLine());

		if (idade <= -1 || idade >= 500) {Console.WriteLine("Valor inválido!");
  }
		else if (idade >= 18) {Console.WriteLine("Você é maior de idade.");
  }
		else {Console.WriteLine("Você não é maior de idade.");
  }
	
