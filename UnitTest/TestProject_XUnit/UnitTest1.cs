using OperacionesConNumeros;
using System;
using Xunit;

namespace TestProject_XUnit
{
    public class UnitTest1
    {
        
        private Bo _bo;

        
        public UnitTest1()
        {
            _bo = new Bo();
        }


        [Fact]
        public void TestMethod1_ValidarSiEsnumeroPar()
        {
            //Arranges

            //ACT
            var result = _bo.EsPar(2).Result;

            //Assert
            Assert.Equal(200, result.Codigo);

        }


        #region Metodo 2
        [Theory]
        [InlineData("2")]
        [InlineData("0")]
        [InlineData("24")]
        public void TestMethod2_ValidarSiEsnumeroPar(string Numero)
        {
            //Arranges
            int Numero1 = int.Parse(Numero);
            //ACT
            var result = _bo.EsPar(Numero1).Result;

            //Assert
            Assert.Equal(200, result.Codigo);

        }
        #endregion

        #region Metodo 3
        [Theory]
        [InlineData("1", 404)]
        [InlineData("0", 200)]
        [InlineData("24", 200)]
        public void TestMethod3_ValidarSiEsnumeroPar(string Numero, int expected)
        {
            //Arranges
            int Numero1 = int.Parse(Numero);

            //ACT
            var result = _bo.EsPar(Numero1).Result;

            //Assert
            Assert.Equal(expected, result.Codigo);

        }
        #endregion

        #region Metodo 4
        [Theory]
        [InlineData("0", "1", 404)]
        [InlineData("2", "2", 200)]
        [InlineData("24", "2", 200)]
        [InlineData("780000000", "780000000", 500)]
        public void TestMethod4_RealizaMultiplicacion(string Numero1, string Numero2, int expected)
        {
            //Arranges
            int Numero1_1 = int.Parse(Numero1);
            int Numero2_2 = int.Parse(Numero2);

            //ACT
            var result = _bo.Multiplicar(Numero1_1, Numero2_2).Result;

            //Assert
            Assert.Equal(expected, result.Codigo);

        }
        #endregion

        #region Metodo 5
        [Theory]
        [ClassData(typeof(ClassData))]
        public void TestMethod5_RealizaMultiplicacion(Data _data, int expected)
        {
            //Arranges
            int Numero1_1 = int.Parse(_data.Numero1);
            int Numero2_2 = int.Parse(_data.Numero2);

            //ACT
            var result = _bo.Multiplicar(Numero1_1, Numero2_2).Result;

            //Assert
            Assert.Equal(expected, result.Codigo);

        }
        #endregion



        
    }
}
