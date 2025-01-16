/*
2. Número Positivo ou Negativo

o Objetivo: Aprender a trabalhar com condições múltiplas.
o Descrição: Desenvolva um programa que solicita ao usuário um número. O 
programa deve determinar se o número é positivo, negativo ou zero, 
utilizando if, else if, e else para as três possibilidades. Exiba a mensagem 
correspondente.
o Exemplo de Saída: "O número é positivo.", "O número é negativo." ou "O 
número é zero"
*/

//Solicitando um numero ao usuário
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

//Verificando se o numero é positivo, negativo ou zero
if (numero > 0)
{
    Console.WriteLine("O numero é positvo");
}
else if (numero < 0)
{
    Console.WriteLine("O numero é negativo");
}
else
{
    Console.WriteLine("O numero é zero");
}

