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
    public partial class FormPerfil : Form
    {
        Administradores admin;

        public FormPerfil(Administradores admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void buttonContraseña_Click(object sender, EventArgs e)
        {
            FormCambiarPW_email f = new FormCambiarPW_email(admin, false);
            f.ShowDialog();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            FormCambiarPW_email f = new FormCambiarPW_email(admin, true);
            f.ShowDialog();
        }
    }
}
