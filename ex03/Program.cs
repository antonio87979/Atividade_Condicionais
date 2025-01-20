//Aprovação de Aluno
//Objetivo: Compreender a aplicação de condições para tomada de decisão.
//o Descrição: Escreva um programa que pergunte a nota de um aluno. Se a 
//nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso 
//contrário, ele é "Reprovado". Exiba a situação do aluno na tela.
//o Exemplo de Saída: "Aluno aprovado." ou "Aluno reprovado."

		Console.WriteLine("Digite a nota do aluno(a)...");
		int nota = int.Parse(Console.ReadLine());

		if (nota > 10) {Console.WriteLine("Valor inválido");
    }
		else if (nota >= 6) {Console.WriteLine("Aluno APROVADO!");
    }
		else {Console.WriteLine("Aluno REPROVADO!");
    }
