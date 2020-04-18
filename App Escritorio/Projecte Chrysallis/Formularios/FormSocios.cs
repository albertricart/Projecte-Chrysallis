using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        public void ModificarSocio()
        {
            Socios socio = ObtenerSocioSeleccionado();
            if (socio != null)
            {
                Hide();
                FormSocio formModificarSocio = new FormSocio(socio);
                formModificarSocio.ShowDialog();
                Show();
            }

        }

        public void EliminarSocio()
        {
            Socios socio = ObtenerSocioSeleccionado();

            if (socio != null)
            {
                if (MessageBox.Show("Quieres eliminar el socio seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String mensaje = Base_de_Datos.ORM_Socio.DeleteSocio(socio);

                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("Socio eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Socio no eliminado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }



        public Socios ObtenerSocioSeleccionado()
        {
            Socios socio = new Socios();

            if (SociosExistentes())
            {
                socio = (Socios)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            }
            else
            {
                socio = null;
            }

            return socio;

        }

        public bool SociosExistentes()
        {
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay socios", "Sin socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSocio formNuevoSocio = new FormSocio();
            formNuevoSocio.ShowDialog();
            Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //modificaremos el socio al que tengamos seleccionado
            ModificarSocio();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //eliminaremos el socio al que tengamos seleccionado
            EliminarSocio();
        }

        public void MostrarSocios()
        {
            List<Socios> listSocios = new List<Socios>();

            foreach (Comunidades comunidad in FormLogin.adminLogeado.Comunidades)
            {
                listSocios.AddRange(Base_de_Datos.ORM_Socio.SelectSocioByComunidad(comunidad.id).ToList());
            }

            bindingSourceSocios.DataSource = null;
            bindingSourceSocios.DataSource = listSocios;
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            MostrarSocios();
        }


        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Socios> socios = null;

            if (!String.IsNullOrWhiteSpace(textBoxFiltro.Text))
            {
                if (comboBoxFiltro.SelectedItem.ToString().Equals("ID") && textBoxFiltro.Text.All(char.IsDigit))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByID(int.Parse(textBoxFiltro.Text));
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("DNI"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByDNI(textBoxFiltro.Text);
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("Nombre"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByNombre(textBoxFiltro.Text);
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("Apellidos"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByApellidos(textBoxFiltro.Text);
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("Email"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByEmail(textBoxFiltro.Text);
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("Teléfono"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByTelefono(textBoxFiltro.Text);
                }
                else if (comboBoxFiltro.SelectedItem.ToString().Equals("Población"))
                {
                    socios = Base_de_Datos.ORM_Socio.SelectSocioByPoblacion(textBoxFiltro.Text);
                }

                FiltrarSocios(socios);
            }
            else
            {
                MostrarSocios();
                textBoxFiltro.Clear();
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSocios();
            textBoxFiltro.Clear();
        }
        //========================================================================================================//
        //OTROS
        //========================================================================================================//

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

        

        public void FiltrarSocios(List<Socios> socios)
        {
            if (!FormLogin.adminLogeado.superadmin)
            {
                foreach (Socios s in socios.ToList())
                {
                    foreach (Comunidades c in FormLogin.adminLogeado.Comunidades)
                    {
                        if (s.idComunidad != c.id)
                        {
                            socios.Remove(s);
                        }
                    }
                }
            }

            bindingSourceSocios.DataSource = null;
            bindingSourceSocios.DataSource = socios;
        }
    }
}
