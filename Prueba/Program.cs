using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //DAL_SQLSERVER.BaseDatos baseDatos = new DAL_SQLSERVER.BaseDatos();
            //Console.WriteLine(baseDatos.AbrirConexion());

            //Especie especie = new Especie(11, "HISTORICOS");

            //DAL_SQLSERVER.EspecieRepository repo = new DAL_SQLSERVER.EspecieRepository();

            ////Console.WriteLine(repo.Guardar(especie));

            //Console.WriteLine("************************************************");
            //var lista = repo.Consultar();

            //Console.WriteLine("ID       ---     NOMBRE");
            //foreach (var item in lista)
            //{
            //    Console.WriteLine($"{item.Id} --- {item.Nombre}");
            //}

            //repo.Eliminar(especie.Id);

            //Console.WriteLine("************************************************");
            //lista = repo.Consultar();

            //Console.WriteLine("ID       ---     NOMBRE");
            //foreach (var item in lista)
            //{
            //    Console.WriteLine($"{item.Id} --- {item.Nombre}");
            //}


            //DAL_SQLSERVER.BaseDatos baseDatos = new DAL_SQLSERVER.BaseDatos();
            //Console.WriteLine(baseDatos.AbrirConexion());


            //DAL_SQLSERVER.RazaRepository repo = new DAL_SQLSERVER.RazaRepository();
            //var lista = repo.Consultar();
            //Console.WriteLine("ID    ---   NOMBRE  --- ESPECIE");
            //foreach (var item in lista)
            //{
            //    Console.WriteLine($"{item.Id} --- {item.Nombre}  --- {item.Especie.Nombre}");
            //}
            DAL_POSTGRES.EspecieRepository repo = new DAL_POSTGRES.EspecieRepository();

            
            Console.WriteLine(repo.Guardar(new Especie(1, "aves")));
            Console.ReadKey();
        }
    }
}
