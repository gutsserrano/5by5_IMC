// Faça um programa que leia o peso, altura e sexo de uma pessoa e calcule o seu IMC
// informando a situação da pessoa (taxas e etc)

float altura, peso, imc;
char sex;
int option;

do
{
    do
    {
        Console.WriteLine("Digite seu peso:");
        peso = float.Parse(Console.ReadLine());

        if(peso <= 0)
        {
            Console.WriteLine("\nPeso deve ser maior que zero!\n");
        }
    }while (peso <= 0);

    do
    {
        Console.WriteLine("Digite sua altura em cm:");
        altura = float.Parse(Console.ReadLine());

        if (altura <= 0)
        {
            Console.WriteLine("\nAltura deve ser maior que zero!\n");
        }
    } while (altura <= 0);

    do
    {
        Console.WriteLine("Sexo (M/F):");
        sex = char.Parse(Console.ReadLine());
    } while (sex != 'M' && sex != 'F');

    altura /= 100;
    imc = peso / (altura * altura);

    Console.WriteLine($"\nseu IMC: {imc}");

    if (sex == 'M')
    {
        if (imc < 20)
        {
            Console.WriteLine("Classificação: abaixo do peso\n");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Classificação: peso ideal\n");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Classificação: sobrepeso\n");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Classificação: obesidade moderada\n");
        }
        else
        {
            Console.WriteLine("Classificação: obesidade mórbida\n");
        }
    }
    else
    {
        if (imc < 19)
        {
            Console.WriteLine("Classificação: abaixo do peso\n");
        }
        else if (imc < 24)
        {
            Console.WriteLine("Classificação: peso ideal\n");
        }
        else if (imc < 29)
        {
            Console.WriteLine("Classificação: sobrepeso\n");
        }
        else if (imc < 39)
        {
            Console.WriteLine("Classificação: obesidade moderada\n");
        }
        else
        {
            Console.WriteLine("Classificação: obesidade mórbida\n");
        }
    }

        do
    {
        Console.WriteLine("\nDeseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);
