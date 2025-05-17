using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsultarMascotas: Form
    {
        MascotaService MascotaService = new MascotaService();
        EspecieService especieService = new EspecieService();
       
        public FrmConsultarMascotas()
        {
            InitializeComponent();
        }

        private void FrmConsultarMascotas_Load(object sender, EventArgs e)
        {
            CargarEspecies();
            
        }
        private void CargarEspecies()
        {
            var lista = especieService.Consultar();
            cbEspecie.DataSource = lista;
            cbEspecie.DisplayMember = "Nombre";
            cbEspecie.ValueMember = "Id";
        }
        private void CargarMascotas(int id)
        {
            try
            {
                var lista = MascotaService.Consultar();
                grilla.Rows.Clear();
                foreach (var item in lista)
                {
                    if (item.Especie.Id==id)
                    {
                        grilla.Rows.Add(item.Id, item.Nombre, item.Edad, item.Especie.Nombre, item.Raza.Nombre);

                    }
                }

            }
            catch (Exception)
            {

                var lista = MascotaService.Consultar();
                foreach (var item in lista)
                {
                    grilla.Rows.Add(item.Id, item.Nombre, item.Edad, item.Especie.Nombre, item.Raza.Nombre);
                }
            }
           
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarMascotas((int)cbEspecie.SelectedValue);
            }
            catch (Exception)
            {

               
            }
            
        }
    }
}
