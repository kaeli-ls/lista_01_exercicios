/*
3. Aprovação de Aluno

o Objetivo: Compreender a aplicação de condições para tomada de decisão.
o Descrição: Escreva um programa que pergunte a nota de um aluno. Se a 
nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso 
contrário, ele é "Reprovado". Exiba a situação do aluno na tela.
o Exemplo de Saída: "Aluno aprovado." ou "Aluno reprovado."    
*/

// Solicitando a nota do aluno
Console.WriteLine("Digte sua nota: ");
double nota = double.Parse(Console.ReadLine());

//Classificando o status do aluno
if (nota >= 6)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}