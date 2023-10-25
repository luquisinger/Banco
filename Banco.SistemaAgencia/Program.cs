

using Banco.Funcionarios;
using System.Text.RegularExpressions;

namespace Banco.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 15;


            Console.ReadLine();
        }

        public static void Regex() 
        {
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
        }
        public static void RestoDoCodigo()
        {
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "ajgdjgjagsygaugsa 8751-5456 aygsygsygua auyakjskjs";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));


            string mensagem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagem.ToLower());


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            Console.WriteLine("Valor de moedaDestino " + extrator.GetValor("moedaDestino"));


            //string testeRemocao = "primeiraParte&parteParRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');  
            //Console.WriteLine(url);
            //string argumento = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumento);

            //DateTime dataFimDoPagamento = new DateTime(2022, 10, 22);
            //DateTime dataAtual = DateTime.Now;

            //TimeSpan diferenca = TimeSpan.FromMinutes(40);
            ////Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);



            //Console.WriteLine(dataAtual);
            //Console.WriteLine(dataFimDoPagamento);
        }
    }
}
