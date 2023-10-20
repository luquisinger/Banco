using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() 
        {
        
        }
        public OperacaoFinanceiraException(string mensagem) 
            : base(mensagem) 
        {
        
        }
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {
            
        }
    }
}
