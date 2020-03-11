using System;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormEventos : Form
    {

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
            if (Formularios.FormLogin.adminLogeado.superadmin == true)
            {
                //el bindingSource obteniene los eventos de la bd
                bindingSourceEventos.DataSource = null;
                bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
            }
            else
            {
                //el bindingSource obteniene los eventos de la bd
                bindingSourceEventos.DataSource = null;
                bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
            }


        }

        /// <summary>
        /// Evento Activated del Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEventos_Activated(object sender, EventArgs e)
        {
            //mantendremos el bindingSource actualizado cada vez que volvamos a este form o se actualice
            bindingSourceEventos.DataSource = null;
            bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
        }

        /// <summary>
        /// Evento click del botón atrás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento click del boton añadir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAnadir_Click(object sender, EventArgs e)
        {
            FormEvento formCrearEvento = new FormEvento();
            formCrearEvento.ShowDialog();
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
            if (EventosExistentes())
            {
                //eliminamos el evento seleccionado
                EliminarEvento(ObtenerEventoSeleccionado());
            }
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
            int.TryParse(dataGridViewEventos.SelectedRows[0].Cells[0].Value.ToString(), out int id);

            Eventos evento = Base_de_Datos.ORM_Evento.SelectEventoByID(id);
            return evento;

        }

        /// <summary>
        /// Método para abrir el form para modificar el evento
        /// </summary>
        public void ModificarEvento()
        {
            if (EventosExistentes())
            {
                FormEvento formModificarEvento = new FormEvento(ObtenerEventoSeleccionado());
                formModificarEvento.ShowDialog();
            }
        }

        /// <summary>
        /// Método para eliminar el evento que hayamos seleccionado
        /// </summary>
        public void EliminarEvento(Eventos evento)
        {
            //pediremos al usuario si esta seguro si quiere eliminarlo
            var respuesta = MessageBox.Show("Seguro que quieres eliminar el evento seleccionado?", "Eliminar Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                //eliminamos el evento si le da click en si
                Base_de_Datos.ORM_Evento.DeleteEvento(evento);
                MessageBox.Show("El evento " + evento.titulo + " ha sido eliminado", "Evento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                MessageBox.Show("No hay eventos", "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
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
