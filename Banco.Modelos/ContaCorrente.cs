using Banco;

namespace Banco
{
    ///<sumary>
    /// Define uma Conta Corrente do banco ByteBank.
    ///</sumary>
    public class ContaCorrente : IComparable
    {
        public static double TaxaOperacao {  get; private set; }
        public Cliente Titular {  get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorTransferenciasNaoPermitidas {  get; private set; }
        public int Numero { get; }
        public int Agencia { get; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
     
        private double _saldo = 100;
        public double Saldo
        {
            get { return _saldo; }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        ///<summary>
        ///Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// <summary>
        ///<param name="agencia">Representa o valor da proprieddae <see cref="Agencia" /> e deve possuir um valor maior que zero.</param>
        ///<param name="numero">Representa o valor da proprieddae <see cref="Numero"/> e deve possuir um valor maior que zero.</param>
        public ContaCorrente(int agencia, int numero) 
        {

            if(agencia <= 0) 
            {

                throw new ArgumentException("A agencia deve serer maior que zero", nameof(agencia));    
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que zero", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a transferencia.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }

        public int CompareTo(object? obj)
        {
            // Retornar negativo quando a instância precede o obj
            // Retornar zero quando nossa instância e obj forem equivalentes;
            // Retornar positivo diferente de zero quando a precedência for de obj;
            var outraConta = obj as ContaCorrente;
            if (outraConta == null) return -1;
            if(Numero < outraConta.Numero)
            {
                return -1;
            } else if (Numero > outraConta.Numero) { return 1; }
            else {  return 0; }

        }
    }
}