﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormEvento : Form
    { 
        //Evento seleccionado en el formEventos
        public Eventos evento;
        //Variable para indicar si queremos añadir o modificar un evento
        public bool modificar;

        //========================================================================================================//
        //CONSTRUCTOR
        //========================================================================================================//
        /// <summary>
        /// CONSTRUCTOR VACIO POR DEFECTO QUE SE USA PARA AÑADIR UN NUEVO EVENTO
        /// </summary>
        public FormEvento()
        {
            InitializeComponent();
            modificar = false;
        }

        /// <summary>
        /// CONSTRUCTOR PARAMETRIZADO PARA MODIFICAR UN EVENTO
        /// </summary>
        /// <param name="id"></param>
        public FormEvento(Eventos evento)
        {
            InitializeComponent();
            this.evento = evento;
            modificar = true;
        }



        //========================================================================================================//
        //EVENTOS
        //========================================================================================================//

        /// <summary>
        /// ==EVENTO LOAD==
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void FormCrearEvento_Load(object sender, EventArgs e)
        {
            //obtenemos las comunidades de la bd en el bindingSourceComunidades, que sera el datasource de la combobox
            bindingSourceComunidades.DataSource = null;
            bindingSourceComunidades.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();

            //si estamos modificando el form...
            if (modificar == true)
            {
                //rellenaremos los datos del evento que hayamos seleccionado en el formEventos
                RellenarCamposModificar();
                //en lugar de crear evento, guardaremos el evento modificado
                buttonCrearEvento.Text = "GUARDAR EVENTO";

            }

            //propiedad para que le textboxtitulo no tenga focus
            ActiveControl = pictureBoxAtras;  
        }


        /// <summary>
        /// EVENTO CLICK DEL BOTON ATRÁS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// EVENTO CLICK DEL BOTON PARA CREAR O MODIFICAR EL EVENTO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {
            if (CamposCorrectos())
            {
                if (modificar == true)
                {
                    Base_de_Datos.ORM_Evento.UpdateEvento(evento.id, textBoxTitulo.Text, dateTimePickerEvento.Value.Date.Add(dateTimePickerEvento.Value.TimeOfDay),
                    textBoxUbicacion.Text, textBoxDescripcion.Text, dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay), (byte)comboBoxComunidades.SelectedValue, Formularios.FormLogin.idAdmin);
                    MessageBox.Show("Evento modficado correctamente", "Evento Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Base_de_Datos.ORM_Evento.InsertEvento(textBoxTitulo.Text, dateTimePickerEvento.Value.Date.Add(dateTimePickerEvento.Value.TimeOfDay),
                    textBoxUbicacion.Text, textBoxDescripcion.Text, dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay), (byte)comboBoxComunidades.SelectedValue, Formularios.FormLogin.idAdmin);
                    MessageBox.Show("Evento añadido correctamente", "Evento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

        /// <summary>
        /// METODO PARA VERIFICAR QUE LOS CAMPOS ESTEN CORRECTOS
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// METODO PARA RELLENAR LOS CAMPOS DEL EVENTO QUE QUERAMOS MODIFICAR
        /// </summary>
        public void RellenarCamposModificar()
        {
            textBoxTitulo.Text = evento.titulo;
            textBoxUbicacion.Text = evento.ubicacion;
            textBoxDescripcion.Text = evento.descripcion;
            comboBoxComunidades.SelectedValue = evento.idComunidad;
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