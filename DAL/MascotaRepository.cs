using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MascotaRepository : FileRepository<Mascota>
    {
        private EspecieRepository especieRepository;
        private RazaRepository razaRepository;

        public MascotaRepository(string ruta) : base(ruta)
        {
            especieRepository = new EspecieRepository(Archivos.ARC_ESPECIE);
            razaRepository = new RazaRepository(Archivos.ARC_RAZA);
        
        }

        public override List<Mascota> Consultar()
        {
            try
            {
                List<Mascota> lista = new List<Mascota>();

                if (File.Exists(ruta))
                {
                    StreamReader sr = new StreamReader(ruta);
                    while (!sr.EndOfStream)
                    {
                        lista.Add(Mappear(sr.ReadLine()));
                    }
                    sr.Close();
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<RazaDto> ConsultarDTO()
        {
            try
            {
                List<RazaDto> lista = new List<RazaDto>();

                if (File.Exists(ruta))
                {
                    StreamReader sr = new StreamReader(ruta);
                    while (!sr.EndOfStream)
                    {
                        lista.Add(Mappear2(sr.ReadLine()));
                    }
                    sr.Close();
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private RazaDto Mappear2(string datos)
        {
            string[] campos = datos.Split(';');
            RazaDto raza = new RazaDto();
            raza.Codigo = (campos[0]);
            raza.Nombre_Raza = campos[1];
            var id = int.Parse(campos[2]);
            raza.Nombre_Especie = especieRepository.Consultar().FirstOrDefault(e => e.Id == id).Nombre;

            return raza;
        }

        public override Mascota Mappear(string datos)
        {
            //$"{Id};{Nombre};{Edad};{Especie.Id};{Raza.Id}";
            string[] campos = datos.Split(';');
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(campos[0]);
            mascota.Nombre = campos[1];
            mascota.Edad = int.Parse(campos[2]);
            mascota.Especie = especieRepository.BuscarPorId(int.Parse(campos[3]));
            mascota.Raza = razaRepository.BuscarPorId(int.Parse(campos[4]));
            

            return mascota;
        }

        public List<Mascota> ConsultarPorEspecie(int id)
        {
            return Consultar().Where(r => r.Especie.Id == id).ToList();
        }
    }
}
