/*
9. Dia da Semana (usando if-else)

o Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
o Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba 
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", 
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de 
erro.
o Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. 
Digite um número de 1 a 7"
*/

using System;
using System.Collections;
//Pedindo ao usuário um numero para mostrar o dia da semana
Console.WriteLine("Vamos mostrar o dia da semana");
Console.WriteLine("Digite um numero: ");
int data = int.Parse(Console.ReadLine());

//numeros de cada dia da semana considerando que mês comece em um domingo
List<int> segunda = new List<int> { 2, 9, 16, 23, 30 };
List<int> terca = new List<int> { 3, 10, 17, 24, 31 };
List<int> quarta = new List<int> { 4, 11, 18, 25 };
List<int> quinta = new List<int> { 5, 12, 19, 26 };
List<int> sexta = new List<int> { 6, 13, 20, 27 };
List<int> sabado = new List<int> { 7, 14, 21, 28 };
List<int> domingo = new List<int> { 1, 8, 15, 22, 29 };

//Verificando o dia da semana 
if (segunda.Contains(data))
{
    Console.WriteLine($"Dia {data} é segunda feira");
}
else if (terca.Contains(data))
{
    Console.WriteLine($"Dia {data} é terça feira");
}
else if (quarta.Contains(data))
{
    Console.WriteLine($"Dia {data} é quarta feira");
}
else if (quinta.Contains(data))
{
    Console.WriteLine($"Dia {data} é quinta feira");
}
else if (sexta.Contains(data))
{
    Console.WriteLine($"Dia {data} é sexta feira");
}
else if (sabado.Contains(data))
{
    Console.WriteLine($"Dia {data} é sábado");
}
else if (domingo.Contains(data))
{
    Console.WriteLine($"Dia {data} é domingo");
}
else
{
    Console.WriteLine("Não existe essa data");
}