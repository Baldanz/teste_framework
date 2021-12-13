using System;
using System.Linq;
using System.Text;

namespace TesteFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            string Numero = Console.ReadLine();

            // condição para efetuar os cálculos dos divisores e números primos
            if (String.IsNullOrEmpty(Numero.ToString()) == Numero.ToString().All(char.IsDigit) == false)
            {
                StringBuilder Sequencial = new Calculo().CalcularDivisores(int.Parse(Numero));
                Console.WriteLine(Sequencial.ToString());
            }
            else
            {
                Console.WriteLine("Não foi possível efetivar o cálculo. Refaça a operação!");
            }
            Console.ReadKey();
        }
    }
}