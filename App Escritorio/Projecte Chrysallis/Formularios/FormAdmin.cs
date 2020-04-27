using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormAdmin : Form
    {
        //========================================================================================================//
        //                                                VARIABLES
        //========================================================================================================//
        private List<Comunidades> comunidadesAdmin = new List<Comunidades>();
        private bool modificar = false;
        private Administradores administrador = new Administradores();
        private bool clickBotonAdmin = false;


        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//
        /// <summary>
        /// Constructor vacio por defecto que se usa para añadir un nuevo admin
        /// </summary>
        public FormAdmin()
        {
            InitializeComponent();
            buttonAnadir.BackgroundImage = Projecte_Chrysallis.Properties.Resources.botonAnadir;
        }

        /// <summary>
        ///  Constructor parametrizado para modificar un admin
        /// </summary>
        /// <param name="_administrador"></param>
        public FormAdmin(Administradores _administrador)
        {
            InitializeComponent();
            administrador = _administrador;
            modificar = true;
            HabilitarModificarContrasena();
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          EVENTOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//


        /// <summary>
        /// Evento load del formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNuevoAdmin_Load(object sender, EventArgs e)
        {
            //obtendremos la lista de comunidades las cuales el admin puede administrar
            bindingSourceComunidades.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();

            //!evitamos que se seleccione una comunidad al abrirse el form
            listBoxComunidades.ClearSelected();
            
            //si estamos modificantdo 
            if (modificar)
            {
                //mostraremos los datos del administrador que querramos modificar
                RellenarCampos();
            }
        }
        
        /// <summary>
        /// Evento click del boton para añadir comunidades a administrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnviarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidades.SelectedItems)
            {
                //si el admin ya administra la comunidad que ha seleccionado no la volveremos a añadir
                if (!comunidadesAdmin.Contains(comunidad))
                {
                    comunidadesAdmin.Add(comunidad);
                }

            }

            //refrescaremos la lista de comunidades del admin
            listBoxComunidades.ClearSelected();
            RefrescarComunidadesAdmin();
            listBoxComunidadesAdmin.ClearSelected();
        }

        /// <summary>
        /// Evento click del boton para quitar comunidades a administrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidadesAdmin.SelectedItems)
            {
                //quitaremos las comunidades que haya seleccionado el usuario
                comunidadesAdmin.Remove(comunidad);
            }

            //refrescaremos la lista de comunidades del admin
            RefrescarComunidadesAdmin();
            listBoxComunidadesAdmin.ClearSelected();
        }


        /// <summary>
        /// Evento click del boton atras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Evento formClosing del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento click del boton añadir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            clickBotonAdmin = true;

            //obtendremos un administrador con los datos que se hayan introducido
            Administradores administrador = RecogerDatos();

            //si no obtenemos un administrador nulo
            if (administrador!=null)
            {
                //en el caso que estemos modificandolo
                if (modificar)
                {
                    //obtendremos y mostraremos un mensaje de error o no dependiendo si se ha modificado correctamente
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
                //en el caso que añadamos un nuevo admin
                else
                {
                    //obtendremos y mostraremos un mensaje de error o no dependiendo si se ha añadido correctamente
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

        /// <summary>
        /// evento checked changed del checkboxSuper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAdminSuper_CheckedChanged(object sender, EventArgs e)
        {
            //si es admin estatal se le añadiran todas las comunidades
            if (checkBoxAdminSuper.Checked)
            {
                comunidadesAdminBindingSource.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades().ToList();
                comunidadesAdmin = Base_de_Datos.ORM_Comunidades.SelectComunidades().ToList();
                buttonEnviarComunidades.Enabled = false;
                buttonQuitarComunidades.Enabled = false;
            }
            //si no lo es, podra escoger las comunidades
            else
            {
                comunidadesAdminBindingSource.DataSource = null;
                comunidadesAdmin.Clear();
                buttonEnviarComunidades.Enabled = true;
                buttonQuitarComunidades.Enabled = true;
            }
        }

        /// <summary>
        /// evento checked changed del checkbox para modificar la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxModificarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificarContra.Checked)
            {
                textBoxContrasena.Clear();
                textBoxContrasena.Enabled = true;
                checkBoxGenerar.Enabled = true;
                textBoxContrasena.PasswordChar = '\0';
            }
            else
            {
                textBoxContrasena.Text = this.administrador.contrasenya;
                textBoxContrasena.PasswordChar = '•';
                textBoxContrasena.Enabled = false;
                checkBoxGenerar.Enabled = false;
            }
        }

        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          METODOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// metodo para generar un contraseña aleatoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerar.Checked == true)
            {
                textBoxContrasena.PasswordChar = '\0';
                textBoxContrasena.Text = Membership.GeneratePassword(12, 6);
            }
            else
            {
                textBoxContrasena.Clear();
            }
        }

        /// <summary>
        /// Metodo para habilitar los controles necesarios para modificar la contraseña
        /// </summary>
        public void HabilitarModificarContrasena()
        {
            checkBoxModificarContra.Visible = true;
            checkBoxGenerar.Enabled = false;
            textBoxContrasena.Enabled = false;
            textBoxContrasena.PasswordChar = '•';
        }



        /// <summary>
        /// Metodo para refrescar la lista de comunidades del admin
        /// </summary>
        public void RefrescarComunidadesAdmin()
        {
            comunidadesAdminBindingSource.DataSource = null;
            comunidadesAdminBindingSource.DataSource = comunidadesAdmin;
        }

        /// <summary>
        /// Metodo que muestra los datos de un admin en su campo correspondiente
        /// </summary>
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



        /// <summary>
        /// Metodo que devuelve un administrador segun los datos que hayan sido introducidos
        /// </summary>
        /// <returns></returns>
        public Administradores RecogerDatos()
        {
            Administradores administrador = new Administradores();

            if (ComprovarCamposVacios())
            {
                administrador.nombre = textBoxNombre.Text;
                administrador.apellidos = textBoxApellidos.Text;
                administrador.email = textBoxEmail.Text;
                administrador.superadmin = checkBoxAdminSuper.Checked;
                administrador.Comunidades = comunidadesAdmin;

                if (modificar)
                {
                    administrador.id = this.administrador.id;
                }

                if (checkBoxModificarContra.Checked)
                {
                    administrador.contrasenya = textBoxContrasena.Text;
                }
                else
                {
                    if (modificar)
                    {
                        administrador.contrasenya = this.administrador.contrasenya;
                    }
                    else
                    {
                        administrador.contrasenya = textBoxContrasena.Text;
                    }

                }
            }
            else
            {
                administrador = null;
            }

            return administrador;
        }

        /// <summary>
        /// Metodo para comprovar que no haya campos vacíos
        /// </summary>
        /// <returns></returns>
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
    }
}
