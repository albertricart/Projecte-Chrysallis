using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormEvento : Form
    {
        //========================================================================================================//
        //VARIABLES
        //========================================================================================================//
        //Evento seleccionado en el formEventos
        public Eventos evento;
        //Variable para indicar si queremos añadir o modificar un evento
        public bool modificar;
        //lista de los documentos del nuevo evento
        public List<Documentos> documentos = new List<Documentos>();
        //lista de las notificaciones del nuevo evento
        public List<Notificaciones> notificaciones = new List<Notificaciones>();


        //========================================================================================================//
        //CONSTRUCTORES
        //========================================================================================================//
        /// <summary>
        /// Constructor vacio por defecto que se usa para añadir un nuevo evento
        /// </summary>
        public FormEvento()
        {
            InitializeComponent();
            modificar = false;
        }

        /// <summary>
        /// Constructor parametrizado para modificar un evento
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

        private void FormEvento_Load(object sender, EventArgs e)
        {
            //rellenamos la combobox comunidades con todas la comunidades
            RellenarComunidades();

            //si estamos modificando el form...
            if (modificar == true)
            {
                //rellenaremos los datos del evento que hayamos seleccionado en el formEventos
                RellenarCamposModificar();
                //en lugar de crear evento, guardaremos el evento modificado
                buttonCrearEvento.Text = "GUARDAR EVENTO";
            }

            //no mostraremos el labelValoracion hasta que se haya acabado el evento
            labelValoracion.Hide();
            //propiedad para que le textboxtitulo no tenga focus
            ActiveControl = pictureBoxAtras;
        }

        /// <summary>
        /// Evento Activated del formEvento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEvento_Activated(object sender, EventArgs e)
        {
            if (modificar == false)
            {
                RefrescarListDocumentos();
                RefrescarListNotificaciones();
            }
        }


        /// <summary>
        /// Evento click del boton atrás
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
        /// Evento click del boton para crear o modificar el evento
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
                    textBoxCalle.Text, textBoxDescripcion.Text, dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay), (byte)comboBoxComunidades.SelectedValue, Formularios.FormLogin.adminLogeado.id, documentos, notificaciones);
                    MessageBox.Show("Evento modficado correctamente", "Evento Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Base_de_Datos.ORM_Evento.InsertEvento(textBoxTitulo.Text, dateTimePickerEvento.Value.Date.Add(dateTimePickerEvento.Value.TimeOfDay),
                    textBoxCalle.Text, textBoxDescripcion.Text, dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay), (byte)comboBoxComunidades.SelectedValue, Formularios.FormLogin.adminLogeado.id, documentos, notificaciones);
                    MessageBox.Show("Evento añadido correctamente", "Evento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }


        /// <summary>
        /// Evento click del botón para ajuntar un documento al evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAddDocumento_Click(object sender, EventArgs e)
        {
            Documentos doc = SeleccionarDocumento();
            documentos.Add(doc);
            RefrescarListDocumentos();
        }

        /// <summary>
        /// Evento click del botón eliminar un documento del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEliminarDoc_Click(object sender, EventArgs e)
        {
            documentos.Remove((Documentos)listBoxDocumentos.SelectedItem);
            RefrescarListDocumentos();
        }


        /// <summary>
        /// Evento click del botón añadir notificación del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAnadirNotificacion_Click(object sender, EventArgs e)
        {
            Notificaciones notificacion = new Notificaciones();
            int.TryParse(dateTimePickerNotificacion.Value.ToString(), out int antelacion);
            notificacion.antelacion = antelacion;
            notificaciones.Add(notificacion);
            RefrescarListNotificaciones();
        }


        /// <summary>
        /// Evento click del botón eliminar una notificación del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEliminarNotificacion_Click(object sender, EventArgs e)
        {
            notificaciones.Remove((Notificaciones)listBoxNotificaciones.SelectedItem);
            RefrescarListNotificaciones();
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
        /// Metodo para rellenar los campos del evento que queramos modificar
        /// </summary>
        public void RellenarCamposModificar()
        {
            textBoxTitulo.Text = evento.titulo;
            textBoxCalle.Text = evento.ubicacion;
            textBoxDescripcion.Text = evento.descripcion;
            comboBoxComunidades.SelectedValue = evento.idComunidad;
            dateTimePickerEvento.Value = evento.fecha;
            dateTimePickerLimite.Value = (DateTime)evento.fecha_limite;
            listBoxDocumentos.DataSource = evento.Documentos.ToList();
            listBoxNotificaciones.DataSource = evento.Notificaciones.ToList();

            if (EventoFinalizado(evento))
            {
                labelValoracion.Show();
                labelValoracion.Text += evento.valoracionMedia.ToString();
            }

        }

        /// <summary>
        /// Metodo para abrir un showdialog para seleccionar un documento que querramos adjuntar al evento
        /// </summary>
        /// <returns></returns>
        public Documentos SeleccionarDocumento()
        {
            Documentos documento = new Documentos();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento.url = openFileDialog.FileName;
            }
            return documento;
        }

        /// <summary>
        /// Metodo para refrescar la lista de documentos
        /// </summary>
        public void RefrescarListDocumentos()
        {
            listBoxDocumentos.DataSource = null;
            listBoxDocumentos.DataSource = documentos;
        }

        /// <summary>
        /// Metodo para refrescar la lista de notificaciones
        /// </summary>
        public void RefrescarListNotificaciones()
        {
            listBoxNotificaciones.DataSource = null;
            listBoxNotificaciones.DataSource = notificaciones;
        }

        /// <summary>
        /// Metodo para rellenar la comboboxComunidades con las comunidades de la bd
        /// </summary>
        public void RellenarComunidades()
        {
            //obtenemos las comunidades de la bd en el bindingSourceComunidades, que sera el datasource de la combobox
            bindingSourceComunidades.DataSource = null;
            bindingSourceComunidades.DataSource = Base_de_Datos.ORM_Comunidades.SelectComunidades();

            //si es administrador de una comunidad (no es super)
            if (!FormLogin.adminLogeado.superadmin)
            {
                try
                {
                    comboBoxComunidades.SelectedValue = (byte)FormLogin.adminLogeado.Comunidades.First().id;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No tienes ninguna comunidad asociada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        /// <summary>
        /// Metodo para comprovar si ha acabado el evento consultando la fecha del evento y la fecha actual
        /// </summary>
        /// <param name="evento"></param>
        /// <returns></returns>
        public bool EventoFinalizado(Eventos evento)
        {
            bool finalizado = false;
            if (DateTime.Now > evento.fecha)
            {
                finalizado = true;
            }
            return finalizado;
        }



        /// <summary>
        /// Metodo para verificar que los campos esten correctos
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
                if (string.IsNullOrWhiteSpace(textBoxCalle.Text))
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