namespace Calculadora;

class program
{
    static void Main(String[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicacao");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção:");
        var opcao = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int primeiroValor = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo valor: ");
        int segundoValor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{primeiroValor} + {segundoValor} = {primeiroValor + segundoValor}");
        Console.ReadKey();
        Menu();
    }
    
    static void Subtracao()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int primeiroValor = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo valor: ");
        int segundoValor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{primeiroValor} - {segundoValor} = {primeiroValor - segundoValor}");
        Console.ReadKey();
        Menu();
    }
    
    static void Multiplicacao()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int primeiroValor = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo valor: ");
        int segundoValor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{primeiroValor} x {segundoValor} = {primeiroValor * segundoValor}");
        Console.ReadKey();
        Menu();
    }
    
    static void Divisao()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int primeiroValor = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo valor: ");
        int segundoValor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{primeiroValor} / {segundoValor} = {primeiroValor / segundoValor}");
        Console.ReadKey();
        Menu();
    }
}