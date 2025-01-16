/*
1. Verificação de Paridade
o Objetivo: Praticar o uso do operador % (módulo) e estruturas condicionais 
simples.
o Descrição: Crie um programa que peça ao usuário para digitar um número 
inteiro. O programa deve verificar se o número é par ou ímpar. Utilize a 
condição if para determinar o resultado e exiba uma mensagem apropriada.
o Exemplo de Saída: "O número é par." ou "O número é ímpar."
*/

//Solicitando um numero ao usuário
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

//Classificando se o numero é impar ou par
if (numero % 2  == 0)
{
    Console.WriteLine("O numero é par");
}
else
{
    Console.WriteLine("O numero é impar");
}