using Projecte_Chrysallis.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projecte_Chrysallis
{
    public partial class FormEventos : Form
    {
        //========================================================================================================//
        //                                          CONSTRUCTORES
        //========================================================================================================//
        /// <summary>
        /// Constructor vacío por defecto
        /// </summary>
        public FormEventos()
        {
            InitializeComponent();
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          EVENTOS
        //========================================================================================================//
        //========================================================================================================//
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
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxVer.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento activated del form
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
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            Hide();
            FormEvento formEvento = new FormEvento();
            formEvento.ShowDialog();
            Show();
            RefrescarGrid();
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
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //modificaremos el evento al que tengamos seleccionado
            ModificarEvento();
        }

        /// <summary>
        /// Evento click del botón eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //eliminamos el evento seleccionado
            EliminarEvento(ObtenerEventoSeleccionado());
        }

        /// <summary>
        /// Se filtran los eventos segun el filtro seleccionado y el input que recibimos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Eventos> eventos = null;
            if (!String.IsNullOrWhiteSpace(textBoxFiltro.Text))
            {
                if (comboBoxFiltro.SelectedIndex == 0)
                {
                    eventos = Base_de_Datos.ORM_Evento.SelectEventosByNombre(textBoxFiltro.Text);
                }
                if (comboBoxFiltro.SelectedIndex == 1)
                {
                    eventos = Base_de_Datos.ORM_Evento.SelectEventosByUbicacion(textBoxFiltro.Text);
                }

                FiltrarEventos(eventos);
            }
            else
            {
                RefrescarGrid();
            }

        }

        /// <summary>
        /// Evento cellformatting de la grid para mostrar el nombre del admin en lugar del numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && dataGridViewEventos.Rows.Count > 0)
            {
                Eventos evento = (Eventos)dataGridViewEventos.Rows[e.RowIndex].DataBoundItem;
                if (evento != null || evento.Administradores != null)
                {
                    e.Value = evento.Administradores.nombre;
                }
                else
                {
                    MessageBox.Show("El evento es nulo o no tiene administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (e.ColumnIndex == 7 && dataGridViewEventos.Rows.Count > 0)
            {
                Eventos evento = (Eventos)dataGridViewEventos.Rows[e.RowIndex].DataBoundItem;
                if (evento != null || evento.Administradores != null)
                {
                    e.Value = evento.Comunidades.nombre;
                }
                else
                {
                    MessageBox.Show("El evento es nulo o no tiene administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        /// <summary>
        /// Refrescamos la grid y limpiamos el textbox del filtro al cambiar el indice del combobox ver 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarGrid();
            textBoxFiltro.Clear();
        }

        /// <summary>
        /// Refrescamos la grid y limpiamos el textbox del filtro al cambiar el indice del combobox filtro 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarGrid();
            textBoxFiltro.Clear();
        }


        //========================================================================================================//
        //========================================================================================================//
        //========================================================================================================//
        //                                          METODOS
        //========================================================================================================//
        //========================================================================================================//
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
                evento = (Eventos)dataGridViewEventos.SelectedRows[0].DataBoundItem;
                //ultimoEventoSeleccionado = dataGridViewEventos.SelectedRows[0].Index;
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
        /// Metodo que refresca los datos de la gridview
        /// </summary>
        public void RefrescarGrid()
        {
            if (comboBoxVer.SelectedIndex == 1)
            {
                bindingSourceEventos.DataSource = null;
                bindingSourceEventos.DataSource = FormLogin.adminLogeado.Eventos.ToList();
            }
            else
            {
                if (FormLogin.adminLogeado.superadmin)
                {
                    bindingSourceEventos.DataSource = null;
                    bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();

                }
                else
                {
                    List<Eventos> eventos = new List<Eventos>();
                    bindingSourceEventos.DataSource = null;

                    foreach (Comunidades c in FormLogin.adminLogeado.Comunidades)
                    {
                        eventos.AddRange(Base_de_Datos.ORM_Evento.SelectEventosByComunidad(c.id));
                    }

                    bindingSourceEventos.DataSource = eventos;
                }
            }
        }

        /// <summary>
        /// Metodo para filtrar los eventos de una lista que recibimos por parametro
        /// </summary>
        /// <param name="eventos"></param>
        public void FiltrarEventos(List<Eventos> eventos)
        {
            //por mi
            if (comboBoxVer.SelectedIndex == 1)
            {
                foreach (Eventos e in eventos.ToList())
                {
                    if (e.idAdmin != FormLogin.adminLogeado.id)
                    {
                        eventos.Remove(e);
                    }
                }
            }
            //todos
            else if (comboBoxVer.SelectedIndex == 0)
            {
                if (!FormLogin.adminLogeado.superadmin)
                {
                    foreach (Eventos e in eventos.ToList())
                    {
                        foreach (Comunidades c in FormLogin.adminLogeado.Comunidades)
                        {
                            if (e.idComunidad != c.id)
                            {
                                eventos.Remove(e);
                            }
                        }
                    }
                }
            }

            bindingSourceEventos.DataSource = null;
            bindingSourceEventos.DataSource = eventos;
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



