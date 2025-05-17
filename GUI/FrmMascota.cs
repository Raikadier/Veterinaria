using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMascota: Form
    {
        MascotaService MascotaService = new MascotaService();
        EspecieService especieService = new EspecieService();
        RazaService razaService = new RazaService();
        public FrmMascota()
        {
            InitializeComponent();
        }

        private void cbRaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(txtId.Text);
            mascota.Nombre = txtNombre.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Especie = especieService.BuscarId((int)cbEspecie.SelectedValue);
            mascota.Raza = razaService.BuscarId((int)cbRaza.SelectedValue);

            var mensaje = MascotaService.Guardar(mascota);
            MessageBox.Show(mensaje);
        }

        private void FrmMascota_Load(object sender, EventArgs e)
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

        private void CargarRazas(int id)
        {
            //var lista = razaService.ConsultarPorEspecie(id);
            //cbRaza.DataSource = lista;
            //cbRaza.DisplayMember = "Nombre";
            //cbRaza.ValueMember = "Id";
            //cbRaza.Items.Clear();
            //foreach (var item in lista)
            //{
            //    lstMascotas.Items.Add(item.Nombre);
            //}
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = cbEspecie.SelectedValue.ToString();
          
               
            try
            {
                //cbEspecie.SelectedIndex = 1;
                CargarRazas(int.Parse(cbEspecie.SelectedValue.ToString()));
            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarRazas(int.Parse(cbEspecie.SelectedValue.ToString()));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            var mascota = MascotaService.BuscarId(int.Parse(txtId.Text));
            if (mascota==null)
            {
                return;
            }

            txtNombre.Text = mascota.Nombre;
            txtEdad.Text = mascota.Edad.ToString();
            cbEspecie.Text = mascota.Especie.Nombre;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var f = new FrmConsultarMascotas();
            f.ShowDialog();
        }
    }
}
