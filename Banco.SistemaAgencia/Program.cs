

using Banco.Funcionarios;

namespace Banco.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)    
        {

            string url = "pagina?argumentos";

            Console.WriteLine(url);
            string argumento = url.Substring(6);
            Console.WriteLine(argumento);

            //DateTime dataFimDoPagamento = new DateTime(2022, 10, 22);
            //DateTime dataAtual = DateTime.Now;

            //TimeSpan diferenca = TimeSpan.FromMinutes(40);
            ////Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            

            //Console.WriteLine(dataAtual);
            //Console.WriteLine(dataFimDoPagamento);

            Console.ReadLine();
        }
        
    }
}
