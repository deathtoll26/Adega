using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.DAL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source =.\SQLEXPRESS; Initial Catalog = Adega; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

    }
}
