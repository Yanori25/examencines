using examencines.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examencines.Controlador
{
   public  class CinesControlador
    {

        public DataTable get()
        {
            SqlConnection Con = new Conexion().GetConexion("BDDConexion");
            Con.Open();



            

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showcines", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;







        }

    }
}
