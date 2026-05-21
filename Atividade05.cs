/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 
Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();*/

/*static void ExecutarSistema()
{

    static void TextoMenu()
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("/ Divisão");
    }
    static string SelecionarOpcao()
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("/ Divisão");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine()!;
        return opcao;
    }
    static double LerNumero1()
    {
        Console.WriteLine("Digite o primeiro número: ");
        return double.Parse(Console.ReadLine()!);

    }
    static double LerNumero2()
    {
        Console.WriteLine("Digite o segundo número: ");
        return double.Parse(Console.ReadLine()!);

    }
    static double CalcularOperacao(double numero1, double numero2, string opcao)
    {
        double resultado = 0;
        if (opcao == "+")
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
        else if (opcao == "-")
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"Resultado da subtração: {resultado}");
        }
        else if (opcao == "*")
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
        else if (opcao == "/")
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
        return resultado;
    }
    static void ExibirResumo(string operação, double numero1, double numero2, double resultado)
    {
        Console.WriteLine($"Operação: {operação}");
        Console.WriteLine($"Número 1: {numero1}");
        Console.WriteLine($"Número 2: {numero2}");
        Console.WriteLine($"Resultado: {resultado}");
    }
    static void Menu()
    {

        string continuar = "s";
        while (continuar == "s" || continuar == "S")
        {
            string opcao = SelecionarOpcao();
            double numero1 = LerNumero1();
            double numero2 = LerNumero2();
            double resultado = CalcularOperacao(numero1, numero2, opcao);
            ExibirResumo(opcao, numero1, numero2, resultado);
            Console.WriteLine();
            Console.Write("Deseja fazer outro cálculo? (s/n): ");
            continuar = Console.ReadLine()!;
        }

        Console.Write("Fim de programa!!");
    }
    TextoMenu();
    Menu();
}

ExecutarSistema(); */