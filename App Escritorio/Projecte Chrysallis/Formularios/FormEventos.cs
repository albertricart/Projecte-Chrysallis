using Projecte_Chrysallis.Formularios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormEventos : Form
    {
        int ultimoEventoSeleccionado;

        //========================================================================================================//
        //CONSTRUCTORES
        //========================================================================================================//
        /// <summary>
        /// Constructor vacío por defecto
        /// </summary>
        public FormEventos()
        {
            InitializeComponent();
        }


        //========================================================================================================//
        //EVENTOS
        //========================================================================================================//
        /// <summary>
        /// Evento Load del Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEventos_Load(object sender, EventArgs e)
        {
            RefrescarGrid();
            dataGridViewEventos.ClearSelection();
        }

        /// <summary>
        /// Evento Activated del Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEventos_Activated(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        /// <summary>
        /// Evento click del botón atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Evento click del boton añadir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormEvento formCrearEvento = new FormEvento();
            formCrearEvento.ShowDialog();
            Show();
        }


        /// <summary>
        /// Evento CellDoubleClick del datagridview Eventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //modificaremos el evento al que le hayamos dado doble click
            ModificarEvento();
        }

        /// <summary>
        /// Evento click del botón modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxModificar_Click_1(object sender, EventArgs e)
        {
            //modificaremos el evento al que tengamos seleccionado
            ModificarEvento();
        }

        /// <summary>
        /// Evento click del botón eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEliminar_Click(object sender, EventArgs e)
        {
            //eliminamos el evento seleccionado
            EliminarEvento(ObtenerEventoSeleccionado());
        }


        //========================================================================================================//
        //METODOS
        //========================================================================================================//
        /// <summary>
        /// Método para obtener el evento que hayamos seleccionado
        /// </summary>
        /// <returns></returns>
        public Eventos ObtenerEventoSeleccionado()
        {
            Eventos evento = new Eventos();

            if (EventosExistentes())
            {
                evento = (Eventos) dataGridViewEventos.SelectedRows[0].DataBoundItem;
                ultimoEventoSeleccionado = dataGridViewEventos.SelectedRows[0].Index;
            }
            return evento;
        }

        /// <summary>
        /// Método para abrir el form para modificar el evento
        /// </summary>
        public void ModificarEvento()
        {
            if (EventosExistentes())
            {
                Hide();
                FormEvento formModificarEvento = new FormEvento(ObtenerEventoSeleccionado());
                formModificarEvento.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("No hay eventos", "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Método para eliminar el evento que hayamos seleccionado
        /// </summary>
        public void EliminarEvento(Eventos evento)
        {
            if (evento != null)
            {
                //pediremos al usuario si esta seguro si quiere eliminarlo
                var respuesta = MessageBox.Show("Seguro que quieres eliminar el evento seleccionado?", "Eliminar Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //eliminamos el evento si le da click en si
                    String mensaje = Base_de_Datos.ORM_Evento.DeleteEvento(evento);
                    if (mensaje.Equals(""))
                    {
                        RefrescarGrid();
                        MessageBox.Show("El evento " + evento.titulo + " ha sido eliminado", "Evento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay eventos", "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Metodo para comprobar si hay eventos en la grid
        /// </summary>
        /// <returns></returns>
        public bool EventosExistentes()
        {
            if (dataGridViewEventos.SelectedRows.Count == 0)
            { 
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metodo que refresca los datos de la gridview segun los eventos que tenga asignado el adminLogeado
        /// </summary>
        public void RefrescarGrid()
        {
            if (FormLogin.adminLogeado.superadmin)
            {
                //el bindingSource obteniene los eventos de la bd
                bindingSourceEventos.DataSource = null;
                bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
            }
            else
            {
                //el bindingSource obteniene los eventos de la bd
                bindingSourceEventos.DataSource = null;
                bindingSourceEventos.DataSource = FormLogin.adminLogeado.Eventos.ToList();
            }


            if (EventosExistentes())
            {
                dataGridViewEventos.Rows[ultimoEventoSeleccionado].Selected = true;
            }


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
