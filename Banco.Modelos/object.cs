using Banco;

namespace Banco
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class @object
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


        /// <summary>
        /// Cria uma instância de object com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da proprieddae <see cref="Agencia" /> e deve possuir um valor maior que zero.</param>
        /// <param name="numero">Representa o valor da proprieddae <see cref="Numero"/> e deve possuir um valor maior que zero.</param>
        /// <exception cref="ArgumentException"></exception>
        public @object(int agencia, int numero) 
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
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do saque, deve ser maior que zero e menor que <see cref="Saldo"/></param>
        /// <exception cref="ArgumentException">Exceçao lançada quando um valor negativo é utilizado no argumento valor <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceçao lancada quando um valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>.</exception>
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

        public void Transferir(double valor, @object contaDestino)
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

        public override bool Equals(object obj)
        {
            @object outraConta = obj as @object;

            if (outraConta == null) return false;
         
            return Numero == outraConta.Numero && Agencia == outraConta.Agencia;
        }
    }
}