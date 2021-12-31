using Microsoft.VisualStudio.TestTools.UnitTesting;
using Second;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second.Tests
{
    [TestClass()]
    public class SecondTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            //Arrange(Organizar): inicializando os objetos e
            //definindo o valor dos dados que serão passados para o
            //método a ser testado
            var x = 2;
            var y = 3;
            var esperado = 5;
            var second = new Second();

            //Act(agir): vai invocar o método a ser testado
            //com os parâmetros
            var resultado = second.Soma(x , y);

            //Assert(Declarar): vai verificar se a ação do método
            //a ser testado
            //se comporta como a gente esperava
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            //Arrange(Organizar): inicializando os objetos e
            //definindo o valor dos dados que serão passados para o
            //método a ser testado
            var x = 2;
            var y = 3;
            var esperado = -1;
            var second = new Second();

            //Act(agir): vai invocar o método a ser testado
            //com os parâmetros
            var resultado = second.Subtracao(x, y);

            //Assert(Declarar): vai verificar se a ação do método
            //a ser testado
            //se comporta como a gente esperava
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
                //Arrange(Organizar): inicializando os objetos e
                //definindo o valor dos dados que serão passados para o
                //método a ser testado
                var x = 2;
                var y = 3;
                var esperado = 6;
                var second = new Second();

                //Act(agir): vai invocar o método a ser testado
                //com os parâmetros
                var resultado = second.Multiplicacao(x, y);

                //Assert(Declarar): vai verificar se a ação do método
                //a ser testado
                //se comporta como a gente esperava
                Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
                //Arrange(Organizar): inicializando os objetos e
                //definindo o valor dos dados que serão passados para o
                //método a ser testado
                var x = 2;
                var y = 1;
                var esperado = 2;
                var second = new Second();

                //Act(agir): vai invocar o método a ser testado
                //com os parâmetros
                var resultado = second.Divisao(x, y);

                //Assert(Declarar): vai verificar se a ação do método
                //a ser testado
                //se comporta como a gente esperava
                Assert.AreEqual(esperado, resultado);
        }
    }
}