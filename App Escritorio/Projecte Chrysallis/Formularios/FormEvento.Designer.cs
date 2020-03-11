namespace Projecte_Chrysallis
{
    partial class FormEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento));
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.dateTimePickerEvento = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUbi = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePickerLimite = new System.Windows.Forms.DateTimePicker();
            this.labelFechaLimite = new System.Windows.Forms.Label();
            this.comboBoxComunidades = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCrearEvento = new System.Windows.Forms.Button();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNotificacion = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxAnadirNotificacion = new System.Windows.Forms.PictureBox();
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxAddDocumento = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminarDoc = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminarNotificacion = new System.Windows.Forms.PictureBox();
            this.labelValoracion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadirNotificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarNotificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.White;
            this.textBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTitulo.Location = new System.Drawing.Point(144, 24);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTitulo.Multiline = true;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(777, 35);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Text = "Evento...";
            this.textBoxTitulo.UseSystemPasswordChar = true;
            this.textBoxTitulo.Enter += new System.EventHandler(this.textBoxTitulo_Enter);
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalle.Location = new System.Drawing.Point(100, 302);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(320, 27);
            this.textBoxCalle.TabIndex = 3;
            // 
            // dateTimePickerEvento
            // 
            this.dateTimePickerEvento.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEvento.Location = new System.Drawing.Point(14, 131);
            this.dateTimePickerEvento.Name = "dateTimePickerEvento";
            this.dateTimePickerEvento.Size = new System.Drawing.Size(406, 23);
            this.dateTimePickerEvento.TabIndex = 5;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 102);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(286, 24);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha y hora del evento";
            // 
            // labelUbi
            // 
            this.labelUbi.AutoSize = true;
            this.labelUbi.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbi.Location = new System.Drawing.Point(12, 248);
            this.labelUbi.Name = "labelUbi";
            this.labelUbi.Size = new System.Drawing.Size(118, 24);
            this.labelUbi.TabIndex = 6;
            this.labelUbi.Text = "Ubicación";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(12, 637);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(118, 24);
            this.labelCom.TabIndex = 6;
            this.labelCom.Text = "Comunidad";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(12, 436);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(408, 180);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // dateTimePickerLimite
            // 
            this.dateTimePickerLimite.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLimite.Location = new System.Drawing.Point(12, 195);
            this.dateTimePickerLimite.Name = "dateTimePickerLimite";
            this.dateTimePickerLimite.Size = new System.Drawing.Size(408, 23);
            this.dateTimePickerLimite.TabIndex = 5;
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Font = new System.Drawing.Font("Consolas", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLimite.Location = new System.Drawing.Point(10, 166);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(406, 23);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha y hora límite para inscribirse";
            // 
            // comboBoxComunidades
            // 
            this.comboBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidades.DisplayMember = "nombre";
            this.comboBoxComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComunidades.FormattingEnabled = true;
            this.comboBoxComunidades.Location = new System.Drawing.Point(16, 665);
            this.comboBoxComunidades.Name = "comboBoxComunidades";
            this.comboBoxComunidades.Size = new System.Drawing.Size(408, 29);
            this.comboBoxComunidades.TabIndex = 8;
            this.comboBoxComunidades.ValueMember = "id";
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Projecte_Chrysallis.Comunidades);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.buttonCrearEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCrearEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearEvento.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearEvento.Image = global::Projecte_Chrysallis.Properties.Resources.calendar;
            this.buttonCrearEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCrearEvento.Location = new System.Drawing.Point(673, 720);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(248, 72);
            this.buttonCrearEvento.TabIndex = 10;
            this.buttonCrearEvento.Text = "CREAR EVENTO";
            this.buttonCrearEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrearEvento.UseVisualStyleBackColor = false;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click);
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.atras;
            this.pictureBoxAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAtras.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBoxAtras.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(72, 56);
            this.pictureBoxAtras.TabIndex = 18;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción";
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.ItemHeight = 18;
            this.listBoxDocumentos.Location = new System.Drawing.Point(484, 131);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(437, 184);
            this.listBoxDocumentos.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de documentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notificación";
            // 
            // dateTimePickerNotificacion
            // 
            this.dateTimePickerNotificacion.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNotificacion.Location = new System.Drawing.Point(484, 440);
            this.dateTimePickerNotificacion.Name = "dateTimePickerNotificacion";
            this.dateTimePickerNotificacion.Size = new System.Drawing.Size(363, 23);
            this.dateTimePickerNotificacion.TabIndex = 22;
            // 
            // pictureBoxAnadirNotificacion
            // 
            this.pictureBoxAnadirNotificacion.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxAnadirNotificacion.Location = new System.Drawing.Point(854, 440);
            this.pictureBoxAnadirNotificacion.Name = "pictureBoxAnadirNotificacion";
            this.pictureBoxAnadirNotificacion.Size = new System.Drawing.Size(67, 27);
            this.pictureBoxAnadirNotificacion.TabIndex = 20;
            this.pictureBoxAnadirNotificacion.TabStop = false;
            this.pictureBoxAnadirNotificacion.Click += new System.EventHandler(this.pictureBoxAnadirNotificacion_Click);
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 18;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(484, 516);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(437, 130);
            this.listBoxNotificaciones.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lista de notificaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Calle";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiudad.Location = new System.Drawing.Point(100, 348);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(320, 27);
            this.textBoxCiudad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad";
            // 
            // pictureBoxAddDocumento
            // 
            this.pictureBoxAddDocumento.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxAddDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAddDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddDocumento.Location = new System.Drawing.Point(484, 328);
            this.pictureBoxAddDocumento.Name = "pictureBoxAddDocumento";
            this.pictureBoxAddDocumento.Size = new System.Drawing.Size(54, 54);
            this.pictureBoxAddDocumento.TabIndex = 17;
            this.pictureBoxAddDocumento.TabStop = false;
            this.pictureBoxAddDocumento.Click += new System.EventHandler(this.pictureBoxAddDocumento_Click);
            // 
            // pictureBoxEliminarDoc
            // 
            this.pictureBoxEliminarDoc.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.delete;
            this.pictureBoxEliminarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEliminarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEliminarDoc.Location = new System.Drawing.Point(553, 328);
            this.pictureBoxEliminarDoc.Name = "pictureBoxEliminarDoc";
            this.pictureBoxEliminarDoc.Size = new System.Drawing.Size(55, 59);
            this.pictureBoxEliminarDoc.TabIndex = 25;
            this.pictureBoxEliminarDoc.TabStop = false;
            this.pictureBoxEliminarDoc.Click += new System.EventHandler(this.pictureBoxEliminarDoc_Click);
            // 
            // pictureBoxEliminarNotificacion
            // 
            this.pictureBoxEliminarNotificacion.BackColor = System.Drawing.Color.Red;
            this.pictureBoxEliminarNotificacion.Location = new System.Drawing.Point(484, 664);
            this.pictureBoxEliminarNotificacion.Name = "pictureBoxEliminarNotificacion";
            this.pictureBoxEliminarNotificacion.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxEliminarNotificacion.TabIndex = 26;
            this.pictureBoxEliminarNotificacion.TabStop = false;
            this.pictureBoxEliminarNotificacion.Click += new System.EventHandler(this.pictureBoxEliminarNotificacion_Click);
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracion.Location = new System.Drawing.Point(12, 744);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(214, 24);
            this.labelValoracion.TabIndex = 6;
            this.labelValoracion.Text = "Valoración media:";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(951, 804);
            this.Controls.Add(this.pictureBoxEliminarNotificacion);
            this.Controls.Add(this.pictureBoxEliminarDoc);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerNotificacion);
            this.Controls.Add(this.listBoxDocumentos);
            this.Controls.Add(this.pictureBoxAnadirNotificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrearEvento);
            this.Controls.Add(this.comboBoxComunidades);
            this.Controls.Add(this.pictureBoxAddDocumento);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelUbi);
            this.Controls.Add(this.labelFechaLimite);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerLimite);
            this.Controls.Add(this.dateTimePickerEvento);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.pictureBoxAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento";
            this.Text = "Crear Evento";
            this.Activated += new System.EventHandler(this.FormEvento_Activated);
            this.Load += new System.EventHandler(this.FormEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadirNotificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarNotificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUbi;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerLimite;
        private System.Windows.Forms.Label labelFechaLimite;
        private System.Windows.Forms.ComboBox comboBoxComunidades;
        private System.Windows.Forms.Button buttonCrearEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNotificacion;
        private System.Windows.Forms.PictureBox pictureBoxAnadirNotificacion;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxAddDocumento;
        private System.Windows.Forms.PictureBox pictureBoxEliminarDoc;
        private System.Windows.Forms.PictureBox pictureBoxEliminarNotificacion;
        private System.Windows.Forms.Label labelValoracion;
    }
}