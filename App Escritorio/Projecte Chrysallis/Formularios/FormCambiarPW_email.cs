using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormCambiarPW_email : Form
    {
        Administradores admin;
        bool modificarEmail = false;

        /// <summary>
        /// Constructor que recibirá el admin del que se querrá modificar sus datos y
        /// un booleano para indicar si se quiere modificar el email o la contraseña
        /// </summary>
        /// <param name="admin">Los datos del admin a modificar</param>
        /// <param name="modificarEmail">Si se quiere modificar el email: true, si es la contraseña: false</param>
        public FormCambiarPW_email(Administradores admin, bool modificarEmail)
        {
            InitializeComponent();
            this.admin = admin;
            this.modificarEmail = modificarEmail;
        }

        /// <summary>
        /// Evento que se activa cuando se carga el formulario. Cambiará los textos de las labels
        /// y del formulario en función de si accede para modificar la contraseña o el email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCambiarPW_email_Load(object sender, EventArgs e)
        {
            pictureBoxAntigua.Visible = false;
            pictureBoxNueva.Visible = false;
            pictureBoxRepetir.Visible = false;

            if (modificarEmail)
            {
                this.Text = "Modificar email - MeetChrysallis";
                labelAntiguo.Text = "Email antiguo";
                labelNuevo.Text = "Nuevo email";
                labelRepetir.Text = "Repita el nuevo email";
            }
            else
            {
                this.Text = "Modificar contraseña - MeetChrysallis";
                labelAntiguo.Text = "Contraseña antigua";
                labelNuevo.Text = "Nueva contraseña";
                labelRepetir.Text = "Repita la nueva contraseña";
            }
        }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
