using DALC;
using OperacionesConNumeros;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject_XUnit
{
    public class Encuesta
    {

        [Theory]
        [InlineData(200)]
        [InlineData(404)]
        public void TestGetEncuestaActiva(int valorUnitTest)
        {
            //Arrange
            EncuestaContext DbContextTest = new DatabaseDinamic().InicializaBdTest();
            var cargueMockBd = new PortalEcpEncuestasDB(DbContextTest);
            cargueMockBd.CargaEncuestaActiva();
            DbContextTest = cargueMockBd.ContextoCargado;

            //Act
            if (valorUnitTest == 404)
                DbContextTest.Dispose();

            var boValidar = new BOEncuesta(DbContextTest);
            var resultadoAct = boValidar.GetEncuestaActiva();

            //Assert
            Assert.Equal(valorUnitTest, resultadoAct.Codigo);

        }
    }
}
