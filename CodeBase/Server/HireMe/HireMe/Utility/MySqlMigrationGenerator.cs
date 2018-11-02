using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Linq;
using System.Web;

namespace HireMe.Utility
{
    //usage SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationGenerator());
    public class MySqlMigrationGenerator : MySql.Data.Entity.MySqlMigrationSqlGenerator
    {
        public override IEnumerable<MigrationStatement> Generate(IEnumerable<MigrationOperation> migrationOperations, string providerManifestToken)
        {
            IEnumerable<MigrationStatement> res = base.Generate(migrationOperations, providerManifestToken);
            foreach (MigrationStatement ms in res)
            {
                //ms.Sql = ms.Sql.Replace("dbo.","");
                if (ms.Sql.Contains("dbo."))
                {
                    return new List<MigrationStatement>();
                }
            }
            return res;
        }
    }
}