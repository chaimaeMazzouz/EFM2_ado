using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM2_Ado
{
    class Global
    {
        public SqlConnection hopital_connexion = new SqlConnection(@"data source = .\SQLEXPRESS;database=hopital;Integrated Security=True");

    }
}
