using System;
using System.Globalization;

namespace Salario;

public class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        double salario, reajuste, percentual, NovoSalario;

        Console.WriteLine("Digite o salario atual do funcionario");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Agora por favor, digite o percentual de reajuste deste salario");
        percentual = double.Parse(Console.ReadLine());

        reajuste = salario / 100 * percentual;
        NovoSalario = reajuste + salario;

        Console.WriteLine("O salario reajustado deste funcionario é de R$" + NovoSalario.ToString("F2", CI));
    }
}