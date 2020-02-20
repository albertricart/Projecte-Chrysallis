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
    public partial class FormAdmins : Form
    {
        public FormAdmins()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormNuevoAdmin f = new FormNuevoAdmin();
            f.ShowDialog();
        }

        private void checkBoxFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFiltrar.Checked)
            {
                comboBoxFiltro.Enabled = false;
                textBoxFiltro.Enabled = false;
                textBoxFiltro.Text = "";
            }
            else
            {
                comboBoxFiltro.Enabled = true;
                textBoxFiltro.Enabled = true;
            }
        }
    }
}
