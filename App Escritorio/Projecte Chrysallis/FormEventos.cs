using System;
using System.Collections.Generic;
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
            List<Evento> eventos = new List<Evento>();
            Evento evento = new Evento();
            Evento evento2 = new Evento();
            eventos.Add(evento);
            eventos.Add(evento2);
            evento.titulo = "test";
            evento.descripcion = "esta es la descripcion del evento";
            evento.ubicacion = "Plaza Urquiaona 10";
            evento2.titulo = "tessst 2";
            dataGridViewEventos.AutoGenerateColumns = false;
            dataGridViewEventos.DataSource = eventos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
