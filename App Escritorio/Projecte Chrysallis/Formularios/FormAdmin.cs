using System;
using System.Collections.Generic;
using System.Linq;
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
            comunidadesAdminBindingSource.DataSource = administrador.Comunidades.ToList();

            if (administrador.superadmin)
            {
                checkBoxAdminSuper.Checked = true;
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
                if (MessageBox.Show("Perderás los datos que hayas introducido, quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            clickBotonAdmin = true;

            if (ComprovarCamposVacios())
            {
                RecogerDatos();
                if (modificar)
                {
                    String mensaje = Base_de_Datos.ORM_Admin.UpdateAdmin(administrador);

                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("Administrador modificado correctamente. ", "Administrador Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar el administrador: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String mensaje = Base_de_Datos.ORM_Admin.InsertAdmin(administrador);

                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("Administrador añadido correctamente. ", "Administrador Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido añadir el administrador: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


        }
        public void RecogerDatos()
        {
            administrador.nombre = textBoxNombre.Text;
            administrador.apellidos = textBoxApellidos.Text;
            administrador.email = textBoxEmail.Text;
            administrador.contrasenya = textBoxContrasena.Text;
            administrador.superadmin = checkBoxAdminSuper.Checked;
            administrador.Comunidades = comunidadesAdmin;
        }

        public bool ComprovarCamposVacios()
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Rellena los campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else
            {
                if (comunidadesAdmin.Count < 1)
                {
                    MessageBox.Show("El administrador no tiene ninguna comunidad a cargo", "Administrador sin comunidad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                else
                    return true;
            }
        }

        private void checkBoxAdminSuper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdminSuper.Checked)
            {
                comunidadesAdminBindingSource.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades().ToList();
                comunidadesAdmin = Base_de_Datos.ORM_Comunidades.SelectComunidades().ToList();
                buttonEnviarComunidades.Enabled = false;
                buttonQuitarComunidades.Enabled = false;
            }
            else
            {
                comunidadesAdminBindingSource.DataSource = null;
                comunidadesAdmin.Clear();
                buttonEnviarComunidades.Enabled = true;
                buttonQuitarComunidades.Enabled = true;
            }
        }
    }
}
