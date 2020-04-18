namespace Projecte_Chrysallis.Formularios
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxSA = new System.Windows.Forms.GroupBox();
            this.checkBoxAdminSuper = new System.Windows.Forms.CheckBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxGenerar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonQuitarComunidades = new System.Windows.Forms.Button();
            this.buttonEnviarComunidades = new System.Windows.Forms.Button();
            this.listBoxComunidadesAdmin = new System.Windows.Forms.ListBox();
            this.comunidadesAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxComunidades = new System.Windows.Forms.ListBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBoxChrysallis = new System.Windows.Forms.PictureBox();
            this.groupBoxSA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunidadesAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChrysallis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(19, 142);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(241, 29);
            this.textBoxNombre.TabIndex = 1;
            // 
            // groupBoxSA
            // 
            this.groupBoxSA.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSA.Controls.Add(this.checkBoxAdminSuper);
            this.groupBoxSA.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSA.Location = new System.Drawing.Point(17, 395);
            this.groupBoxSA.Name = "groupBoxSA";
            this.groupBoxSA.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxSA.Size = new System.Drawing.Size(243, 64);
            this.groupBoxSA.TabIndex = 2;
            this.groupBoxSA.TabStop = false;
            this.groupBoxSA.Text = "Es administrador estatal?";
            // 
            // checkBoxAdminSuper
            // 
            this.checkBoxAdminSuper.AutoSize = true;
            this.checkBoxAdminSuper.Location = new System.Drawing.Point(15, 28);
            this.checkBoxAdminSuper.Name = "checkBoxAdminSuper";
            this.checkBoxAdminSuper.Size = new System.Drawing.Size(186, 25);
            this.checkBoxAdminSuper.TabIndex = 7;
            this.checkBoxAdminSuper.Text = "Administrador estatal";
            this.checkBoxAdminSuper.UseVisualStyleBackColor = true;
            this.checkBoxAdminSuper.CheckedChanged += new System.EventHandler(this.checkBoxAdminSuper_CheckedChanged);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.Location = new System.Drawing.Point(20, 212);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(241, 29);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(22, 285);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 29);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(22, 351);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(238, 29);
            this.textBoxContrasena.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // checkBoxGenerar
            // 
            this.checkBoxGenerar.AutoSize = true;
            this.checkBoxGenerar.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGenerar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGenerar.Location = new System.Drawing.Point(113, 332);
            this.checkBoxGenerar.Name = "checkBoxGenerar";
            this.checkBoxGenerar.Size = new System.Drawing.Size(148, 19);
            this.checkBoxGenerar.TabIndex = 5;
            this.checkBoxGenerar.Text = "Generar aleatoriamente";
            this.checkBoxGenerar.UseVisualStyleBackColor = false;
            this.checkBoxGenerar.CheckedChanged += new System.EventHandler(this.checkBoxGenerar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonQuitarComunidades);
            this.groupBox2.Controls.Add(this.buttonEnviarComunidades);
            this.groupBox2.Controls.Add(this.listBoxComunidadesAdmin);
            this.groupBox2.Controls.Add(this.listBoxComunidades);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(676, 345);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciona las comunidades que administra";
            // 
            // buttonQuitarComunidades
            // 
            this.buttonQuitarComunidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.buttonQuitarComunidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuitarComunidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuitarComunidades.Location = new System.Drawing.Point(289, 211);
            this.buttonQuitarComunidades.Name = "buttonQuitarComunidades";
            this.buttonQuitarComunidades.Size = new System.Drawing.Size(100, 46);
            this.buttonQuitarComunidades.TabIndex = 2;
            this.buttonQuitarComunidades.Text = "<-- Quitar";
            this.buttonQuitarComunidades.UseVisualStyleBackColor = false;
            this.buttonQuitarComunidades.Click += new System.EventHandler(this.buttonQuitarComunidades_Click);
            // 
            // buttonEnviarComunidades
            // 
            this.buttonEnviarComunidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.buttonEnviarComunidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnviarComunidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnviarComunidades.Location = new System.Drawing.Point(289, 147);
            this.buttonEnviarComunidades.Name = "buttonEnviarComunidades";
            this.buttonEnviarComunidades.Size = new System.Drawing.Size(100, 46);
            this.buttonEnviarComunidades.TabIndex = 1;
            this.buttonEnviarComunidades.Text = "Añadir -->";
            this.buttonEnviarComunidades.UseVisualStyleBackColor = false;
            this.buttonEnviarComunidades.Click += new System.EventHandler(this.buttonEnviarComunidades_Click);
            // 
            // listBoxComunidadesAdmin
            // 
            this.listBoxComunidadesAdmin.DataSource = this.comunidadesAdminBindingSource;
            this.listBoxComunidadesAdmin.DisplayMember = "nombre";
            this.listBoxComunidadesAdmin.FormattingEnabled = true;
            this.listBoxComunidadesAdmin.ItemHeight = 21;
            this.listBoxComunidadesAdmin.Location = new System.Drawing.Point(414, 70);
            this.listBoxComunidadesAdmin.Name = "listBoxComunidadesAdmin";
            this.listBoxComunidadesAdmin.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxComunidadesAdmin.Size = new System.Drawing.Size(251, 256);
            this.listBoxComunidadesAdmin.TabIndex = 0;
            this.listBoxComunidadesAdmin.ValueMember = "id";
            // 
            // comunidadesAdminBindingSource
            // 
            this.comunidadesAdminBindingSource.DataSource = typeof(Projecte_Chrysallis.Comunidades);
            // 
            // listBoxComunidades
            // 
            this.listBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.listBoxComunidades.DisplayMember = "nombre";
            this.listBoxComunidades.FormattingEnabled = true;
            this.listBoxComunidades.ItemHeight = 21;
            this.listBoxComunidades.Location = new System.Drawing.Point(12, 70);
            this.listBoxComunidades.Name = "listBoxComunidades";
            this.listBoxComunidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxComunidades.Size = new System.Drawing.Size(249, 256);
            this.listBoxComunidades.TabIndex = 0;
            this.listBoxComunidades.ValueMember = "id";
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Projecte_Chrysallis.Comunidades);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comunidades a cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comunidades de España";
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadir.Location = new System.Drawing.Point(833, 480);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(142, 54);
            this.buttonAnadir.TabIndex = 8;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAtras.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.atras;
            this.pictureBoxAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAtras.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(72, 56);
            this.pictureBoxAtras.TabIndex = 13;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBoxChrysallis
            // 
            this.pictureBoxChrysallis.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChrysallis.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.LogoChrysallis;
            this.pictureBoxChrysallis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxChrysallis.Location = new System.Drawing.Point(885, 12);
            this.pictureBoxChrysallis.Name = "pictureBoxChrysallis";
            this.pictureBoxChrysallis.Size = new System.Drawing.Size(79, 86);
            this.pictureBoxChrysallis.TabIndex = 14;
            this.pictureBoxChrysallis.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.FondoPantalla;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.pictureBoxChrysallis);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxGenerar);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxSA);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Administrador - MeetChrysallis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormNuevoAdmin_Load);
            this.groupBoxSA.ResumeLayout(false);
            this.groupBoxSA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunidadesAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChrysallis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxSA;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.ListBox listBoxComunidadesAdmin;
        private System.Windows.Forms.ListBox listBoxComunidades;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.Button buttonEnviarComunidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBoxChrysallis;
        private System.Windows.Forms.BindingSource comunidadesAdminBindingSource;
        private System.Windows.Forms.Button buttonQuitarComunidades;
        private System.Windows.Forms.CheckBox checkBoxAdminSuper;
    }
}