using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace uta.fisei.credito.sqlrepositorio
{
    public class ConexionBD
    {
        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["Creditos"].ToString();
        }
    }
}
