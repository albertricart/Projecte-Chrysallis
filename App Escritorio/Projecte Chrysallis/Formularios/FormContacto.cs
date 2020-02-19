using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_Chrysallis.Formularios
{
    public partial class FormContacto : Form
    {

        //Constantes
        private const string mailChrysallis = "project.chrysallis@gmail.com",
                            contrasenya = "SUwpYm63";
        private const byte MAX_CAR_NOM = 40,
                             MIN_CAR_NOM = 3,
                             MAX_CAR_EMAIL = 50,
                             MIN_CAR_EMAIL = 5,
                             MAX_CAR_ASUN = 45,
                             MIN_CAR_ASUN = 5,
                             MIN_CAR_MSJ = 10;
        private const int MAX_CAR_MSJ = 1000;

        /// <summary>
        /// Comprueba la cadena del textBoxEmail y retorna un booleano indicado si el campo es válido o no.
        /// Se pasa, por parámetro, la cadena.
        /// </summary>
        /// 
        /// <param name="email">El email (string) a comprobar</param>
        /// <returns>Devuelve true si es un campo correcto</returns>
        private bool comprobarEmail(String email)
        {
            //Damos por hecho que es válido puesto que todas las condiciones a las que someteremos al String
            //lo invalidan en caso de cumplir cualquiera de ellas
            bool correcto = true;

            int contadorArrobas = 0;
            foreach (char c in email)
            {
                if (c == '@')
                {
                    contadorArrobas++;
                }
            }


            if (email.Equals(null))
            {
                correcto = false;
            }
            else if (email.Length < MIN_CAR_EMAIL || email.Length > MAX_CAR_EMAIL)
            {
                correcto = false;
            }
            else if (String.IsNullOrWhiteSpace(email))
            {
                correcto = false;
            }
            else if (email.Contains(" "))
            {
                correcto = false;
            }
            else if (contadorArrobas == 0 || contadorArrobas > 1)
            {
                correcto = false;
            }

            return correcto;
        }

        /// <summary>
        /// Comprueba la cadena de algún textBox simple (cualquiera menos el email) y retorna un booleano indicado si el campo es válido o no.
        /// Se pasa, por parámetro, la cadena a verificar y otra cadena indicando qué campo es.
        /// </summary>
        /// 
        /// <param name="str">El string a comprobar</param>
        /// <param name="campo">Qué campo es</param>
        /// <returns>Devuelve true si es un campo correcto</returns>
        private bool comprobarCampoSimple(String str, String campo)
        {
            //Damos por hecho que es válido puesto que todas las condiciones a las que someteremos al String
            //lo invalidan en caso de cumplir cualquiera de ellas
            bool correcto = true;


            if (str.Equals(null))
            {
                correcto = false;
            }
            else if (String.IsNullOrWhiteSpace(str))
            {
                correcto = false;
            }

            //Comprobamos las correspondientes Length dependiendo de qué campo sea
            switch (campo)
            {
                case "nombre":
                    if (str.Length < MIN_CAR_NOM || str.Length > MAX_CAR_NOM)
                        correcto = false;
                    break;

                case "asunto":
                    if (str.Length < MIN_CAR_ASUN || str.Length > MAX_CAR_ASUN)
                        correcto = false;
                    break;

                default:
                    if (str.Length < MIN_CAR_MSJ || str.Length > MAX_CAR_MSJ)
                        correcto = false;
                    break;
            }

            return correcto;
        }






        public FormContacto()
        {
            InitializeComponent();
        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            pictureBoxNombre.Visible = false;
            pictureBoxEmail.Visible = false;
            pictureBoxEmail2.Visible = false;
            pictureBoxAsunto.Visible = false;
            pictureBoxMensaje.Visible = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            //Asignamos el valor de los textbox a unas variables para trabajar más cómodamente
            //con ellos
            String nombre = textBoxNom.Text,
                    email = textBoxEmail.Text,
                    emailVerif = textBoxEmail2.Text,
                    asunto = textBoxAsunto.Text,
                    mensaje = textBoxMensaje.Text;

            int numCamposCorrectos = 0;

            //Nombre
            nombre = nombre.Trim(' ');
            if (comprobarCampoSimple(nombre, "nombre"))
            {
                pictureBoxNombre.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxNombre.Visible = true;
            }

            //Emails
            if (comprobarEmail(email))
            {
                pictureBoxEmail.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxEmail.Visible = true;
            }

            if (email.Equals(emailVerif) && !String.IsNullOrEmpty(emailVerif))
            {
                pictureBoxEmail2.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxEmail2.Visible = true;
            }

            //Asunto
            asunto = asunto.Trim(' ');
            if (comprobarCampoSimple(asunto, "asunto"))
            {
                pictureBoxAsunto.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxAsunto.Visible = true;
            }

            //Mensaje
            mensaje = mensaje.Trim(' ');
            if (comprobarCampoSimple(mensaje, "mensaje"))
            {
                pictureBoxMensaje.Visible = false;
                numCamposCorrectos++;
            }
            else
            {
                pictureBoxMensaje.Visible = true;
            }



            if (numCamposCorrectos == 5)
            {
                try
                {
                    /* Para poder enviar correos se tiene que activar una opción desde la cuenta
                     * de Google del remitente (en nuestro caso space.experience.game@gmail.com)
                     * (que ya está hecho)
                     * Enlace directo: https://myaccount.google.com/lesssecureapps?pli=1
                     */

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


                    //Origen
                    mail.From = new MailAddress(mailChrysallis);
                    //Destinatario
                    mail.To.Add("jribgomez@gmail.com");
                    //Asunto
                    mail.Subject = asunto;
                    //Mensaje
                    mail.Body = "----------------------------------------" +
                                "\nDatos de contacto: " +
                                "\n\tNombre: " + nombre +
                                "\n\tEmail: " + email +
                                "\n----------------------------------------" +
                                "\n\n" + mensaje +
                                "\n\n\n" +
                                "**Mensaje enviado desde la app de escritorio**";

                    //------ PRUEBA -----
                    //https://www.codeproject.com/Tips/326346/How-to-embed-a-image-in-email-body
                    LinkedResource linkedResource = new LinkedResource(@"C:\Users\jribg\Desktop\usuario.png");
                    linkedResource.ContentId = "img";
                    linkedResource.ContentType = new System.Net.Mime.ContentType(MediaTypeNames.Image.Jpeg);
                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
                        "Captura <img src=cid:img>", null, "text/html");
                    htmlView.LinkedResources.Add(linkedResource);
                    mail.AlternateViews.Add(htmlView);
                    /////////////////////////////////////////////////

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(mailChrysallis, contrasenya);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Mensaje enviado." +
                                    "\nLe responderemos al correo que nos ha facilitado en la máxima brevedad posible." +
                                    "\n\nGracias." +
                                    "\nMeetChrysallis Team", "Mensaje enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha habido algún problema a la hora de enviar el correo." +
                                    "\nPor favor, compruebe que tiene acceso a internet y, de seguir persistiendo el error, " +
                                    "póngase en contacto con nosotros a través de nuestro email: \n\n" +
                                    mailChrysallis +
                                    "\n\nMuchas gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
