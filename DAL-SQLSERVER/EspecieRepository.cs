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
    public class EspecieRepository :BaseDatos, IRepository<Especie>
    {

        public List<Especie> Consultar()
        {
            string sentencia = "select * from especies";

            SqlCommand cmd = new SqlCommand(sentencia, conexion);
            AbrirConexion();
            var reader = cmd.ExecuteReader();
            
            List<Especie> lista = new List<Especie>();
            //ReaderToEntity();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
            
        }

        private Especie Mappear(SqlDataReader reader)
        {
            //Especie especie = new Especie();
            //especie.Id = (int)reader[0];
            //especie.Nombre= (string)reader[1];

            return new Especie
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id_Especie")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
            };
        }

        public string Eliminar(int id)
        {
            if (id <= 0)
                return "ID inválido";

            string sentencia = "DELETE FROM [dbo].[Especies] WHERE Id_Especie = @Id";

            using (SqlCommand cmd = new SqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    AbrirConexion();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0 ? "Registro eliminado correctamente" : "No se encontró el registro...";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }

        public string Guardar(Especie entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
                return "Datos inválidos";

            string sentencia = "INSERT INTO [dbo].[Especies] ([Nombre]) VALUES (@Nombre)";

            using (SqlCommand cmd = new SqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                try
                {
                    AbrirConexion();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0 ? "Registro insertado correctamente" : "No se ha insertado...";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }


        public string Modificar(Especie entity)
        {
            throw new NotImplementedException();
        }

        public Especie BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Especie>(x => x.Id == id);
        }
    }

}
