//Verificação de Paridade 
//Objetivo: Praticar o uso do operador % (módulo) e estruturas condicionais simples. 
//Descrição: Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve verificar se o número é par ou ímpar. Utilize a condição if para determinar o resultado e exiba uma mensagem apropriada. 
//Exemplo de Saída: "O número é par." ou "O número é ímpar."
Console.WriteLine("digite um número");
int num = int.Parse(Console.ReadLine());

//% 2 = mutiplos de 2 e diferentes de 0
if (num % 2 == 0)
{
    Console.WriteLine($"O número {num} é par.");
}
else
{
    Console.WriteLine($"o número {num} é impar");
}
