using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperacionesConNumeros;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest_BO
    {

        private Bo _bo;
        public UnitTest_BO()
        {
            _bo = new Bo();

        }

        [TestMethod]
        public void TestMethod1_ValidarSiEsnumeroPar()
        {
            //Arranges

            //ACT
            var result = _bo.EsPar(2).Result;

            //Assert
            Assert.AreEqual(200 ,result.Codigo);

        }


            #region Metodo 2
            [TestMethod, Priority(2)]
            [DataRow("2")]
            [DataRow("0")]
            [DataRow("24")]
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
            [TestMethod, Priority(1)]
            [DataRow("1",404)]
            [DataRow("0",200)]
            [DataRow("24",200)]
            public void TestMethod3_ValidarSiEsnumeroPar(string Numero,int expected)
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
            [TestMethod]
            [DataRow("0","1", 404)]
            [DataRow("2","2", 200)]
            [DataRow("24","2", 200)]
            [DataRow("780000000", "780000000", 500)]
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
            #endregion

            #region Metodo 5
            [DataTestMethod]
            [DynamicData(nameof(ClassData.GetEnumerator),typeof(ClassData), DynamicDataSourceType.Method)]
            public void TestMethod5_RealizaMultiplicacion(Data _data, int expected)
            {
                //Arranges
                int Numero1_1 = int.Parse(_data.Numero1);
                int Numero2_2 = int.Parse(_data.Numero2);

                //ACT
                var result = _bo.Multiplicar(Numero1_1, Numero2_2).Result;

                //Assert
                Assert.AreEqual(expected, result.Codigo);

            }
            #endregion




    }
}
