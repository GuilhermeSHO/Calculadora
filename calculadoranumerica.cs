
using System;

public class Calculo
{
    public double ValorA { get; set; }
    public double ValorB { get; set; }
    public double Resultado { get; private set; }

    public double CalcularSoma()
    {
        Resultado = ValorA + ValorB;
        return Resultado;
    }

    public double CalcularSubtracao()
    {
        Resultado = ValorA - ValorB;
        return Resultado;
    }

    public double CalcularMultiplicacao()
    {
        Resultado = ValorA * ValorB;
        return Resultado;
    }

    public double RetornarMaior()
    {
        return Math.Max(ValorA, ValorB);
    }

    public double SomarGeral(double valor)
    {
        return ValorA + ValorB + valor;
    }
}

public class Calculadora
{
    private Calculo calculo;

    public Calculadora()
    {
        calculo = new Calculo();
    }

    public void LerValores()
    {
        Console.Write("Digite o valor de A: ");
        calculo.ValorA = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        calculo.ValorB = double.Parse(Console.ReadLine());
    }

    public void ImprimirResultado()
    {
        Console.WriteLine($"O resultado é: {calculo.Resultado}");
    }

    public void ExecutarCalculadora()
    {
        while (true)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Maior valor");
            Console.WriteLine("5 - Somar com outro valor");
            Console.WriteLine("6 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    LerValores();
                    calculo.CalcularSoma();
                    ImprimirResultado();
                    break;
                case 2:
                    LerValores();
                    calculo.CalcularSubtracao();
                    ImprimirResultado();
                    break;
                case 3:
                    LerValores();
                    calculo.CalcularMultiplicacao();
                    ImprimirResultado();
                    break;
                case 4:
                    LerValores();
                    Console.WriteLine($"O maior valor é: {calculo.RetornarMaior()}");
                    break;
                case 5:
                    Console.Write("Digite o valor a ser somado: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A soma é: {calculo.SomarGeral(valor)}");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Calculadora calculadora = new Calculadora();
        calculadora.ExecutarCalculadora();
    }
}
