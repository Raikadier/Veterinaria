using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MascotaService:IService<Mascota>
    {
        private readonly MascotaRepository repoMascota;

        public MascotaService()
        {
            repoMascota = new MascotaRepository(Archivos.ARC_MASCOTA);
        }

        public List<Mascota> Consultar()
        {
            return repoMascota.Consultar();
        }
        //public List<RazaDto> ConsultarDTO()
        //{
        //    return repoRaza.ConsultarDTO();
        //}
        public string Guardar(Mascota entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la raza no puede ser nula");
                }

                if (entity.Especie == null)
                {
                    throw new NullReferenceException("Error... la especie de la raza no puede ser nula");
                }

                return repoMascota.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar raza: {ex.Message}";
            }
        }

        public string Modificar(Mascota entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... la raza no puede ser nula");
                }

                if (entity.Especie == null)
                {
                    throw new NullReferenceException("Error... la especie de la raza no puede ser nula");
                }

                return repoMascota.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar raza: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... el id debe ser mayor a cero");
                }

                return repoMascota.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar raza: {ex.Message}";
            }
        }

        public List<Mascota> BuscarPorId(int id)
        {
            return repoMascota.ConsultarPorEspecie(id);
        }

        public Mascota BuscarId(int id)
        {
            var mascotaBuscada = Consultar().FirstOrDefault<Mascota>(x => x.Id == id);
            return mascotaBuscada;
        }
    }
}
