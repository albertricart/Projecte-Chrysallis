﻿namespace Projecte_Chrysallis.Formularios
{
    partial class FormContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.groupBoxDatosContacto = new System.Windows.Forms.GroupBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNombre = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.groupBoxMensaje = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBoxAsunto = new System.Windows.Forms.PictureBox();
            this.pictureBoxMensaje = new System.Windows.Forms.PictureBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDatosContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).BeginInit();
            this.groupBoxMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 23);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(21, 43);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(186, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(279, 202);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 6;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // groupBoxDatosContacto
            // 
            this.groupBoxDatosContacto.Controls.Add(this.pictureBoxEmail);
            this.groupBoxDatosContacto.Controls.Add(this.pictureBoxEmail2);
            this.groupBoxDatosContacto.Controls.Add(this.pictureBoxNombre);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxEmail2);
            this.groupBoxDatosContacto.Controls.Add(this.label3);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxNom);
            this.groupBoxDatosContacto.Controls.Add(this.label2);
            this.groupBoxDatosContacto.Controls.Add(this.labelNombre);
            this.groupBoxDatosContacto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosContacto.Name = "groupBoxDatosContacto";
            this.groupBoxDatosContacto.Size = new System.Drawing.Size(261, 200);
            this.groupBoxDatosContacto.TabIndex = 3;
            this.groupBoxDatosContacto.TabStop = false;
            this.groupBoxDatosContacto.Text = "Datos de contacto";
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = global::Projecte_Chrysallis.Properties.Resources.icon_wrong;
            this.pictureBoxEmail.Location = new System.Drawing.Point(213, 98);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmail.TabIndex = 15;
            this.pictureBoxEmail.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBoxEmail, "Escriba un email válido");
            // 
            // pictureBoxEmail2
            // 
            this.pictureBoxEmail2.Image = global::Projecte_Chrysallis.Properties.Resources.icon_wrong;
            this.pictureBoxEmail2.Location = new System.Drawing.Point(213, 158);
            this.pictureBoxEmail2.Name = "pictureBoxEmail2";
            this.pictureBoxEmail2.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxEmail2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmail2.TabIndex = 14;
            this.pictureBoxEmail2.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBoxEmail2, "Ambos emails deben coincidir (y ambos deben de ser correctos)");
            // 
            // pictureBoxNombre
            // 
            this.pictureBoxNombre.Image = global::Projecte_Chrysallis.Properties.Resources.icon_wrong;
            this.pictureBoxNombre.Location = new System.Drawing.Point(213, 38);
            this.pictureBoxNombre.Name = "pictureBoxNombre";
            this.pictureBoxNombre.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNombre.TabIndex = 9;
            this.pictureBoxNombre.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBoxNombre, "Escriba un nombre válido");
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(21, 103);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(186, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(21, 163);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.ShortcutsEnabled = false;
            this.textBoxEmail2.Size = new System.Drawing.Size(186, 20);
            this.textBoxEmail2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verificar email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mensaje";
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Location = new System.Drawing.Point(21, 48);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(186, 20);
            this.textBoxAsunto.TabIndex = 4;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(21, 108);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMensaje.Size = new System.Drawing.Size(289, 75);
            this.textBoxMensaje.TabIndex = 5;
            // 
            // groupBoxMensaje
            // 
            this.groupBoxMensaje.Controls.Add(this.buttonCancelar);
            this.groupBoxMensaje.Controls.Add(this.pictureBoxAsunto);
            this.groupBoxMensaje.Controls.Add(this.pictureBoxMensaje);
            this.groupBoxMensaje.Controls.Add(this.textBoxAsunto);
            this.groupBoxMensaje.Controls.Add(this.label4);
            this.groupBoxMensaje.Controls.Add(this.buttonEnviar);
            this.groupBoxMensaje.Controls.Add(this.textBoxMensaje);
            this.groupBoxMensaje.Controls.Add(this.label1);
            this.groupBoxMensaje.Location = new System.Drawing.Point(12, 218);
            this.groupBoxMensaje.Name = "groupBoxMensaje";
            this.groupBoxMensaje.Size = new System.Drawing.Size(360, 231);
            this.groupBoxMensaje.TabIndex = 4;
            this.groupBoxMensaje.TabStop = false;
            this.groupBoxMensaje.Text = "Datos del mensaje";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(186, 202);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBoxAsunto
            // 
            this.pictureBoxAsunto.Image = global::Projecte_Chrysallis.Properties.Resources.icon_wrong;
            this.pictureBoxAsunto.Location = new System.Drawing.Point(213, 43);
            this.pictureBoxAsunto.Name = "pictureBoxAsunto";
            this.pictureBoxAsunto.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAsunto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAsunto.TabIndex = 13;
            this.pictureBoxAsunto.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBoxAsunto, "Escriba un asunto válido");
            // 
            // pictureBoxMensaje
            // 
            this.pictureBoxMensaje.Image = global::Projecte_Chrysallis.Properties.Resources.icon_wrong;
            this.pictureBoxMensaje.Location = new System.Drawing.Point(316, 108);
            this.pictureBoxMensaje.Name = "pictureBoxMensaje";
            this.pictureBoxMensaje.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMensaje.TabIndex = 12;
            this.pictureBoxMensaje.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBoxMensaje, "Escriba un mensaje válido");
            // 
            // FormContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.groupBoxMensaje);
            this.Controls.Add(this.groupBoxDatosContacto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "FormContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.FormContacto_Load);
            this.groupBoxDatosContacto.ResumeLayout(false);
            this.groupBoxDatosContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNombre)).EndInit();
            this.groupBoxMensaje.ResumeLayout(false);
            this.groupBoxMensaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.GroupBox groupBoxDatosContacto;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.TextBox textBoxAsunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMensaje;
        private System.Windows.Forms.PictureBox pictureBoxNombre;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxEmail2;
        private System.Windows.Forms.PictureBox pictureBoxAsunto;
        private System.Windows.Forms.PictureBox pictureBoxMensaje;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}