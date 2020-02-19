using System;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormLogin : Form
    {
        bool valido;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelIncorrectos.Visible = false;
            valido = false;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void intentarLogin()
        {
            if (textBoxContrasenya.Text.Equals("prueba") &&
             textBoxEmail.Text.Equals("prueba"))
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
