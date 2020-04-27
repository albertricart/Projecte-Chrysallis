using Projecte_Chrysallis.Formularios;
using Projecte_Chrysallis.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormMenu : Form
    {

        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//
        public FormMenu()
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
        /// evento click del boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            // Pregunta si esta seguro que desea cerrar
            var respuesta = MessageBox.Show("Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si es así, se cierra el form
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// evento click del boton minimizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// evento click del boton GestionarEventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxGestionarEventos_Click(object sender, EventArgs e)
        {
            Hide();
            FormEventos formEventos = new FormEventos();
            formEventos.ShowDialog();
            Show();
        }

        /// <summary>
        /// evento click del boton GestionarSocios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxGestionarSocios_Click(object sender, EventArgs e)
        {
            Hide();
            FormSocios formSocios = new FormSocios();
            formSocios.ShowDialog();
            Show();
        }

        /// <summary>
        /// evento click del boton GestionarAdmins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxGestionarAdmins_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmins formAdmins = new FormAdmins();
            formAdmins.ShowDialog();
            Show();
        }

        /// <summary>
        /// evento click del boton Contacto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxContacto_Click(object sender, EventArgs e)
        {
            Hide();
            FormContacto f = new FormContacto();
            f.ShowDialog();
            Show();
        }

        /// <summary>
        /// evento load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelPerfil.Text = "Bienvenido, \n" + FormLogin.adminLogeado.nombre;
            try
            {
                if (FormLogin.adminLogeado.superadmin == true)
                {
                    BackgroundImage = Resources.Fondo;
                }
                else
                {
                    BackgroundImage = Resources.FondoNoSuperFinal;
                    pictureBoxGestionarAdmins.Enabled = false;
                    pictureBoxGestionarEventos.Location = new Point(42, 372);
                    pictureBoxGestionarSocios.Location = new Point(42, 471);

                }
            }
            catch (NullReferenceException) { }
        }


        //========================================================================================================//
        //                                          OTROS
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
