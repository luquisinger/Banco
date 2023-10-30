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
        static void Main(string[] args)
        {
            //CriarArquivo();
            //CriarArquivoComWriter();
            //TestaEscrita();
            //EscritaBinaria();
            //LeituraBinaria();
            File.WriteAllText("teste2.txt", "escrevendo...");

            var bytes = File.ReadAllBytes("contas.txt");
            Console.WriteLine(bytes.Length);

            var linhas = File.ReadAllLines("contas.txt");
            foreach (var line in linhas)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

            Console.WriteLine("Digite o seu nome");           
            var nome = Console.ReadLine();
            Console.WriteLine(nome);
            UsarStreamDeEntrada();
            Console.WriteLine("Aplicação finalizada...");
            Console.ReadLine();
        }

        //static void Ordeanar()
        //{
        //    var idades = new List<int>();
        //    idades.Add(5);


        //    idades.AdicionarVarios(6, 4, 5);
        //    idades.Sort();
        //    idades.Remove(5);

        //    var nomes = new List<string>()
        //    {
        //        "m,atgeyus",
        //        "sbdifv"
        //    };
        //    nomes.AdicionarVarios("joao", "grebio");
        //    foreach (var nome in nomes)
        //    {
        //        Console.WriteLine(nome);
        //    }

        //    var contas = new List<ContaCorrente>()
        //    {
        //        new ContaCorrente(123,123),
        //        null,
        //        new ContaCorrente(212,213),
        //        new ContaCorrente(21452,2173),
        //        new ContaCorrente(65612,45),
        //    };
        //    //var ListaSemNulos = new List<ContaCorrente>();
        //    //    foreach (var conta in contas)
        //    //    {
        //    //        if (conta != null)
        //    //        {
        //    //            ListaSemNulos.Add(conta);
        //    //        }
        //    //    }   

        //    //contas.Sort();
        //    //IOrderedEnumerable<ContaCorrente> listaOrdenada 
        //    //    = ContasNaoNulas.OrderBy<ContaCorrente, int>(conta => conta.Numero);
        //    var listaOrdenada = contas
        //         .Where(contas => contas != null)
        //         .OrderBy(conta => conta.Numero);

        //    //contas.Sort(new ComparadorContaCorrentePorAgencia());


        //    foreach (var conta in listaOrdenada)
        //    {
        //        Console.WriteLine($"a conta do n {conta.Numero} da agencia {conta.Agencia}");
        //    }

        //    //ListaExtensoes.AdicionarVarios(idades, 6,4,7);
        //    //idades.AdicionarVarios(8, 9, 10);
        //    //idades.AddRange(new int[] { 1, 2, 3, 4 });
        //    for (int i = 0; i < idades.Count; i++)
        //    {
        //        Console.WriteLine(idades[i]);
        //    }
        //}
        //static void TestaListaObject()
        //{
        //    ListaDeObject listaDeIdades = new ListaDeObject();
        //    listaDeIdades.AdicionarVarios(1, 2, 3, 4);
        //    for (int i = 0; i < listaDeIdades.TamanhoDaLista; i++)
        //    {
        //        int idade = (int)listaDeIdades[i];
        //        Console.WriteLine($"Idade non indice {i}: {idade}");
        //    }
        //}
        //static void TestaListaDeContaCorrente()
        //{
        //    ListaDeContaCorrente lista = new ListaDeContaCorrente();
        //    lista.Adicionar(new @object(874, 5679787));
        //    lista.Adicionar(new @object(874, 5679754));
        //    lista.Adicionar(new @object(874, 5679745));
        //    lista.Adicionar(new @object(874, 5679754));
        //    lista.Adicionar(new @object(874, 5679745));
        //    lista.Adicionar(new @object(874, 5679754));
        //    lista.Adicionar(new @object(874, 5679745));

        //    @object[] contas = new @object[]
        //    {

        //        new @object(874, 5679787),
        //        new @object(874, 5679754)
        //    };
        //    lista.AdicionarVarios(contas);
        //    lista.AdicionarVarios
        //        (
        //            new @object(874, 5679745),
        //            new @object(874, 5679754),
        //            new @object(874, 5679745)
        //        );
        //    static int SomarVarios(params int[] numeros)
        //    {
        //        int acumulador = 0;
        //        foreach (int numero in numeros)
        //        {
        //            acumulador += numero;
        //        }
        //        return acumulador;
        //    }

        //    for (int i = 0; i < lista.TamanhoDaLista; i++)
        //    {

        //        @object teste = lista[i];

        //        @object itemAtual = lista[i];
        //        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
        //    }

        //}
        //public static void TestaArray2()
        //{
        //    @object[] contas = new @object[]
        //    {
        //        new @object(123, 123),
        //        new @object(874, 4456668),
        //        new @object(874, 7781438)
        //     };



        //    for (int indice = 0; indice <= contas.Length; indice++)
        //    {
        //        @object conta = contas[indice];
        //        Console.WriteLine($"Conta {indice} = {conta.Numero}");
        //    }
        //}
        //public static void TestaArray()
        //{
        //    int[] idades = null;
        //    idades = new int[5];

        //    idades[0] = 15;
        //    idades[1] = 28;
        //    idades[2] = 35;
        //    idades[3] = 50;
        //    idades[4] = 28;

        //    int idade4 = idades[4];

        //    Console.WriteLine(idade4);

        //    int[] outroArray = idades;
        //    Console.WriteLine(idades[2]);

        //    //bool[] arrayBool = new bool[3];

        //    //arrayBool[0]=true;
        //    //arrayBool[1]=false;
        //    //arrayBool[2]=true;
        //    int valorTotalDoArray = 0;
        //    for (int indice = 0; indice <= idades.Length; indice++)
        //    {
        //        int idade = idades[indice];
        //        Console.WriteLine($"Acessando o array idades no indice: {indice}");
        //        Console.WriteLine($"vlr de idades[{indice}] ={idade} ");
        //        valorTotalDoArray = valorTotalDoArray + idade;
        //    }

        //    int media = valorTotalDoArray / idades.Length;
        //    Console.WriteLine($"Média de idades = {media}");
        //}
        //public static void MRegex() 
        //{
        //    Cliente carlos_1 = new Cliente();
        //    carlos_1.Nome = "Carlos";
        //    carlos_1.CPF = "458.623.120-03";
        //    carlos_1.Profissao = "Designer";

        //    Cliente carlos_2 = new Cliente();
        //    carlos_2.Nome = "Carlos";
        //    carlos_2.CPF = "458.623.120-03";
        //    carlos_2.Profissao = "Designer";

        //    if (carlos_1.Equals(carlos_2))
        //    {
        //        Console.WriteLine("São iguais!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Não são iguais!");
        //    }
        //}
        //public static void RestoDoCodigo()
        //{
        //    // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
        //    // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
        //    // string padrao = "[0-9]{4,5}[-][0-9]{4}";
        //    // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
        //    // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
        //    string padrao = "[0-9]{4,5}-?[0-9]{4}";
        //    string textoDeTeste = "ajgdjgjagsygaugsa 8751-5456 aygsygsygua auyakjskjs";

        //    Match resultado = Regex.Match(textoDeTeste, padrao);

        //    Console.WriteLine(resultado.Value);
        //    Console.ReadLine();


        //    string urlTeste = "https://www.bytebank.com/cambio";
        //    int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

        //    Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
        //    Console.WriteLine(urlTeste.EndsWith("cambio"));
        //    Console.WriteLine(urlTeste.Contains("bytebank"));


        //    string mensagem = "PALAVRA";
        //    string termoBusca = "ra";

        //    Console.WriteLine(mensagem.ToLower());


        //    string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

        //    ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

        //    Console.WriteLine("Valor de moedaDestino " + extrator.GetValor("moedaDestino"));


        //    //string testeRemocao = "primeiraParte&parteParRemover";
        //    //int indiceEComercial = testeRemocao.IndexOf('&');
        //    //Console.WriteLine(testeRemocao.Remove(indiceEComercial));

        //    //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

        //    //int indiceInterrogacao = url.IndexOf('?');  
        //    //Console.WriteLine(url);
        //    //string argumento = url.Substring(indiceInterrogacao + 1);
        //    //Console.WriteLine(argumento);

        //    //DateTime dataFimDoPagamento = new DateTime(2022, 10, 22);
        //    //DateTime dataAtual = DateTime.Now;

        //    //TimeSpan diferenca = TimeSpan.FromMinutes(40);
        //    ////Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);



        //    //Console.WriteLine(dataAtual);
        //    //Console.WriteLine(dataFimDoPagamento);
        //}

    }
}
