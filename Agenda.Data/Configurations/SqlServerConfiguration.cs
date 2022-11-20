using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Data.Configurations
{
    /// <summary>
    /// Classe para configuração da connectionstring
    /// </summary>
    public class SqlServerConfiguration
    {
        /// <summary>
        /// Método para retornar a connectionstring do banco de dados
        /// </summary>
        public static string GetConnectionString
            //=> @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDAgenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            => @"Data Source=SQL8003.site4now.net;Initial Catalog=db_a8fe79_bdagenda;User Id=db_a8fe79_bdagenda_admin;Password=lucas1995";
    }
}
