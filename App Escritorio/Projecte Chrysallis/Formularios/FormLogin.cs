using System;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormLogin : Form
    {
        bool valido, //para comprobar si el login es correcto o no
            pwVisible = false; //para comprobar si la contraseña es visible o no (con '•')

        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al cargar el formulario
        /// </summary>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelIncorrectos.Visible = false;
            valido = false;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si el login no es válido, se cierra toda la app
            if (!valido)
            {
                Application.Exit();
            }
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            intentarLogin();
        }

        private void textBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                intentarLogin();
            }
        }

        /// <summary>
        /// Prueba de loguearse con el email y contraseña de los TextBoxs. Si es correcto,
        /// accede a la app, si es incorrecto muestra el mensaje de error
        /// </summary>
        private void intentarLogin()
        {
            if (textBoxContrasenya.Text.Equals("") &&
             textBoxEmail.Text.Equals(""))
            {
                valido = true;
                this.Close();
            }
            else
            {
                valido = false;
                labelIncorrectos.Visible = true;
            }
        }

        //Eventos que se activa al tabular para acceder a los TextBox email y contraseña
        //Sirve para seleccionar todo el texto del TextBox
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            textBoxEmail.SelectAll();
        }
        private void textBoxContrasenya_Enter(object sender, EventArgs e)
        {
            textBoxContrasenya.SelectAll();
        }

        /// <summary>
        /// Evento que se activa cuando se hace click en el ojo
        /// </summary>
        private void pictureBoxOjo_Click(object sender, EventArgs e)
        {
            //Si la contraseña es visible la vuelve oculta y cambia la imagen del ojo, para que sepa
            //que está activada
            if (pwVisible)
            {
                pwVisible = false;
                textBoxContrasenya.PasswordChar = '•';
                
                pictureBoxOjo.Image = Properties.Resources.ojo;
            }
            //Si está oculta la vuelve visible
            else
            {
                pwVisible = true;
                textBoxContrasenya.PasswordChar = '\0';
                pictureBoxOjo.Image = Properties.Resources.ojoActivado;
            }
        }


        /*
        //------------ PRUEBAS ------------
        private void formatearHintEmail()
        {
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Italic);
        }

        private void formatearNormalEmail()
        {
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Regular);
        }

        private void formatearNormalPW()
        {
            textBoxContrasenya.ForeColor = Color.Black;
            textBoxContrasenya.Font = new Font(textBoxEmail.Font, FontStyle.Regular);
            textBoxContrasenya.PasswordChar = '•';
        }

        private void formatearHintPW()
        {
            textBoxContrasenya.ForeColor = Color.DarkGray;
            textBoxContrasenya.Font = new Font(textBoxEmail.Font, FontStyle.Italic);
            textBoxContrasenya.Text = "Contraseña";
        }
        //------------------------------------------
        */
    }
}
