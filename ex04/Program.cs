// de Valores
//    Objetivo: Familiarizar - se com a verificação de intervalos numéricos.
//o Descrição: Crie um programa que verifique se um número digitado pelo 
//usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para 
//verificar se o número está no intervalo e exiba uma mensagem informando 
//o resultado.
//o Exemplo de Saída: "O número está entre 1 e 100." ou "O número não está 
//entre 1 e 100.

		Console.WriteLine("Digite um número:");
		int num = int.Parse(Console.ReadLine());

		if (num >= 1 && num <= 100) {Console.WriteLine("O número está no intervalo (1-100)");
    }
		else {Console.WriteLine("O número não está no intervalo (1-100)");
    }
