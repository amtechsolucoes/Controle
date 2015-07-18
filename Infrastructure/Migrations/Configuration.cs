using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Migrations
{
    /// <summary>
    /// Classe de Configuração do Migrations para utilizar no modo Code First
    /// Internal - para não permitir acesso externo pela aplicação
    /// Sealed - utilizado para não permitir herança dessa classe
    /// </summary>
    internal sealed class Configuration: DbMigrationsConfiguration<Infrastructure.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        /// <summary> 
        ///  Método Executado para iniciar o banco ao utilizar o comando 'Update-Database' do Code First
        /// </summary>
        /// <param name="context"> Contexto de banco utilizado na aplicação</param>
        protected override void Seed(Infrastructure.MyContext context)
        {

        }
    }
}
