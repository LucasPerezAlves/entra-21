﻿using Entra21.ExemplosOrientaçãoObjetos.Produtos;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExemplosOrientaçãoObjetos.Testes.Produtos
{
    public class ProdutoTests
    {
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()
        {
            //Arrange (preparar os dados)
            var produto = new Produto();
            produto.DataVencimento = new DateTime(2022, 05, 04); //=DateTime.Today.AddDays(-1); Mesma coisa

            // Act (Ato da execução do métidi que deseja testar
            var produtoVencido = produto.EhVencido();

            //Assert (Validação do que foi gerado
            produtoVencido.Should().BeTrue();

            // produtoVencido.Should().Be(true); mesma coisa que na primeira

        }

        [Fact]
        public void Validar_EhVencido_com_DataVencimento_Maior_Hoje()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            //Act
            var vencido = produto.EhVencido();

            //Assert
            vencido.Should().BeFalse();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //act
            var vencido = produto.EhVencido();

            //Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            //Act
            var emPromocao = produto.EstaEmPromocao();

            //Assert
            emPromocao.Should().BeTrue();
        }
        
        [Fact]
        public void Validar_EstaEmPromocao_Falso()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //Act
            var emPromocao = produto.EstaEmPromocao();

            //Assert
            emPromocao.Should().BeFalse();
        }
    }
}
