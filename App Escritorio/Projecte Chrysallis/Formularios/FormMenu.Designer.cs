﻿namespace Projecte_Chrysallis
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxGestionarEventos = new System.Windows.Forms.PictureBox();
            this.pictureBoxGestionarSocios = new System.Windows.Forms.PictureBox();
            this.pictureBoxGestionarAdmins = new System.Windows.Forms.PictureBox();
            this.pictureBoxContacto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSalir.Location = new System.Drawing.Point(360, 8);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(67, 34);
            this.pictureBoxSalir.TabIndex = 0;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(291, 9);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(65, 33);
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxGestionarEventos
            // 
            this.pictureBoxGestionarEventos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGestionarEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGestionarEventos.Location = new System.Drawing.Point(47, 358);
            this.pictureBoxGestionarEventos.Name = "pictureBoxGestionarEventos";
            this.pictureBoxGestionarEventos.Size = new System.Drawing.Size(338, 51);
            this.pictureBoxGestionarEventos.TabIndex = 2;
            this.pictureBoxGestionarEventos.TabStop = false;
            this.pictureBoxGestionarEventos.Click += new System.EventHandler(this.pictureBoxGestionarEventos_Click);
            // 
            // pictureBoxGestionarSocios
            // 
            this.pictureBoxGestionarSocios.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGestionarSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGestionarSocios.Location = new System.Drawing.Point(47, 430);
            this.pictureBoxGestionarSocios.Name = "pictureBoxGestionarSocios";
            this.pictureBoxGestionarSocios.Size = new System.Drawing.Size(338, 51);
            this.pictureBoxGestionarSocios.TabIndex = 3;
            this.pictureBoxGestionarSocios.TabStop = false;
            this.pictureBoxGestionarSocios.Click += new System.EventHandler(this.pictureBoxGestionarSocios_Click);
            // 
            // pictureBoxGestionarAdmins
            // 
            this.pictureBoxGestionarAdmins.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGestionarAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGestionarAdmins.Location = new System.Drawing.Point(47, 501);
            this.pictureBoxGestionarAdmins.Name = "pictureBoxGestionarAdmins";
            this.pictureBoxGestionarAdmins.Size = new System.Drawing.Size(338, 51);
            this.pictureBoxGestionarAdmins.TabIndex = 4;
            this.pictureBoxGestionarAdmins.TabStop = false;
            // 
            // pictureBoxContacto
            // 
            this.pictureBoxContacto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxContacto.Location = new System.Drawing.Point(47, 573);
            this.pictureBoxContacto.Name = "pictureBoxContacto";
            this.pictureBoxContacto.Size = new System.Drawing.Size(338, 51);
            this.pictureBoxContacto.TabIndex = 5;
            this.pictureBoxContacto.TabStop = false;
            this.pictureBoxContacto.Click += new System.EventHandler(this.pictureBoxContacto_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(432, 660);
            this.Controls.Add(this.pictureBoxContacto);
            this.Controls.Add(this.pictureBoxGestionarAdmins);
            this.Controls.Add(this.pictureBoxGestionarSocios);
            this.Controls.Add(this.pictureBoxGestionarEventos);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxSalir);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestionarAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxGestionarEventos;
        private System.Windows.Forms.PictureBox pictureBoxGestionarSocios;
        private System.Windows.Forms.PictureBox pictureBoxGestionarAdmins;
        private System.Windows.Forms.PictureBox pictureBoxContacto;
    }
}

