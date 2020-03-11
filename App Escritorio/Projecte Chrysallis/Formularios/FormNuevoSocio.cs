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

        public Boolean CamposCorrectos()
        {
            Boolean correcto = false;

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Introduce el nombre del socio", "Socio sin nombre", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
                {
                    MessageBox.Show("Introduce los apellidos del socio", "Socio sin apellidos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxDNI.Text))
                    {
                        MessageBox.Show("Introduce el DNI del socio", "Socio sin DNI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                        {
                            MessageBox.Show("Introduce el email del socio", "Socio sin email", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(textBoxTelefono.Text))
                            {
                                MessageBox.Show("Introduce el telefono del socio", "Socio sin telefono", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                if (string.IsNullOrWhiteSpace(textBoxPoblacion.Text))
                                {
                                    MessageBox.Show("Introduce la población del socio", "Socio sin población", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else
                                {
                                    correcto = true;
                                }
                            }
                        }
                    }
                }
            }
            return correcto;
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

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            if (CamposCorrectos())
            {
                Base_de_Datos.ORM_Socio.InsertSocio(textBoxDNI.Text, textBoxNombre.Text, textBoxApellidos.Text, textBoxEmail.Text, textBoxTelefono.Text, textBoxPoblacion.Text, (byte)comboBoxComunidad.SelectedIndex, true);
                MessageBox.Show("Socio añadido correctamente", "Socio Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
