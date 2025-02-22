using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE4DAYZ
{
    public static class SesionUsuario
    {
        public static string CadenaConexion { get; } = "server=LAPTOP-RVC8PUD8\\SQLEXPRESS; database=NOTE4DAYZ; integrated security=true";

        public static int IdUsuario { get; set; }

        public static string NombreUsuario { get; set; }

        public static string CorreoElectronico { get; set; }
    }
}
