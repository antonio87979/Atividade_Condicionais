﻿//Número Positivo ou Negativo 
//Objetivo: Aprender a trabalhar com condições múltiplas. 
//Descrição: Desenvolva um programa que solicita ao usuário um número. O programa deve determinar se o número é positivo, negativo ou zero, utilizando if, else if, e else para as três possibilidades. Exiba a mensagem correspondente. 
//Exemplo de Saída: "O número é positivo.", "O número é negativo." ou "O número é zero." 

		Console.WriteLine("Digite um número:");
		int num = int.Parse(Console.ReadLine());
		if (num > 0) {Console.WriteLine($"o número {num} é positivo"); }
		else if (num < 0) {Console.WriteLine($"o número {num} é negativo");}
		else {Console.WriteLine("o número é zero");}
