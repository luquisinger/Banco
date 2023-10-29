using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.SistemaAgencia.Comparador
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            return x.Agencia.CompareTo(y.Agencia);
            //y=x vai return 0
            //y>x return -1
            //y<x return 1
        }
    }
}
