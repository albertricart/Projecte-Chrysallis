using Projecte_Chrysallis.Formularios;
using Projecte_Chrysallis.Properties;
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
    public partial class FormMenu : Form
    {

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

        public FormMenu()
        {
            InitializeComponent();
        }

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

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxGestionarEventos_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.ShowDialog();
        }

        private void pictureBoxGestionarSocios_Click(object sender, EventArgs e)
        {
            FormSocios formSocios = new FormSocios();
            formSocios.ShowDialog();
        }

        private void pictureBoxContacto_Click(object sender, EventArgs e)
        {
            FormContacto f = new FormContacto();
            f.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (Formularios.FormLogin.adminLogeado.superadmin == true)
            {
                BackgroundImage = Resources.Fondo;
            }
            else
            {
                BackgroundImage = Resources.FondoNoSuper;
                pictureBoxGestionarAdmins.Enabled = false;
                pictureBoxGestionarEventos.Location = new Point(42, 372);
                pictureBoxGestionarSocios.Location = new Point(42, 471);
                
            }
        }

        private void pictureBoxGestionarAdmins_Click(object sender, EventArgs e)
        {
            
        }
    }
}
