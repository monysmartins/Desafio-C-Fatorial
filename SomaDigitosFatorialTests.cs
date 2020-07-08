using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iniciando;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDigitos.Tests
{
    [TestClass()]
    public class SomaDigitosFatorialTests
    {
        [TestMethod()]
        public void Calcula_QuandoInformaNumero_RetornaSomatorioFatorial()
        {
            //Arrange
            SomaDigitosFatorial soma = new SomaDigitosFatorial();


            int resultadoEsperado = 23382;
            

            //Act
            /** Exemplo:
             Solicitado soma.Calculo(4): logo Fatorial(4) = 24
             Soma dos digitos 2 + 4 = 6
             Logo ResultadoEsperado seria 6 
             */
            int resultadoAtual = soma.Calcula(2000); 

            //Assert
            Assert.AreEqual(resultadoEsperado,resultadoAtual);
        }
    }
}
