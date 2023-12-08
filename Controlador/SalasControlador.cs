using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using examencines.Modelo;

namespace examencines.Controlador
{
   public class SalasControlador
    {


        public DataTable get()
        {
            SqlConnection Con = new Conexion().GetConexion("BDDConexion");
            Con.Open();





            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showSalas", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;







        }

    }
}
