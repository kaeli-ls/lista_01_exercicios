/*
4. Intervalo de Valores

o Objetivo: Familiarizar - se com a verificação de intervalos numéricos.
o Descrição: Crie um programa que verifique se um número digitado pelo 
usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para 
verificar se o número está no intervalo e exiba uma mensagem informando 
o resultado.
o Exemplo de Saída: "O número está entre 1 e 100." ou "O número não está 
entre 1 e 100."
*/



//Solicitando um numero ao usuário
Console.Write("Digite um número ");
int numero = int.Parse(Console.ReadLine());
List<int> lista = Enumerable.Range(1, 100).ToList();

//Verificando se o numero está no intervalo de 1 a 100
if (lista.Contains(numero))
{
    Console.WriteLine($"O numero {numero} está no intervalo de 1 a 100");
}
else
{
    Console.WriteLine($"O numero {numero} não está no intervalo de 1 a 100");
}
