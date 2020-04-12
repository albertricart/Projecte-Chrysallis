using System;
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
        }

        private void pictureBoxAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin formNuevoAdmin = new FormAdmin();
            formNuevoAdmin.ShowDialog();
            Show();
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltro.SelectedItem.ToString().Equals("Nombre"))
            {
                administradoresBindingSource.DataSource = null;
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByNombre(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 0;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("Apellidos"))
            {
                administradoresBindingSource.DataSource = null;
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByApellidos(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 1;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("Email"))
            {
                administradoresBindingSource.DataSource = null;
                administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdminsByEmail(textBoxFiltro.Text);
                ultimoFiltroSeleccionado = 2;
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

        private void pictureBoxModificar_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin formAdmin = new FormAdmin(ObtenerAdministradorSeleccionado());
            formAdmin.ShowDialog();
            Show();
        }

        public Administradores ObtenerAdministradorSeleccionado()
        {
            Administradores administrador = null;
            if (AdministradoresExistentes())
            {
                administrador = new Administradores();
                administrador = (Administradores) dataGridViewAdmins.SelectedRows[0].DataBoundItem;

                
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
    }
}
