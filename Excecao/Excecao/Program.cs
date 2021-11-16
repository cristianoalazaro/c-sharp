using System;

namespace Excecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine((n1 / n2).ToString());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Ocorreu um erro, não pode dividir por 0. {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Ocorreu um erro. {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fim da execução");
            }
        }
    }
}
