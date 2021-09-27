using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestProject_XUnit
{
   public class ClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Data
                                       {
                                        Numero1 = "0",
                                        Numero2 = "1"
                                        }, 404
                                   };
            yield return new object[] { new Data
                                       {
                                        Numero1 = "2",
                                        Numero2 = "2"
                                        }, 200
                                   };
            yield return new object[] { new Data
                                       {
                                        Numero1 = "24",
                                        Numero2 = "2"
                                        }, 200
                                   };
            yield return new object[] { new Data
                                       {
                                        Numero1 = "780000000",
                                        Numero2 = "780000000"
                                        }, 500 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

    }
}
