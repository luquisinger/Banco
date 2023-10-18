using Banco.Funcionarios;
using Banco.Sistemas;
using System.Security.Authentication;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();

            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            //Funcionario funcionaria1 = new Funcionario(3000, "3424.34.23342");
            //funcionaria1.Nome = "Airine";

            //funcionaria1.AumentarSalario();
            //Console.WriteLine("Salario: "+funcionaria1.Salario);
            //gerenciador.Registrar(funcionaria1);
            //Console.WriteLine("A funcionaria " + funcionaria1.Nome + " ganha: " + funcionaria1.GetBonificacao());


            //Diretor diretor1 = new Diretor( "344.34.233-42");
            //diretor1.Nome = "Robrry";
            //diretor1.AumentarSalario();
            //Console.WriteLine("Salario: " + diretor1.Salario);
            //gerenciador.Registrar(diretor1);
            //Console.WriteLine("O diretor " + diretor1.Nome + " ganha: " + diretor1.GetBonificacao());
            //Console.WriteLine("O total pago em bonificacoes é " + gerenciador.GetTotalBonificacao());
            //Console.WriteLine("Funcionarios: " + Funcionario.TotalDeFuncionarios);

            //ContaCorrente contaMatheus = new ContaCorrente(001, 29000 - 9);
            //Cliente cliente = new Cliente();
            //cliente.Nome = "Matheus";
            //cliente.Profissao = "Desenvolvedor C#";
            //cliente.CPF = "04543243432";

            //contaMatheus.Titular = cliente;

            //contaMatheus.Saldo = 100;


            //Console.WriteLine("antigo cpf do Cliente: " + contaMatheus.Titular.CPF);

            //contaMatheus.Titular.CPF = "324243242";
            //Console.WriteLine(ContaCorrente.NumeroDeContas);
            //Console.WriteLine("Nome do Cliente: " + contaMatheus.Titular.Nome);
            //Console.WriteLine("novo cpf do Cliente: " + contaMatheus.Titular.CPF);
            //Console.WriteLine("Saldo do Cliente: " + contaMatheus.Saldo);

            //bool resultadoSaque = contaDoBruno.Sacar(500);


            //contaDoBruno.Depositar(500);
            //Console.WriteLine(contaDoBruno.saldo);

            //ContaCorrente contaDaGabriela = new ContaCorrente();

            //contaDoBruno.Transferir(200, contaDaGabriela);


            //Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1234";

            sistemaInterno.Logar(parceiro, "1234");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

           


        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}