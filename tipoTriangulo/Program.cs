//3.faça um programa que leia os 3 lados de um triangulo e informe o tipo dele: isósceles, 
//quadrilatero e escaleno. Importante: 

//Um triângulo equilátero tem todos os lados com a mesma medida;
//Um triângulo isósceles tem dois lados com a mesma medida;
//Um triângulo escaleno tem todos os lados possuem medidas diferentes.

double lado1, lado2, lado3;
int op = 0;

Console.WriteLine("Digite o tamanho dos lados do triângulo para saber sua classificação:");

do
{
    Console.WriteLine("Digite o tamanho do primeiro lado:");
    lado1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o tamanho do segundo lado:");
    lado2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o tamanho do terceiro lado:");
    lado3 = double.Parse(Console.ReadLine());

    if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
    {
        Console.WriteLine("Esse triângulo é escaleno!");
    }
    else if (lado1 != lado2 || lado1 != lado3 || lado2 != lado3)
    {
        Console.WriteLine("Esse triângulo é isósceles!");
    }
    else
    {
        Console.WriteLine("Esse triângulo é equilátero!");
    }

    Console.WriteLine("Digite 0 para continuar ou 1 para parar");
    op = int.Parse(Console.ReadLine());
}
while (op == 0);