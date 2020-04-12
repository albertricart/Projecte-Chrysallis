using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private Eventos _evento;
        //Variable para indicar si queremos añadir o modificar un evento
        private bool modificar;
        //lista de los documentos del nuevo evento
        private List<Documentos> _documentos = new List<Documentos>();
        //lista de las notificaciones del nuevo evento
        private List<Notificaciones> notificaciones = new List<Notificaciones>();
        //click para saber si el usuario ha modificado o añadido un evento
        private bool clickBotonEvento = false;


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
            modificar = true;
            _evento = evento;

            foreach (Documentos documento in evento.Documentos)
            {
                _documentos.Add(documento);
            }

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
                buttonAccionEvento.Text = "GUARDAR EVENTO";
            }

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
            RefrescarListDocumentos();
            RefrescarListNotificaciones();
        }


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
        /// Evento click del boton para crear o modificar el evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccionEvento_Click(object sender, EventArgs e)
        {
            clickBotonEvento = true;

            if (CamposCorrectos())
            {
                String mensaje;
                Eventos evento;

                evento = RecogerDatos();

                if (modificar)
                {
                    evento.id = _evento.id;
                    mensaje = Base_de_Datos.ORM_Evento.UpdateEvento(evento);
                    MessageBox.Show("Evento modificado correctamente. " + mensaje, "Evento Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mensaje = Base_de_Datos.ORM_Evento.InsertEvento(evento);
                    MessageBox.Show("Evento añadido correctamente. " + mensaje, "Evento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
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
            if (doc != null)
            {
                _documentos.Add(doc);
                RefrescarListDocumentos();
            }
        }

        /// <summary>
        /// Evento click del botón eliminar un documento del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEliminarDoc_Click(object sender, EventArgs e)
        {
            if (listBoxDocumentos.SelectedItem != null)
            {
                _documentos.Remove((Documentos)listBoxDocumentos.SelectedItem);
                RefrescarListDocumentos();
            }
            else
            {
                MessageBox.Show("Selecciona el documento que quieras eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento click del botón ver un documento del evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxVerDoc_Click(object sender, EventArgs e)
        {
            if (listBoxDocumentos.SelectedItem != null)
            {
                Documentos documento = (Documentos)listBoxDocumentos.SelectedItem;
                File.WriteAllBytes(documento.url, documento.datos);
                try
                {
                    Process.Start(documento.url);
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show("El documento seleccionado no puede visualizarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al abrir el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona el documento que quieras ver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        /// <summary>
        /// Evento FormClosing que llama al metodo CerrarForm()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clickBotonEvento == false)
            {
                if (MessageBox.Show("Perderás los datos introducidos, quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();
                }
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
        /// Recoge los datos que esten introducidos en el form y crea un evento con ellos
        /// </summary>
        /// <returns></returns>
        public Eventos RecogerDatos()
        {
            Eventos evento = new Eventos();
            evento.titulo = textBoxTitulo.Text;
            evento.fecha = dateTimePickerEvento.Value.Date.Add(dateTimePickerEvento.Value.TimeOfDay);
            evento.ubicacion = textBoxCalle.Text + ", " + textBoxCiudad.Text;
            evento.descripcion = textBoxDescripcion.Text;
            evento.fecha_limite = dateTimePickerLimite.Value.Date.Add(dateTimePickerLimite.Value.TimeOfDay);
            evento.idComunidad = (byte)comboBoxComunidades.SelectedValue;
            evento.idAdmin = FormLogin.adminLogeado.id;
            evento.Documentos = _documentos;
            evento.Notificaciones = notificaciones;

            return evento;
        }

        /// <summary>
        /// Metodo para rellenar los campos del evento que queramos modificar
        /// </summary>
        public void RellenarCamposModificar()
        {
            textBoxTitulo.Text = _evento.titulo;
            textBoxCalle.Text = _evento.ubicacion;
            textBoxDescripcion.Text = _evento.descripcion;
            comboBoxComunidades.SelectedValue = _evento.idComunidad;
            dateTimePickerEvento.Value = _evento.fecha;
            dateTimePickerLimite.Value = (DateTime)_evento.fecha_limite;
            bindingSourceDocumentos.DataSource = _documentos;
            //listBoxNotificaciones.DataSource = _evento.Notificaciones.ToList();

            if (EventoFinalizado(_evento))
            {
                labelValoracion.Visible = true;
                labelValoracion.Text += _evento.valoracionMedia.ToString();
            }
            else
            {
                labelValoracion.Hide();
            }

        }

        /// <summary>
        /// Metodo que abre un showdialog para seleccionar un documento que querramos adjuntar al evento
        /// </summary>
        /// <returns></returns>
        public Documentos SeleccionarDocumento()
        {
            Documentos documento = new Documentos();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos (*.*)|*.*|Documentos de texto (*.txt)|*.txt|Imágenes (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documento.url = openFileDialog.FileName;
                try
                {
                    documento.datos = File.ReadAllBytes(documento.url);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("El documento no se puede abrir porque ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    documento = null;
                }
            }
            else
            {
                documento = null;
            }

            return documento;
        }

        /// <summary>
        /// Metodo para refrescar la lista de documentos
        /// </summary>
        public void RefrescarListDocumentos()
        {
            bindingSourceDocumentos.DataSource = null;
            bindingSourceDocumentos.DataSource = _documentos;
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
                    comboBoxComunidades.SelectedValue = FormLogin.adminLogeado.Comunidades.First().id;
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

            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) || textBoxTitulo.Text.Equals("Evento..."))
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