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
    public partial class FormContacto : Form
    {
        public FormContacto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            pictureBoxNombre.Visible = false;
            pictureBoxEmail.Visible = false;
            pictureBoxEmail2.Visible = false;
            pictureBoxAsunto.Visible = false;
            pictureBoxMensaje.Visible = false;
        }
    }
}
