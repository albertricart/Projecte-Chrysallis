﻿using System;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormLogin : Form
    {
        //========================================================================================================//
        //                                                VARIABLES
        //========================================================================================================//
        //administrador con el que se haya entrado en la aplicación
        public static Administradores adminLogeado;
        bool valido = false, //para comprobar si el login es correcto o no
            pwVisible = false; //para comprobar si la contraseña es visible o no (con '•')

        //========================================================================================================//
        //                                              CONSTRUCTORES
        //========================================================================================================//
        public FormLogin()
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
        /// Evento que se activa al cargar el formulario
        /// </summary>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelIncorrectos.Visible = false;
        }

        /// <summary>
        /// evento formclosing que cierra la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!valido)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// evento click al boton para intentar logearse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            intentarLogin();
        }

        private void textBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                intentarLogin();
            }
        }

        /// <summary>
        /// Prueba de loguearse con el email y contraseña de los TextBoxs. Si es correcto,
        /// accede a la app, si es incorrecto muestra el mensaje de error
        /// </summary>
        private void intentarLogin()
        {
            Administradores admin = Base_de_Datos.ORM_Admin.SelectAdminLogin(textBoxEmail.Text, textBoxContrasenya.Text);

            if (admin == null)
            {
                valido = false;
                labelIncorrectos.Visible = true;
            }
            else
            {
                adminLogeado = new Administradores();

                adminLogeado.superadmin = admin.superadmin;
                adminLogeado.id = admin.id;
                adminLogeado.nombre = admin.nombre;
                adminLogeado.apellidos = admin.apellidos;
                adminLogeado.email = admin.email;
                adminLogeado.contrasenya = admin.contrasenya;
                adminLogeado.Eventos = admin.Eventos;
                adminLogeado.Comunidades = admin.Comunidades;

                valido = true;

                Hide();
                FormMenu formMenu = new FormMenu();
                labelIncorrectos.Visible = false;
                formMenu.ShowDialog();
                textBoxEmail.Clear();
                textBoxContrasenya.Clear();
                Show();
            }
        }

        //Eventos que se activa al tabular para acceder a los TextBox email y contraseña
        //Sirve para seleccionar todo el texto del TextBox
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            textBoxEmail.SelectAll();
        }
        private void textBoxContrasenya_Enter(object sender, EventArgs e)
        {
            textBoxContrasenya.SelectAll();
        }



        /// <summary>
        /// Evento que se activa cuando se hace click en el ojo
        /// </summary>
        private void pictureBoxOjo_Click(object sender, EventArgs e)
        {
            //Si la contraseña es visible la vuelve oculta y cambia la imagen del ojo, para que sepa
            //que está activada
            if (pwVisible)
            {
                pwVisible = false;
                textBoxContrasenya.PasswordChar = '•';

                pictureBoxOjo.Image = Properties.Resources.ojo;
            }
            //Si está oculta la vuelve visible
            else
            {
                pwVisible = true;
                textBoxContrasenya.PasswordChar = '\0';
                pictureBoxOjo.Image = Properties.Resources.ojoActivado;
            }
        }
    }
}
