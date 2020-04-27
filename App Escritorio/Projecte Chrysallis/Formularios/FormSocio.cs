using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormSocio : Form
    {
        //========================================================================================================//
        //                                                VARIABLES
        //========================================================================================================//
        //Evento seleccionado en el formEventos
        public Socios socio = new Socios();
        //Variable para indicar si queremos añadir o modificar un evento
        public bool modificar;
        List<Comunidades> comunidadesInteres = new List<Comunidades>();
        List<Comunidades> comunidadesEspana = new List<Comunidades>();


        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//

        public FormSocio()
        {
            InitializeComponent();
            modificar = false;
            buttonAnadir.BackgroundImage = Projecte_Chrysallis.Properties.Resources.botonAnadir;
        }
        public FormSocio(Socios socio)
        {
            InitializeComponent();
            this.socio = socio;
            modificar = true;
            HabilitarModificarContrasena();
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          EVENTOS
        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//

        /// <summary>
        /// Evento click del boton atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// evento para generar una contraseña aleatoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerar.Checked == true)
            {
                textBoxContrasena.PasswordChar = '\0';
                textBoxContrasena.Text = Membership.GeneratePassword(12, 6);
            }
            else
            {
                textBoxContrasena.Clear();
            }
        }

        /// <summary>
        /// Evento load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSocio_Load(object sender, EventArgs e)
        {
            comunidadesEspana = Base_de_Datos.ORM_Comunidades.SelectComunidades();
            comboBoxComunidadSocio.DataSource = FormLogin.adminLogeado.Comunidades.ToList();
            bindingSourceComunidades.DataSource = comunidadesEspana.ToList();

            if (!modificar)
            {
                bindingSourceComInteres.DataSource = null;
                listBoxComunidades.ClearSelected();
                comunidadesInteres.Clear();
            }
            else
            {
                RellenarCampos();
            }
        }

        /// <summary>
        /// evento click del boton para guardar el socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Socios socio = RecogerDatos();

            if (socio != null)
            {
                String mensaje;
                if (modificar)
                {
                    mensaje = Base_de_Datos.ORM_Socio.UpdateSocio(socio);
                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("Socio modificado correctamente.", "Socio Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar el socio: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    mensaje = Base_de_Datos.ORM_Socio.InsertSocio(socio);
                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("Socio añadido correctamente.", "Socio Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido añadir el socio: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        /// <summary>
        /// boton para añadir comunidades de interes al socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnviarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidades.SelectedItems)
            {
                if (!comunidadesInteres.Contains(comunidad))
                {
                    comunidadesInteres.Add(comunidad);
                }
            }

            RefrescarComunidades();
        }

        /// <summary>
        /// boton para quitar comunidades de interes al socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidadesInteresSocio.SelectedItems)
            {
                comunidadesInteres.Remove(comunidad);
            }

            RefrescarComunidades();
        }

        /// <summary>
        /// evento selectedindexchanged del combobox de la comunidad del socio, que añade la comunidad del socio como
        /// comunidad de interes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxComunidadSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComunidadSocio.SelectedIndex != -1)
            {
                Comunidades comunidad = (Comunidades)comboBoxComunidadSocio.SelectedItem;

                if (!comunidadesInteres.Contains(comunidad))
                {
                    comunidadesInteres.Add(comunidad);
                }

                RefrescarComunidades();
            }


        }


        /// <summary>
        /// evento click del checkboxmodificarcontra que gestiona el proceso de modificar la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxModificarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificarContra.Checked)
            {
                textBoxContrasena.Clear();
                textBoxContrasena.Enabled = true;
                checkBoxGenerar.Enabled = true;
                textBoxContrasena.PasswordChar = '\0';
            }
            else
            {
                textBoxContrasena.Text = this.socio.contrasenya;
                textBoxContrasena.PasswordChar = '•';
                textBoxContrasena.Enabled = false;
                checkBoxGenerar.Enabled = false;
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
        ///metodo que rellena los campos del form con el socio que recibimos en el constructor
        /// </summary>
        public void RellenarCampos()
        {
            List<Comunidades> com = new List<Comunidades>();
            foreach (Comunidades comunidad in socio.Comunidades1)
            {
                com.Add(comunidad);
            }

            textBoxNombre.Text = socio.nombre;
            textBoxDni.Text = socio.dni;
            textBoxContrasena.Text = socio.contrasenya;
            textBoxApellidos.Text = socio.apellidos;
            textBoxEmail.Text = socio.email;
            textBoxTelefono.Text = socio.telefono.ToString();
            textBoxPoblacion.Text = socio.poblacion;
            comboBoxComunidadSocio.SelectedValue = socio.idComunidad;
            checkBoxSocioActivo.Checked = socio.activo;
            bindingSourceComInteres.DataSource = null;
            bindingSourceComInteres.DataSource = com;
        }

        /// <summary>
        /// metodo la refrescar la lista de comunidades de interes del socio
        /// </summary>
        public void RefrescarComunidades()
        {
            bindingSourceComInteres.DataSource = null;
            bindingSourceComInteres.DataSource = comunidadesInteres;
            listBoxComunidades.ClearSelected();
            listBoxComunidadesInteresSocio.ClearSelected();
        }

        /// <summary>
        /// metodo para que no se muestre la contraseña del usuario
        /// </summary>
        public void HabilitarModificarContrasena()
        {
            checkBoxGenerar.Enabled = false;
            textBoxContrasena.Enabled = false;
            textBoxContrasena.PasswordChar = '•';
            checkBoxModificarContra.Visible = true;
        }

        /// <summary>
        /// metodo que recoge los datos y devuelve un nuevo socio con ellos
        /// </summary>
        /// <returns></returns>
        public Socios RecogerDatos()
        {
            Socios socio = new Socios();

            if (CamposCorrectos())
            {
                socio.id = this.socio.id;
                socio.nombre = textBoxNombre.Text;
                socio.dni = textBoxDni.Text;
                socio.apellidos = textBoxApellidos.Text;
                socio.email = textBoxEmail.Text;
                socio.telefono = int.Parse(textBoxTelefono.Text);
                socio.poblacion = textBoxPoblacion.Text;
                socio.idComunidad = (byte)comboBoxComunidadSocio.SelectedValue;
                socio.Comunidades1 = comunidadesInteres;
                socio.activo = checkBoxSocioActivo.Checked;
                if (checkBoxModificarContra.Checked)
                {
                    socio.contrasenya = textBoxContrasena.Text;
                }
                else
                {
                    if (modificar)
                    {
                        socio.contrasenya = this.socio.contrasenya;
                    }
                    else
                    {
                        socio.contrasenya = textBoxContrasena.Text;
                    }

                }
            }
            else
            {
                socio = null;
            }


            return socio;
        }


        /// <summary>
        /// metodo que verifica que los campos no contengan errores
        /// </summary>
        /// <returns></returns>
        public bool CamposCorrectos()
        {
            bool correcto = false;
            bool numsDniCorrecto = true;

            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Rellena los campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (textBoxTelefono.Text.Length != 9 || !textBoxTelefono.Text.All(char.IsDigit) || int.Parse(textBoxTelefono.Text) < 600000000 || int.Parse(textBoxTelefono.Text) > 999999999)
                {
                    MessageBox.Show("El campo teléfono se compone de 9 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (textBoxDni.Text.Length != 9 || !char.IsLetter(textBoxDni.Text[8]))
                    {
                        MessageBox.Show("Introduce el DNI de 9 carácteres con la letra al final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        foreach (char c in textBoxDni.Text.Substring(0, 8))
                        {
                            if (char.IsLetter(c))
                                numsDniCorrecto = false;
                        }
                        if (numsDniCorrecto == false)
                        {
                            MessageBox.Show("Introduce el DNI de 9 carácteres con la letra al final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            if (comboBoxComunidadSocio.SelectedItem == null)
                            {
                                MessageBox.Show("Selecciona la comunidad del socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                if (comunidadesInteres.Count == 0)
                                {
                                    MessageBox.Show("Selecciona las comunidades de interés del socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

    }
}
