using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_Datos
{
   public class cl_Conexion
    {
        SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = inventariop; Integrated Security = True");

        //metodo para abrir la conexion//
        void abrir_conexion()
        {
            if (conexion.State==ConnectionState.Closed)
            
                conexion.Open();
        }
        //metodo para cerrar la conexion
        void cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
       

    }
}
