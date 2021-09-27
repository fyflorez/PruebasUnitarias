using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
   public class ClassData 
    {
        public static IEnumerable<object[]> GetEnumerator()
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

      

    }
}
