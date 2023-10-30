using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.SistemaAgencia
{
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            using (var fe = Console.OpenStandardInput())
            using (var fs = new FileStream("saidaConsole.txt", FileMode.Create))
            {
                
                  var buffer = new byte[1024];
                  while (true)
                  {                   
                        var bytesLidos = fe.Read(buffer, 0, 1024);
                        fs.Write(buffer, 0, bytesLidos);

                        fs.Flush();
                        Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                  }
             }
        }
        
    }
}
