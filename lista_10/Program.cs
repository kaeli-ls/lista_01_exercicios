/*
10. Cálculo do Desconto
o Objetivo: Aplicar condições para cálculos.
o Descrição: Escreva um programa que peça o valor de uma compra e 
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% 
no valor e mostre o valor final. Caso contrário, exiba o valor original.
o Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: 
[valor]
*/

//Solicitando o preço ao usuário
Console.WriteLine("Digite o valor da compra: ");
double preco = double.Parse(Console.ReadLine());
int desconto = 10;

//Verificando se o preço oferece desconto
if (preco >= 100)
{
    Console.WriteLine("Compras acima de R$100 possuem 10% desconto.");
    Console.WriteLine($"O valor da compra com desconto é de R${preco - (preco * desconto / 100)}");
}
Console.WriteLine("Compras abaixo de R$100 não possuem desconto."):
Console.WriteLine("O Valor segue o mesmo R${preco}");