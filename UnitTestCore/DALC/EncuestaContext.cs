using Microsoft.EntityFrameworkCore;
using OperacionesConNumeros.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DALC
{
    public class EncuestaContext : DbContext
    {
        private static long InstanceCount;

        public EncuestaContext(DbContextOptions<EncuestaContext> options) : base(options)
            => Interlocked.Increment(ref InstanceCount);

        public DbSet<Encuesta> Encuesta { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
