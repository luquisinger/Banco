using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public string Nome {  get; set; }
        public string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        public override bool Equals(object? obj)
        {
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null) return false;

            return CPF == outroCliente.CPF; 
                
        }
    }
}
