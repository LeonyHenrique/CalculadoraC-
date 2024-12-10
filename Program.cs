using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("====== Bem-vindo à Calculadora ======");
        Console.WriteLine("=====================================");
        Console.ResetColor();
        bool continuar = true;

        while (continuar)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n============================");
            Console.WriteLine("\n    Escolha uma operação     ");
            Console.WriteLine("\n============================");
            Console.ResetColor();
            Console.WriteLine("[1] Adição (+)");
            Console.WriteLine("[2] Subtração (-)");
            Console.WriteLine("[3] Multiplicação (*)");
            Console.WriteLine("[4] Divisão (/)");
            Console.WriteLine("[5] Sair");
            Console.WriteLine("============================");
            Console.Write("Digite a opção desejada (1-5): ");
            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar a calculadora! Até mais!");
                break;
            }

            switch (opcao)
            {
                case "1":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você escolheu adição.");
                Console.ResetColor();
                double numero1;
                Console.Write("Digite o primeiro número que deseja somar :                 -");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                  ou digite 0 para voltar ao menu ");
                Console.ResetColor();
                    if (!double.TryParse(Console.ReadLine(), out numero1) || numero1 == 0)
                    {
                        if (numero1 == 0)
                        {
                            Console.WriteLine("Voltando ao menu principal.");
                            break;
                        }
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }

                    Console.Write("Digite o segundo número que deseja somar: ");
                    if (!double.TryParse(Console.ReadLine(), out double numero2))
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }
                    double resultadoAdicao = numero1 + numero2;
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultadoAdicao}");
                    break;


                case "2":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você escolheu subtração.");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número que deseja subtrair :                 -");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                  ou digite 0 para voltar ao menu ");
                    Console.ResetColor();
                    if (!double.TryParse(Console.ReadLine(), out numero1) || numero1 == 0)
                    {
                        if (numero1 == 0)
                        {
                            Console.WriteLine("Voltando ao menu principal.");
                            break;
                        }
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }

                    Console.Write("Digite o segundo número que deseja subtrair: ");
                    if (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }
                    double resultadoSubtracao = numero1 - numero2;
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultadoSubtracao}");
                    break;


                case "3":
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você escolheu multiplicação.");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número que deseja multiplicar :                 -");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                  ou digite 0 para voltar ao menu ");
                    Console.ResetColor();
                    if (!double.TryParse(Console.ReadLine(), out numero1) || numero1 == 0)
                    {
                        if (numero1 == 0)
                        {
                            Console.WriteLine("Voltando ao menu principal.");
                            break;
                        }
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }

                    Console.Write("Digite o segundo número que deseja multiplicar: ");
                    if (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }
                    double resultadoMultiplicacao = numero1 * numero2;
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultadoMultiplicacao}");
                    break;


                case "4":
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você escolheu divisão.");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número que deseja dividir :                 -");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                  ou digite 0 para voltar ao menu ");
                    Console.ResetColor();
                    if (!double.TryParse(Console.ReadLine(), out numero1) || numero1 == 0)
                    {
                        if (numero1 == 0)
                        {
                            Console.WriteLine("Voltando ao menu principal.");
                            break;
                        }
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }

                    Console.Write("Digite o segundo número que deseja dividir: ");
                    if (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                        continue;
                    }

                    if (numero2 != 0)
                    {
                        double resultadoDivisao = numero1 / numero2;
                        Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultadoDivisao}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida!");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
