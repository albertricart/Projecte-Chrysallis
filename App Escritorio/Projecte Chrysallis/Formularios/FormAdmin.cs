using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormAdmin : Form
    {
        private List<Comunidades> comunidadesAdmin = new List<Comunidades>();
        private bool modificar = false;
        private Administradores administrador = new Administradores();
        private bool clickBotonAdmin = false;


        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(Administradores _administrador)
        {
            InitializeComponent();
            administrador = _administrador;
            modificar = true;
        }

        private void checkBoxGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerar.Checked == true)
            {
                textBoxContrasena.Text = Membership.GeneratePassword(12, 6);
            }
            else
            {
                if (modificar)
                {
                    textBoxContrasena.Text = administrador.contrasenya;
                }
                else
                {
                    textBoxContrasena.Clear();
                }
                
            }
        }

        private void FormNuevoAdmin_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();
            listBoxComunidades.SelectedIndex = -1;
            if (modificar)
            {
                RellenarCampos();
            }
        }

        private void buttonEnviarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidades.SelectedItems)
            {
                if (!comunidadesAdmin.Contains(comunidad))
                {
                    comunidadesAdmin.Add(comunidad);
                }
                
            }

            listBoxComunidades.ClearSelected();
            RefrescarComunidadesAdmin();
            listBoxComunidadesAdmin.ClearSelected();
        }

        private void buttonQuitarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidadesAdmin.SelectedItems)
            {
                comunidadesAdmin.Remove(comunidad);
            }

            RefrescarComunidadesAdmin();
            listBoxComunidadesAdmin.ClearSelected();
        }

        public void RefrescarComunidadesAdmin()
        {
            comunidadesAdminBindingSource.DataSource = null;
            comunidadesAdminBindingSource.DataSource = comunidadesAdmin;
        }

        public void RellenarCampos()
        {
            textBoxApellidos.Text = administrador.apellidos;
            textBoxContrasena.Text = administrador.contrasenya;
            textBoxEmail.Text = administrador.email;
            textBoxNombre.Text = administrador.nombre;
            
            if (administrador.superadmin)
            {
                radioButtonSuper.Checked = true;
            }

            foreach (Comunidades comunidad in administrador.Comunidades)
            {
                comunidadesAdmin.Add(comunidad);
            }
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clickBotonAdmin == false)
            {
                if (MessageBox.Show("Perderás los datos introducidos, quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            clickBotonAdmin = true;
        }
    }
}
