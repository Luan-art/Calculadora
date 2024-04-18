using System.Reflection.PortableExecutable;

float numero1, numero2;

Console.WriteLine("Fala um numero: ");

numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Fala otro: ");

numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A Soma é: {numero1 + numero2} ");
Console.WriteLine($"A Subtração é:  {numero1 - numero2}");
Console.WriteLine($"A multiplicação é:  {numero1 * numero2}");

if (numero2 != 0 || numero2 > 0)
{

    Console.WriteLine($"A divisão é:  {numero1 / numero2}");

}
else
{
    Console.WriteLine("DIVIDINDO POR 0!!!!!!!!!!!!!!????? :<");
}

