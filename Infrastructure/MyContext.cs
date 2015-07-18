using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace Infrastructure
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Retira a convenção de tabelas com nome pluralizados
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
