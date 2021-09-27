using DALC;
using Microsoft.EntityFrameworkCore;
using System;

namespace TestProject_XUnit
{
    /// <summary>
    /// Genera un mock dinamico de BD
    /// </summary>
    public class DatabaseDinamic
    {
      

        /// <summary>
        /// Genera
        /// </summary>
        /// <returns></returns>
        public EncuestaContext InicializaBdTest()
        {
            string databaseName = "GV_DocumentosContables_" + DateTime.Now.Ticks.ToString();
            EncuestaContext DbContextTest;
            /* Create a Memory Database instead of using the SQL */
            var options = new DbContextOptionsBuilder<EncuestaContext>()
                .UseInMemoryDatabase(databaseName: databaseName)
                .Options;
            DbContextTest = new EncuestaContext(options);
            return DbContextTest;
        }


    }
}
