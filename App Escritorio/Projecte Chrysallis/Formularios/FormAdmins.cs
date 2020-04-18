using System;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormAdmins : Form
    {
        public int ultimoFiltroSeleccionado = 0;
        public int ultimoAdminSeleccionado = 0;

        public FormAdmins()
        {
            InitializeComponent();
        }
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin formNuevoAdmin = new FormAdmin();
            formNuevoAdmin.ShowDialog();
            MostrarAdmins();
            Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarAdmin();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarAdmin();
        }


        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            administradoresBindingSource.DataSource = null;

            if (comboBoxFiltro.SelectedItem.ToString().Equals("Nombre"))
            {
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByNombre(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 0;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("Apellidos"))
            {
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByApellidos(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 1;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("Email"))
            {
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByEmail(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 2;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("Comunidad Autónoma"))
            {
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByComunidad(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 3;
            }

        }

        private void FormAdmins_Load(object sender, EventArgs e)
        {
            MostrarAdmins();
        }

        public void MostrarAdmins()
        {
            administradoresBindingSource.DataSource = null;
            administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdmins();
        }

        private void FormAdmins_Activated(object sender, EventArgs e)
        {
            comboBoxFiltro.SelectedIndex = ultimoFiltroSeleccionado;
        }

        //========================================================================================================//
        //OTROS
        //========================================================================================================//

        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFiltro.Clear();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Administradores ObtenerAdministradorSeleccionado()
        {
            Administradores administrador = null;
            if (AdministradoresExistentes())
            {
                administrador = (Administradores)dataGridViewAdmins.SelectedRows[0].DataBoundItem;
            }
            else
            {
                MessageBox.Show("No hay administradores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return administrador;
        }

        public bool AdministradoresExistentes()
        {
            if (dataGridViewAdmins.SelectedRows.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridViewAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (AdministradoresExistentes())
            {
                bindingSourceComunidades.DataSource = null;
                bindingSourceComunidades.DataSource = ObtenerAdministradorSeleccionado().Comunidades.ToList();
            }
        }

        private void dataGridViewAdmins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarAdmin();
        }

        public void ModificarAdmin()
        {
            int ultimoIndexSelec;

            Hide();
            FormAdmin formAdmin = new FormAdmin(ObtenerAdministradorSeleccionado());
            formAdmin.ShowDialog();
            ultimoIndexSelec = dataGridViewAdmins.SelectedRows[0].Index;
            MostrarAdmins();
            dataGridViewAdmins.Rows[ultimoIndexSelec].Selected = true;
            Show();
        }

       public void EliminarAdmin()
        {
            Administradores admin = ObtenerAdministradorSeleccionado();

            if (admin != null)
            {
                if (admin.id == FormLogin.adminLogeado.id)
                {
                    MessageBox.Show("Usa otro administrador para eliminar tu rol", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (MessageBox.Show("Quieres eliminar el administrador seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String mensaje = Base_de_Datos.ORM_Admin.DeleteAdmin(ObtenerAdministradorSeleccionado());

                        if (mensaje.Equals(""))
                        {
                            MessageBox.Show("Administrador eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Administrador no eliminado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MostrarAdmins();
                    }
                }

            }
        }
    }
}
