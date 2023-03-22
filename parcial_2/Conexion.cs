using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_2
{
    internal class Conexion
    {

        public static string conectar()
        {
            string con = @" data source=BLANCALUNA\SQLEXPRESS; initial catalog=ventas; integrated security=true";

            return con;
        }
    }
}
