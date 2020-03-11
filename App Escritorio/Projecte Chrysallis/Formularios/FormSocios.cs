using Projecte_Chrysallis.Base_de_Datos;
using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        public void ModificarSocio()
        {
            if (SociosExistentes())
            {
                FormNuevoSocio formModificarSocio = new FormNuevoSocio(ObtenerSocioSeleccionado());
                formModificarSocio.ShowDialog();
            }
        }

        public Socios ObtenerSocioSeleccionado()
        {
            int.TryParse(dataGridViewSocios.SelectedRows[0].Cells[0].Value.ToString(), out int id);
            Socios socio = Base_de_Datos.ORM_Socio.SelectSocioByID(id);
            return socio;

        }

        public bool SociosExistentes()
        {
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay socios", "Sin socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            FormNuevoSocio formNuevoSocio = new FormNuevoSocio();
            formNuevoSocio.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //modificaremos el socio al que tengamos seleccionado
            ModificarSocio();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //testeando
            Socios socio = ORM_Socio.SelectSocioByID(1);
            MessageBox.Show(socio.apellidos);
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            bindingSourceSocios.DataSource = null;
            bindingSourceSocios.DataSource = Base_de_Datos.ORM_Socio.SelectSocios();
        }

        private void FormSocios_Activated(object sender, EventArgs e)
        {
            bindingSourceSocios.DataSource = null;
            bindingSourceSocios.DataSource = Base_de_Datos.ORM_Socio.SelectSocios();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
