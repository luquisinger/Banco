﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private @object[] _itens;
        private int _proximaPosicao;
        public int TamanhoDaLista 
        { 
            get { return _proximaPosicao; } 
        }
        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new @object[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(@object item)
        {
            VerificaCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Add+ item na posição {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
        public @object GetItemNoIndice(int indice) 
        {
            if (indice < 0 || indice >= _proximaPosicao) throw new ArgumentOutOfRangeException();
            return _itens[indice];
        }
        public void Remover(@object item)
        {
            int indiceItem = -1;
            for(int i =0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for(int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }
        public void AdicionarVarios(params @object[] itens)
        {
            foreach (@object conta in itens)
            {
                Adicionar(conta);
            }
            //for(int i = 0; i < itens.Length;  i++) 
            //{
            //    Adicionar(itens[i]);
            //}
        }

        private void VerificaCapacidade(int tamanho)
        {
            if (_itens.Length >= tamanho)
            {
                return;
            }
            Console.WriteLine("aumentando o array");

            int novoTamanho = _itens.Length*2;
            if(novoTamanho < tamanho)
            {
                novoTamanho = tamanho;
            }
            @object[] novoArray = new @object[novoTamanho];
            
            for(int indice = 0; indice > _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }

        public @object this[int indice] 
        {
            get { return GetItemNoIndice(indice); }     
        }
    }
}
