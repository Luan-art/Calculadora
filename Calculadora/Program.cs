using System.Reflection.PortableExecutable;

float numero1 = 0, numero2 = 1;

int escolha = 0;

do
{

    Console.WriteLine("Fale um numero: ");

    numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Fale outro numero: ");

    numero2 = float.Parse(Console.ReadLine());


    Console.WriteLine("Escolha uma Operação\n" +
        "1 = soma\n" +
        "2 = subtração\n" +
        "3 = multiplicação\n" +
        "4 = divisão\n" +
        "0 = finalizar\n ");

    escolha = int.Parse(Console.ReadLine());


    if (escolha == 1)
    {
        Console.WriteLine($"A Soma é: {numero1 + numero2} ");
    
    }
    else if (escolha == 2)
    {
        Console.WriteLine($"A Subtração é:  {numero1 - numero2}");
    }
    else if (escolha == 3)
    {
        Console.WriteLine($"A multiplicação é:  {numero1 * numero2}");
    }
    else if(escolha == 4 && numero2 != 0)
    {
        Console.WriteLine($"A divisão é:  {numero1 / numero2}");


    }
    else if (numero2 == 0)
    {
        Console.WriteLine("Não se divide por 0");
    }



} while (escolha != 0);




