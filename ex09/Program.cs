//Dia da Semana (usando if-else)
//    Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
//o Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba 
//o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira",
//etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de 
//erro.
//o Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. 
//Digite um número de 1 a 7.


		Console.WriteLine("Digite um número:");
		int dia = int.Parse(Console.ReadLine());

		if (dia == 1) {Console.WriteLine("Segunda-feira.");}
		else if (dia == 2) {Console.WriteLine("Terça-feira.");}
		else if (dia == 3) {Console.WriteLine("Quarta-feira.");}
		else if (dia == 4) {Console.WriteLine("Quinta-feira.");}
		else if (dia == 5) {Console.WriteLine("Sexta-feira.");}
		else if (dia == 6) {Console.WriteLine("Sábado.");}
		else if (dia == 7) {Console.WriteLine("Domingo.");}

		else {Console.WriteLine("Valor inválido. Digite um número de 1 a 7.");}
