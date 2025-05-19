// Escreva uma função que calcule o salário de um funcionário a partir salário-hora base, o total de horas trabalhadas e número de horas-extras executadas. Considere que cada hora-extra é paga com acréscimo de 40%.
using System;
using System.Net.WebSockets;

namespace HorasExtras
{
    class Program {
        static void Main(string[] args)
        {
            double salarioHoraBase, totalHorasTrabalhadas, numHorasExtras;

            Console.WriteLine("bem vindo ao calculador de Horas extras ");
            Console.Write("Qual o seu Salario/h base: ");
            salarioHoraBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o total de horas trabalhadas: ");
            totalHorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade de horas extras: ");
            numHorasExtras = Convert.ToDouble(Console.ReadLine());

            // Chamada da função para calcular o salário total
            double valorTotalComAcrescimo = SalarioCalculo(salarioHoraBase, totalHorasTrabalhadas, numHorasExtras);

            Console.WriteLine($"O valor total a ser pago é: R$ {valorTotalComAcrescimo:F2}");


        }
        static double SalarioCalculo(double salarioHoraBase, double totalHorasTrabalhadas, double numHorasExtras)
        {
            double vlHorasnormais = salarioHoraBase * totalHorasTrabalhadas;
            double vlHorasExtras = salarioHoraBase * numHorasExtras * 1.40;
            double vlorPagoTotal = vlHorasExtras + vlHorasnormais;
            return vlorPagoTotal;
        }   
    }    
}

