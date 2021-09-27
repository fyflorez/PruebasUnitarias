using NUnit.Framework;
using OperacionesConNumeros;

namespace TestProject_NUnit
{
    [TestFixture]
    public class Tests
    {
        private Bo _bo;

        [SetUp]
        public void Setup()
        {
            _bo = new Bo();
        }

       
        [Test]
        public void TestMethod1_ValidarSiEsnumeroPar()
        {
            //Arranges

            //ACT
            var result = _bo.EsPar(2).Result;

            //Assert
            Assert.AreEqual(200, result.Codigo);

        }


        #region Metodo 2
        [TestCase("2")]
        [TestCase("0")]
        [TestCase("24")]
        public void TestMethod2_ValidarSiEsnumeroPar(string Numero)
        {
            //Arranges
            int Numero1 = int.Parse(Numero);
            //ACT
            var result = _bo.EsPar(Numero1).Result;

            //Assert
            Assert.AreEqual(200, result.Codigo);

        }
        #endregion

        #region Metodo 3
        [TestCase("1", 404)]
        [TestCase("0", 200)]
        [TestCase("24", 200)]
        public void TestMethod3_ValidarSiEsnumeroPar(string Numero, int expected)
        {
            //Arranges
            int Numero1 = int.Parse(Numero);

            //ACT
            var result = _bo.EsPar(Numero1).Result;

            //Assert
            Assert.AreEqual(expected, result.Codigo);

        }
        #endregion

        #region Metodo 4
        [TestCase("0", "1", 404)]
        [TestCase("2", "2", 200)]
        [TestCase("24", "2", 200)]
        [TestCase("780000000", "780000000", 500)]
        public void TestMethod4_RealizaMultiplicacion(string Numero1, string Numero2, int expected)
        {
            //Arranges
            int Numero1_1 = int.Parse(Numero1);
            int Numero2_2 = int.Parse(Numero2);

            //ACT
            var result = _bo.Multiplicar(Numero1_1, Numero2_2).Result;

            //Assert
            Assert.AreEqual(expected, result.Codigo);

        }

        #endregion|

        #region Metodo 5
        [Test, TestCaseSource(typeof(ClassData),nameof(ClassData.NumberRules))]
        public void TestMethod5_RealizaMultiplicacion(Data _data)
        {
            //Arranges
            int Numero1_1 = int.Parse(_data.Numero1);
            int Numero2_2 = int.Parse(_data.Numero2);

            //ACT
            var result = _bo.Multiplicar(Numero1_1, Numero2_2).Result;

            //Assert
            Assert.AreEqual(_data.expected, result.Codigo);

        }

       

        #endregion


    }
}