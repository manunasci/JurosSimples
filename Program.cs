using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salario: ");
            string valordoSalario = Console.ReadLine();
            double numerodoSalario = Double.Parse(valordoSalario);

            Console.WriteLine();

            Console.Write("Digite a taxa do juros: ");
            string valordaTaxa = Console.ReadLine();
            double numerodaTaxa = Double.Parse(valordaTaxa);

            Console.WriteLine();

            Console.Write("Digite o tempo em meses: ");
            string valordoTempo = Console.ReadLine();
            double numerodoTempo= Double.Parse(valordoTempo);

            double valordoJuros = numerodoSalario*(numerodaTaxa/100)*numerodoTempo;
            double valordoMontante = numerodoSalario + valordoJuros;

            Console.WriteLine();

            Console.WriteLine("Juros (R$): " + valordoJuros);
            Console.WriteLine("Montante (R$): " + valordoMontante);
        }
    }
}
