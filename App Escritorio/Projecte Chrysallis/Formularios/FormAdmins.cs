using System;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormAdmins : Form
    {
        //========================================================================================================//
        //                                                VARIABLES
        //========================================================================================================//
        public int ultimoFiltroSeleccionado = 0;
        public int ultimoAdminSeleccionado = 0;

        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//
        public FormAdmins()
        {
            InitializeComponent();
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          EVENTOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// evento load que mostrara los admins en la grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdmins_Load(object sender, EventArgs e)
        {
            MostrarAdmins();
        }


        /// <summary>
        /// evento click del boton para añadir un nuevo admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            //ocultaremos este form y abriremos el FormAdmin
            Hide();
            FormAdmin formNuevoAdmin = new FormAdmin();
            formNuevoAdmin.ShowDialog();
            MostrarAdmins();
            Show();
        }

        /// <summary>
        /// evento click del boton para modificar un admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarAdmin();
        }

        /// <summary>
        /// evento click del boton para modificar un admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarAdmin();
        }

        /// <summary>
        /// evento text changed de el textbox del filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            administradoresBindingSource.DataSource = null;

            //segun el filtro seleccionado y el texto introducido mostraremos unos administradores o otros
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

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dataGridViewAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (AdministradoresExistentes())
            {
                bindingSourceComunidades.DataSource = null;
                bindingSourceComunidades.DataSource = ObtenerAdministradorSeleccionado().Comunidades.ToList();
            }
        }

        /// <summary>
        /// Metodo click sobre un admin para modificarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAdmins_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarAdmin();
        }


        /// <summary>
        /// Limpiaremos el textboxfiltro al cambiar el filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFiltro.Clear();
        }

        /// <summary>
        /// Metodo click al pictureboxatras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormAdmins_Activated(object sender, EventArgs e)
        {
            comboBoxFiltro.SelectedIndex = ultimoFiltroSeleccionado;
        }
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          METODOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// metodo que muestra todos los administradores
        /// </summary>
        public void MostrarAdmins()
        {
            administradoresBindingSource.DataSource = null;
            administradoresBindingSource.DataSource = Base_de_Datos.ORM_Admin.SelectAdmins();
        }


        /// <summary>
        /// Metodo que devuelve el admin que hayamos seleccionado
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo que devuelve si hay admins
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo para modificar un admin
        /// </summary>
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


        /// <summary>
        /// Metodo para eliminar un admin
        /// </summary>
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
                            MessageBox.Show("No se ha podido eliminar el administrador: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MostrarAdmins();
                    }
                }

            }
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

       
    }
}
