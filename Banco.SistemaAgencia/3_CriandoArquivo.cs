using Banco.SistemaAgencia;
using Banco.Funcionarios;
using Banco.SistemaAgencia.Comparador;
using Banco.SistemaAgencia.Extensoes;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

namespace Banco.SistemaAgencia
{
     partial class Program
    { 
        public static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "213,2133,23413,Matheus";
                
                var bytes = Encoding.UTF8.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                escritor.Write("154,13565,452.5,Matheus");
            }
        }
        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "teste1.csv";
            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    escritor.Flush(); //despeja o escriyor para o stream
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }
    }
}
