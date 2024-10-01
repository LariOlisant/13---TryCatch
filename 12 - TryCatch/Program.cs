//Exemplo de TryCatch com numerador e denominador
//O bloco try-catch em c# permite que você execute um bloco de código
//(try) que pode gerar excessões. Se uma excessão ocorrer, ela irá ser tratada no bloco catch

/*Exemplo 1 com valores inteiros*/

//try
//{
//    Console.Write("Digite o numerador: "); // string "5" == 5
//    int numerador = int.Parse(Console.ReadLine());

//    Console.Write("Digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int resultado = numerador / denominador;
//    Console.WriteLine($"O resultado da divisão é: {resultado}");
//} catch(DivideByZeroException)
//{
//    Console.WriteLine("Erro: Não é possível dividir por zero");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Erro: Por favor, digite números válidos");
//}

/* Exemplo 2 com asas decimais utilizando Double e convertendo esses valores com o TryParse */

using System.Globalization;

try
{
    Console.Write("Digite o numerador: "); // string "5" == 5
    double numerador;
    // ! - significa diferente//
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))
    {
        Console.WriteLine("Erro: Por favor, digite um número válido.");
        Console.Write("Digite o numerador: ");
    }

    Console.Write("Digite o denominador: ");
    double denominador = int.Parse(Console.ReadLine());

    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("Erro: Por favor, digite um número válido.");
        Console.Write("Digite o denominador: ");
    }

    double resultado = numerador / denominador;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possível dividir por zero");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
Console.ReadKey();
