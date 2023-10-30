using Banco.Funcionarios;
using Banco.SistemaAgencia.Comparador;
using Banco.SistemaAgencia.Extensoes;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
namespace Banco.SistemaAgencia
{
    partial class LeitorDeStreams
    {
        public void LeitorStreams()
        { 
            var enderecoDoArquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))                
            {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var ContaCorrente = ConverteStringContaCorrente(linha);
                        var msg = $"A conta {ContaCorrente.Numero} da agencia {ContaCorrente.Agencia} tem o titular {ContaCorrente.Titular.Nome} e o saldo {ContaCorrente.Saldo}";
                        Console.WriteLine(msg);
                    }

                        Console.ReadLine();

            }
     }
        static ContaCorrente ConverteStringContaCorrente(string linha)
        {
            var campos = linha.Split(",");

            var numero = campos[0];
            var agencia = campos[1];
            var saldo = campos[2].Replace(".", ",");
            string titularNome = campos[3];

            int numeroInt = int.Parse(numero);
            int agenciaInt = int.Parse(agencia);
            double saldoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = titularNome;


            var resultado = new ContaCorrente(numeroInt, agenciaInt);
            resultado.Saldo = saldoDouble;
            resultado.Titular = titular;

            return resultado;
        }      }
}
