using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestProject_NUnit
{
    public class ClassData
    {
        public static IEnumerable NumberRules()
        {

                yield return new TestCaseData(new Data()
                {
                    Numero1 = "0",
                    Numero2 = "1",
                    expected = 404
                }
                                       );
                yield return new TestCaseData(new Data()
                {
                    Numero1 = "2",
                    Numero2 = "2",
                    expected = 200
                }
                                       );
                yield return new TestCaseData(new Data()
                {
                    Numero1 = "24",
                    Numero2 = "2",
                    expected = 200
                }
                                           );
                yield return new TestCaseData(new Data()
                {
                    Numero1 = "780000000",
                    Numero2 = "780000000",
                    expected = 500
                });
            
        }
    }

    

}
