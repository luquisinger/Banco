using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.SistemaAgencia
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var sr = new BinaryWriter(fs)) 
            {
                sr.Write(324);
                sr.Write(32424);
                sr.Write(4000.50);
                sr.Write("Matheus");
            }            
        }
        static void LeituraBinaria()
        { 
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{conta} {titular} {saldo}");
            }


        }
    }
}
