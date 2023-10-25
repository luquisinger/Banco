using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        { 
            if (string.IsNullOrEmpty(url)) throw new ArgumentException("o argumento url nao pode ser uma strign vazia ou nula.", nameof(url));
            

            int indiceInterrogacao = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogacao + 1);
            URL = url;
        }
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); //valor
            string termo = nomeParametro + "="; // moedaDestino=
            string argumentoGrande = _argumentos.ToUpper(); //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR
            int indiceTermo = argumentoGrande.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');
            if (indiceEComercial == -1)
            {
                return resultado;
            }
           

            return resultado.Remove(indiceEComercial);
        }
           
    }
}
