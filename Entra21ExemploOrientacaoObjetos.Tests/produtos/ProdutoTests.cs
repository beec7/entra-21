using Entra21.ExemploOrientaocaoObjetos.produto;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExemploOrientacaoObjetos.Tests.produtos
{
    public class ProdutoTests
    {
        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Menor_Hojr()
        {
            var produto = new Produto();

            produto.DataVencimento = DateTime.Today.AddDays(-1);

            var produtoVencimento = produto.EhVencido();

            produtoVencimento.Should().BeTrue();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            //Arrange

            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeFalse();
        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeTrue();
        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdadeiro()
        {
            // Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            // Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeTrue();

        }
        
        [Fact]
        public void Validar_EstaEmPromocao_False()
        {
            //Arrang
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            // Act
            var emPromocao = produto.EstaEmPromocao();

            //Assert
            emPromocao.Should().BeFalse();
        }
    }

    
}
