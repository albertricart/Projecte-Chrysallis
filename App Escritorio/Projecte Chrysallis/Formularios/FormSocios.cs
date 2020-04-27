using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormSocios : Form
    {
        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//
        public FormSocios()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          EVENTOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// Evento click en un socio para modificarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarSocio();
        }

        /// <summary>
        /// Evento click del boton añadir un socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSocio formNuevoSocio = new FormSocio();
            formNuevoSocio.ShowDialog();
            Show();
            MostrarSocios();
        }

        /// <summary>
        /// Evento click del boton modificar un socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //modificaremos el socio al que tengamos seleccionado
            ModificarSocio();
        }

        /// <summary>
        /// Evento click del boton eliminar un socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //eliminaremos el socio al que tengamos seleccionado
            EliminarSocio();
        }


        /// <summary>
        /// Metodo load del form que refresca la grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSocios_Load(object sender, EventArgs e)
        {
            MostrarSocios();
        }

        /// <summary>
        /// Evento click del boton atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento textchanged del textboxfiltro que filtra los socios segun el texto que haya
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

        /// <summary>
        /// evento selectedindexchanged del comboboxfiltro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSocios();
            textBoxFiltro.Clear();

            List<Socios> socios = null;
            if (comboBoxFiltro.SelectedItem.ToString().Equals("Activos"))
            {
                socios = Base_de_Datos.ORM_Socio.SelectSocioByActivos();
                FiltrarSocios(socios);
                textBoxFiltro.Enabled = false;
            }
            else if (comboBoxFiltro.SelectedItem.ToString().Equals("No Activos"))
            {
                socios = Base_de_Datos.ORM_Socio.SelectSocioByNoActivos();
                FiltrarSocios(socios);
                textBoxFiltro.Enabled = false;
            }
            else
            {
                textBoxFiltro.Enabled = true;
            }
        }

        /// <summary>
        /// evento cellformatting de la grid para mostrar el nombre de la comunidad en lugar del nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSocios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Socios socio = (Socios)dataGridViewSocios.Rows[e.RowIndex].DataBoundItem;
                if (socio != null || socio.Comunidades1 != null || socio.Comunidades != null)
                {
                    e.Value = socio.Comunidades.nombre;
                }
            }
        }

        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          METODOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// metodo que modifica el socio seleccionado
        /// </summary>
        public void ModificarSocio()
        {
            Socios socio = ObtenerSocioSeleccionado();
            if (socio != null)
            {
                Hide();
                FormSocio formModificarSocio = new FormSocio(socio);
                formModificarSocio.ShowDialog();
                Show();
                MostrarSocios();
            }

        }

        /// <summary>
        /// metodo que elimina el socio seleccionado
        /// </summary>
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
                        MostrarSocios();
                    }
                    else
                    {
                        MessageBox.Show("Socio no eliminado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        /// <summary>
        /// metodo que devuelve el socio seleccionado
        /// </summary>
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

        /// <summary>
        /// metodo que devuelve si hay socios
        /// </summary>
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

        /// <summary>
        /// metodo que filtra los socios que se reciben por parametro
        /// </summary>
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

        /// <summary>
        /// metodo que refresca la grid 
        /// </summary>
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

    }
}
