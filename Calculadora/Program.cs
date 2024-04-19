using System.Reflection.PortableExecutable;

float numero1 = 0, numero2 = 0, numero3= 0, numero4 = 0;

int escolha = 0;

do
{
    Console.WriteLine("Fale um numero: ");
    numero1 = float.Parse(Console.ReadLine());

    Console.WriteLine("\nFale outro numero: ");
    numero2 = float.Parse(Console.ReadLine());


    Console.WriteLine("\nFale outro numero: ");
    numero3 = float.Parse(Console.ReadLine());

    Console.WriteLine("\nFale o último numero: ");
    numero4 = float.Parse(Console.ReadLine());

    Console.WriteLine("Escolha uma Operação\n" +
        "1 = soma\n" +
        "2 = subtração\n" +
        "3 = multiplicação\n" +
        "4 = divisão\n" +
        "0 = finalizar\n ");
    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1){
        Console.WriteLine($"\nA Soma é: {numero1 + numero2 + numero3 + numero4} ");  
    }
    else if (escolha == 2){
        Console.WriteLine($"\nA Subtração é:  {numero1 - numero2 - numero3 - numero4}");
    }
    else if (escolha == 3){
        Console.WriteLine($"\nA multiplicação é:  {numero1 * numero2 * numero3 * numero4}");
    }
    else if(escolha == 4 && numero2 != 0 && numero3 != 0 && numero4 !=0){
        Console.WriteLine($"\nA divisão é:  {((numero1 / numero2)/numero3)/numero4}");
    }
    else if (numero2 == 0 || numero3 == 0 || numero4 == 0){
        Console.WriteLine("\nNão se divide por 0");
    }

} while (escolha != 0);




