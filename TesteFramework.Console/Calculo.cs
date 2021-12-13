using System.Collections.Generic;
using System.Text;

namespace TesteFramework
{
    public class Calculo
    {
        #region métodos

        private StringBuilder CalcularPrimos(List<int> Divisores)
        {
            // declaração de variáveis
            StringBuilder SequencialPrimos = new StringBuilder()
                .AppendLine("")
                .AppendLine("Divisores Primos");
            bool ehPrimo = true;

            // laço para identificar os números divisores
            foreach (int num in Divisores)
            {
                // contador para buscar os divisores
                for (int i = 0; i <= num; i++)
                {
                    if ((i == 0) || (i == num) || (i == 1))
                    {
                        continue;
                    }
                    else
                    {
                        // laço para encontrar os divisores primos dos divisores do número informado
                        for (int j = i; j < num; j++)
                        {
                            if (num % j == 0)
                            {
                                ehPrimo = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                // identificação dos números primos dos divisores do número informado
                if (ehPrimo)
                    SequencialPrimos.AppendLine(num.ToString());
            }

            return SequencialPrimos;
        }


        /// <summary>
        /// calcula os dividisores do número informado
        /// </summary>
        /// <param name="Numero">número informado para efetivar o cálculo dos divisores</param>
        /// <returns>retorna o sequencial de divisores do número informado</returns>
        public StringBuilder CalcularDivisores(int Numero)
        {
            // bloco de variáveis
            StringBuilder SequencialDivisores = new StringBuilder()
                .AppendLine("")
                .AppendLine("Números Divisores");
            List<int> divisores = new List<int>();

            // neste ponto, vamos encontrar os divisores do número informado
            for (int i = 1; i <= Numero; i++)
            {
                // implementa o cálculo que identifica se o número é divisor dele, sendo o resto da divisão igual a zero
                int divisor = (Numero % i);

                // se o resto da divisão for zero, então encontramos o divisor
                if (divisor == 0)
                {
                    // monta a sequencia
                    divisores.Add(i);
                    SequencialDivisores.AppendLine(string.Join(',', i.ToString()));
                }
            }
            SequencialDivisores.AppendLine(CalcularPrimos(divisores).ToString());
            return SequencialDivisores;
        }

        #endregion
    }
}
