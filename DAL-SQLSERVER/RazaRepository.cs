using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL_SQLSERVER
{
    public class RazaRepository : BaseDatos, IRepository<Raza>
    {
        private EspecieRepository especieRepository= new EspecieRepository();

        public RazaRepository() 
        {
            //especieRepository = new EspecieRepository(/*Archivos.ARC_ESPECIE*/);
        }

        public List<Raza> Consultar()
        {
            List<Raza> lista = new List<Raza>();

            string sentencia = "select * from razas";
            SqlCommand cmd = new SqlCommand(sentencia, conexion);
            AbrirConexion();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }

            CerrarConexion();
            return lista;
        }

        private Raza Mappear(SqlDataReader reader)
        {
            Raza raza = new Raza();
            raza.Id = (int)reader[0];
            raza.Nombre = (string)reader[1];
            raza.AsignarEspecie(especieRepository.BuscarPorId((int)reader[2]));
            return raza;
        }

        public string Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Raza entity)
        {
            string sentencia = $"INSERT INTO [dbo].[Razas]([Nombre],[Id_Especie])VALUES('{entity.Nombre}',{entity.Especie.Id})";
            SqlCommand cmd = new SqlCommand(sentencia, conexion);
            AbrirConexion();
            int i = cmd.ExecuteNonQuery();
            if (i>0)
            {
                return "todo bien";
            }
            return "negativo no se guardo";
        }

        public string Modificar(Raza entity)
        {
            throw new NotImplementedException();
        }
    }

}
