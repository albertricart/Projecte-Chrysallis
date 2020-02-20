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
    public partial class FormNuevoSocio : Form
    {
        public FormNuevoSocio()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNuevoSocio_Load(object sender, EventArgs e)
        {
            bindingSourceComunidad.DataSource = null;
            bindingSourceComunidad.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();
             
        }
    }
}
