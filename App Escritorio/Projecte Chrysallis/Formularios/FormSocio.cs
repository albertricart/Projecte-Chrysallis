using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormSocio : Form
    {
        //Evento seleccionado en el formEventos
        public Socios socio = new Socios();
        //Variable para indicar si queremos añadir o modificar un evento
        public bool modificar;
        List<Comunidades> comunidadesInteres = new List<Comunidades>();
        List<Comunidades> comunidadesEspana = new List<Comunidades>();




        public FormSocio()
        {
            InitializeComponent();
            modificar = false;
        }
        public FormSocio(Socios socio)
        {
            InitializeComponent();
            this.socio = socio;
            modificar = true;

            foreach (Comunidades comunidad in socio.Comunidades1)
            {
                comunidadesInteres.Add(comunidad);
            }
            RellenarCampos();
        }


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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            comunidadesEspana = Base_de_Datos.ORM_Comunidades.SelectComunidades();
            comboBoxComunidadSocio.DataSource = FormLogin.adminLogeado.Comunidades.ToList();
            bindingSourceComunidades.DataSource = comunidadesEspana;

            if (!modificar)
            {
                comboBoxComunidadSocio.SelectedIndex = -1;
                bindingSourceComInteres.DataSource = null;
                listBoxComunidades.ClearSelected();
                comunidadesInteres.Clear();
            }
        }

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

        public Socios RecogerDatos()
        {
            Socios socio = new Socios();

            if (CamposCorrectos())
            {
                socio.id = this.socio.id;
                socio.nombre = textBoxNombre.Text;
                socio.dni = textBoxDni.Text;
                socio.contrasenya = textBoxContrasena.Text;
                socio.apellidos = textBoxApellidos.Text;
                socio.email = textBoxEmail.Text;
                socio.telefono = int.Parse(textBoxTelefono.Text);
                socio.poblacion = textBoxPoblacion.Text;
                socio.idComunidad = (byte)comboBoxComunidadSocio.SelectedValue;
                socio.Comunidades1 = comunidadesInteres;
                socio.activo = checkBoxSocioActivo.Checked;
            }
            else
            {
                socio = null;
            }


            return socio;
        }

        public void RellenarCampos()
        {
            textBoxNombre.Text = socio.nombre;
            textBoxDni.Text = socio.dni;
            textBoxContrasena.Text = socio.contrasenya;
            textBoxApellidos.Text = socio.apellidos;
            textBoxEmail.Text = socio.email;
            textBoxTelefono.Text = socio.telefono.ToString();
            textBoxPoblacion.Text = socio.poblacion;
            comboBoxComunidadSocio.SelectedValue = socio.idComunidad;
            checkBoxSocioActivo.Checked = socio.activo;
            bindingSourceComInteres.DataSource = comunidadesInteres;
        }


        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerar.Checked == true)
            {
                textBoxContrasena.Text = Membership.GeneratePassword(12, 6);
            }
            else
            {
                if (modificar)
                {
                    textBoxContrasena.Text = socio.contrasenya;
                }
                else
                {
                    textBoxContrasena.Clear();
                }

            }
        }

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

        private void buttonQuitarComunidades_Click(object sender, EventArgs e)
        {
            foreach (Comunidades comunidad in listBoxComunidadesInteresSocio.SelectedItems)
            {
                comunidadesInteres.Remove(comunidad);
            }

            RefrescarComunidades();
        }

        public void RefrescarComunidades()
        {
            bindingSourceComInteres.DataSource = null;
            bindingSourceComInteres.DataSource = comunidadesInteres;
            listBoxComunidades.ClearSelected();
            listBoxComunidadesInteresSocio.ClearSelected();
        }

        private void comboBoxComunidadSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Focused)
            {
                Comunidades comunidad = (Comunidades)comboBoxComunidadSocio.SelectedItem;

                if (!comunidadesInteres.Contains(comunidad) && comboBoxComunidadSocio.SelectedIndex != -1)
                {
                    comunidadesInteres.Add(comunidad);
                    RefrescarComunidades();
                }
            }

        }
    }
}
