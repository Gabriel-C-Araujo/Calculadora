using System;

public class Class1
{
    public Class1()
    {
        static void Main(string[] args)
        {
            int numero_1 = 0;
            int numero_2 = 0;
            bool repetir = true;
            int resultado = 0;
            string continua = "";


            while (repetir)
            {
                Console.WriteLine("Digite a operação desejada: ' + ' , ' - ' , ' * ' , ' / ' ");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "+":
                        {
                            Console.WriteLine("Digite o numero 1");
                            numero_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o numero 2");
                            numero_2 = Convert.ToInt32(Console.ReadLine());
                            resultado = numero_1 + numero_2;
                            Console.WriteLine("O resultado é: " + resultado);
                        }
                        break;

                    case "-":
                        {
                            Console.WriteLine("Digite o numero 1");
                            numero_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o numero 2");
                            numero_2 = Convert.ToInt32(Console.ReadLine());
                            resultado = numero_1 - numero_2;
                            Console.WriteLine("O resultado é: " + resultado);
                        }
                        break;

                    case "*":
                        {
                            Console.WriteLine("Digite o numero 1");
                            numero_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o numero 2");
                            numero_2 = Convert.ToInt32(Console.ReadLine());
                            resultado = numero_1 * numero_2;
                            Console.WriteLine("O resultado é: " + resultado);
                        }
                        break;

                    case "/":
                        {
                            Console.WriteLine("Digite o numero 1");
                            numero_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o numero 2");
                            numero_2 = Convert.ToInt32(Console.ReadLine());
                            resultado = numero_1 / numero_2;
                            Console.WriteLine("O resultado é: " + resultado);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Digite uma operação valida");
                        }
                        break;
                }

                Console.WriteLine("Você deseja continuar? S/N");
                continua = Console.ReadLine();

                if (continua.ToUpper() == "S")
                {
                    repetir = true;
                }
                if (continua.ToUpper() == "N")
                {
                    repetir = false;
                }

            }
        }
    }
}
