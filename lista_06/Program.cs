/*
6. Classificação de Notas

o Objetivo: Aprender a usar múltiplas condições em uma estrutura de 
decisão.
o Descrição: Crie um programa que peça a nota de um aluno e classifique a 
nota em categorias: "Excelente"(nota >= 9), "Boa"(7 <= nota < 9), "Regular"
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
o Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa"
*/

// Solicitar as nota do aluno
using System.Runtime.InteropServices;

Console.WriteLine("Digte sua nota: ");
double nota = double.Parse(Console.ReadLine());


//Classificando a nota do aluno
if (nota >= 9)
{
    Console.WriteLine("Excelente nota!!");
}
else if (nota >= 7 && nota < 9)
{
    Console.WriteLine("Boa nota");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Nota regular");
}
else
{
    Console.WriteLine("Nota baixa");
}