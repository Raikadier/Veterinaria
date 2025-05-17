using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL_SQLSERVER
{
    public class BaseDatos
    {
        //string cadenaConexion = "Server=.\\SQLEXPRESS;Database=VeterinariaDB;Trusted_Connection=True;";
        string cadenaConexion = "Server=.\\SQLEXPRESS;Database=VeterinariaDB;User Id=sa;Password=123456;";

        protected SqlConnection conexion;

        public BaseDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public ConnectionState AbrirConexion()
        {
            if (conexion.State==ConnectionState.Open)
            {
                conexion.Close();

            }
            conexion.Open();
            return conexion.State;
        }
        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
