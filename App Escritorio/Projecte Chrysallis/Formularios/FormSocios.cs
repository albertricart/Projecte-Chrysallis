using Projecte_Chrysallis.Base_de_Datos;
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
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //testeando
            Administradores admin = ORM_Admin.SelectAdminByID(1);
            MessageBox.Show(admin.email);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //testeando
            Socios socio = ORM_Socio.SelectSocioByID(1);
            MessageBox.Show(socio.apellidos);
        }
    }
}
