// Escreva uma função que calcule o salário de um funcionário a partir salário-hora base, o total de horas trabalhadas e número de horas-extras executadas. Considere que cada hora-extra é paga com acréscimo de 40%.

double salarioHoraBase, totalHorasTrabalhadas, numHorasExtras, acrescimo, valorTotalcomacrescimo, vlorPagoTotal;

Console.WriteLine("bem vindo ao calculador de Horas extras ");
Console.Write("Qual o seu Salario/h base: ");
salarioHoraBase = Convert.ToDouble(Console.ReadLine());
Console.Write("Qual o total de horas trabalhadas: ");
totalHorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a quantidade de horas extras: ");
numHorasExtras = Convert.ToDouble(Console.ReadLine());

vlorPagoTotal = salarioHoraBase * totalHorasTrabalhadas;
acrescimo = (salarioHoraBase * numHorasExtras) * 1.40;

valorTotalcomacrescimo = vlorPagoTotal + acrescimo;

Console.Write(valorTotalcomacrescimo);