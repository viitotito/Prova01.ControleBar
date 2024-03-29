﻿using Prova01.ControleBar.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01.ControleBar.Módulo_Produto
{
     internal class NegocioProduto : EntidadeBase
     {

          private string nomeProduto, unidadesMedida;
          private int quantidadeProduto = 0;
          private double precoProduto;

          public string NomeProduto { get { return nomeProduto; } set { nomeProduto = value; } }

          public int QuantidadeProduto { get { return quantidadeProduto; } set { quantidadeProduto = value; } }

          public double PrecoProduto { get { return precoProduto; } set { precoProduto = value; } }

          public string UnidadesMedida { get { return unidadesMedida; } set { unidadesMedida = value; } }

          public NegocioProduto(string nomeProduto, double precoProduto, string unidadesMedida)
          {
               this.nomeProduto = nomeProduto;
               this.precoProduto = precoProduto;
               this.unidadesMedida = unidadesMedida;
          }

          public NegocioProduto(string nomeProduto, int quantidadeProduto, double precoProduto, string unidadesMedida)
          {
               this.nomeProduto = nomeProduto;
               this.quantidadeProduto = quantidadeProduto;
               this.precoProduto = precoProduto;
               this.unidadesMedida = unidadesMedida;
          }

          public override void AtualizarRegistros(EntidadeBase registroAtualizado)
          {
               NegocioProduto produto = (NegocioProduto)registroAtualizado;

               nomeProduto = produto.NomeProduto;
               quantidadeProduto = produto.quantidadeProduto;
               precoProduto = produto.precoProduto;
               unidadesMedida = produto.unidadesMedida;
          }

          public override ArrayList ValidarErros()
          {
               ArrayList listaErros = new ArrayList();
               return listaErros;
          }

          public void EntrarQuantidade()
          {

          }
     }
}
