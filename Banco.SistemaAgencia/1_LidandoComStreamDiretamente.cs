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
        static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {

                var Buffer = new byte[1024];

                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(Buffer, 0, 1024);

                    EscreverBuffer(Buffer, numeroDeBytesLidos);
                }
            }
            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] Buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();
            var txt = utf8.GetString(Buffer, 0, bytesLidos);
            Console.Write(txt);

            //foreach (var meuByte in Buffer) 
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}

        }
    }
}