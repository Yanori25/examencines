using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examencines.Modelo
{
    internal class Conexion
    {

        public Conexion() { }


        public SqlConnection GetConexion()
        {

            //string NombreConexion = "BDDConexion";

            //SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());

            //return sql;

            return new SqlConnection(ConfigurationManager.ConnectionStrings["BDDConexion"].ToString());


        }
        public SqlConnection GetConexion(string Conexion)
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ToString());
        }

    }

}
