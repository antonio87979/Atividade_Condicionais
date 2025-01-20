//Comparação de Números
 //   Objetivo: Praticar a comparação entre variáveis.
//o Descrição: Escreva um programa que solicita dois números ao usuário e 
//determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
//adequada.
//o Exemplo de Saída: "O primeiro número é maior.", "O segundo número é 
//maior." ou "Os números são iguais.


		Console.WriteLine("Digite o primeiro número:");
		int num1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o segundo número");
		int num2 = int.Parse(Console.ReadLine());

		if (num1 > num2 ) {Console.WriteLine("O primeiro número é maior.");
 }
		else if (num1 < num2 ) {Console.WriteLine("O segundo número é maior.");
 }
		else {Console.WriteLine("Os números são iguais.");
 }
