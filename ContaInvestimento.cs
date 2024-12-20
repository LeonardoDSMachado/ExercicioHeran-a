﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1;

public class ContaInvestimento : Conta
{
    private decimal CalculaImposto(double imposto)
    {
        return Saldo * (decimal)Imposto;
    }

    public override double Juros { get; set; } = 0.009;
    public double Imposto { get; set; } = 0.001;
    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo = Saldo - valor - CalculaImposto(Imposto);
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente...");
            return Saldo;
        }
    }
}
