using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto - Calculando Poupança: \r\n");

            double valorinvestido = 1000.0;
            int contadormes = 1;

            while (contadormes <= 12)
            {
                // O fator de investimento é de 0,36% que foi convetido para a conta
                valorinvestido = valorinvestido + valorinvestido * 0.0036;
                Console.WriteLine("Após " + contadormes + " meses você terá R$ " + valorinvestido + " na poupança.");

                contadormes++;
                // Seria a mesma coisa se eu fizesse: contadormes += 1;
                // Seria a mesma coisa se eu fizesse: contadormes = contadormes + 1;
            }

            Console.ReadLine();
        }
    }
}
