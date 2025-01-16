/*
7. Comparação de Números

o Objetivo: Praticar a comparação entre variáveis.
o Descrição: Escreva um programa que solicita dois números ao usuário e 
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
adequada.
o Exemplo de Saída: "O primeiro número é maior.", "O segundo número é 
maior." ou "Os números são iguais."
*/

//Solicitando dois numero ao usuário
Console.Write("Digite um número ");
int numero1 = int.Parse(Console.ReadLine());
Console.Write("Digite outro número ");
int numero2 = int.Parse(Console.ReadLine());

//Verificando e determinando se é maior, menor ou igual
if (numero1 > numero2)
{
    Console.WriteLine($"{numero1} é maior que o {numero2}");
}
else if  (numero1 < numero2)
{
    Console.WriteLine($"{numero1} é menor que o {numero2}");
}
else
{
    Console.WriteLine("Os numeros são iguais");
}
