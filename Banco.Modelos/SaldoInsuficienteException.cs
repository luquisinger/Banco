﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this("Saldo insuficiente para o saque no valor de: " + valorSaque + " Em uma conta com saldo de: " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem) 
        {

        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {

        }

    }
}
