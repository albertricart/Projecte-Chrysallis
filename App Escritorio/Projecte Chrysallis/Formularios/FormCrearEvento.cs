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
    public partial class FormCrearEvento : Form
    {
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

        //========================================================================================================//
        //CONSTRUCTOR
        //========================================================================================================//
        public FormCrearEvento()
        {
            InitializeComponent();
        }

        public FormCrearEvento(int id)
        {
            InitializeComponent();
        }



        //========================================================================================================//
        //EVENTOS
        //========================================================================================================//
        private void FormCrearEvento_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = null;
            bindingSourceComunidades.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();

            dateTimePickerEvento.Format = DateTimePickerFormat.Custom;
            dateTimePickerEvento.CustomFormat = "dd/MM/yyyy || hh:mm";
            dateTimePickerLimite.Format = DateTimePickerFormat.Custom;
            dateTimePickerLimite.CustomFormat = "dd/MM/yyyy || hh:mm";
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            // Pregunta si esta seguro que desea cerrar
            var respuesta = MessageBox.Show("Perderás los datos introducidos, quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si es así, se cierra el form
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {
            if (CamposCorrectos())
            {
                Base_de_Datos.ORM_Evento.InsertEvento(textBoxTitulo.Text, dateTimePickerEvento.Value.Date.Add(dateTimePickerEvento.Value.TimeOfDay),
                    textBoxUbicacion.Text, textBoxDescripcion.Text, dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay), 5, 1);
                MessageBox.Show("Evento añadido correctamente", "Evento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void textBoxTitulo_Enter(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text.Equals("Evento..."))
            {
                textBoxTitulo.Text = "";
                textBoxTitulo.ForeColor = Color.Black;
            }
        }

        private void textBoxTitulo_Leave(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text.Equals(""))
            {
                textBoxTitulo.Text = "Evento...";
                textBoxTitulo.ForeColor = Color.DimGray;
            }
        }

        //========================================================================================================//
        //METODOS
        //========================================================================================================//
        public bool CamposCorrectos()
        {
            bool correcto = false;

            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) || textBoxTitulo.Equals("Evento..."))
            {
                MessageBox.Show("Introduce un nombre para el evento", "Evento sin nombre", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxUbicacion.Text))
                {
                    MessageBox.Show("Introduce la ubicación del evento", "Evento sin ubicación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                    {
                        MessageBox.Show("Introduce una descripción para el evento", "Evento sin descripción ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        correcto = true;
                    }
                }
            }

            return correcto;
        }

        
    }
}
