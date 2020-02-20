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
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

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

        private void FormEventos_Load(object sender, EventArgs e)
        {
            bindingSourceEventos.DataSource = null ;
            bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxAnadir_Click(object sender, EventArgs e)
        {
            FormCrearEvento formCrearEvento = new FormCrearEvento();
            formCrearEvento.ShowDialog();
        }

        private void FormEventos_Activated(object sender, EventArgs e)
        {
            bindingSourceEventos.DataSource = null;
            bindingSourceEventos.DataSource = Base_de_Datos.ORM_Evento.SelectEventos();
        }

        private void dataGridViewEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarEvento();

        }

        public void ModificarEvento()
        {
            int.TryParse(dataGridViewEventos.SelectedRows[0].Cells[0].Value.ToString(), out int id);
            FormCrearEvento formEvento = new FormCrearEvento(id);
        }
    }
}
