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
            this.textBoxUbi = new System.Windows.Forms.TextBox();
            this.dateTimePickerEvento = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUbi = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePickerLimite = new System.Windows.Forms.DateTimePicker();
            this.labelFechaLimite = new System.Windows.Forms.Label();
            this.comboBoxComunidades = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAccionEvento = new System.Windows.Forms.Button();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.bindingSourceDocumentos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNotificacion = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxAnadirNotificacion = new System.Windows.Forms.PictureBox();
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxAddDocumento = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminarDoc = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminarNotificacion = new System.Windows.Forms.PictureBox();
            this.labelValoracion = new System.Windows.Forms.Label();
            this.pictureBoxVerDoc = new System.Windows.Forms.PictureBox();
            this.notificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadirNotificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarNotificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.White;
            this.textBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTitulo.Location = new System.Drawing.Point(144, 24);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTitulo.Multiline = true;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(777, 44);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Text = "Evento...";
            this.textBoxTitulo.UseSystemPasswordChar = true;
            this.textBoxTitulo.Enter += new System.EventHandler(this.textBoxTitulo_Enter);
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // textBoxUbi
            // 
            this.textBoxUbi.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUbi.Location = new System.Drawing.Point(17, 281);
            this.textBoxUbi.Multiline = true;
            this.textBoxUbi.Name = "textBoxUbi";
            this.textBoxUbi.Size = new System.Drawing.Size(403, 67);
            this.textBoxUbi.TabIndex = 3;
            // 
            // dateTimePickerEvento
            // 
            this.dateTimePickerEvento.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerEvento.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEvento.Location = new System.Drawing.Point(14, 131);
            this.dateTimePickerEvento.Name = "dateTimePickerEvento";
            this.dateTimePickerEvento.Size = new System.Drawing.Size(406, 27);
            this.dateTimePickerEvento.TabIndex = 5;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.labelFecha.Location = new System.Drawing.Point(9, 98);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(241, 30);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha y hora del evento";
            // 
            // labelUbi
            // 
            this.labelUbi.AutoSize = true;
            this.labelUbi.BackColor = System.Drawing.Color.Transparent;
            this.labelUbi.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.labelUbi.Location = new System.Drawing.Point(12, 248);
            this.labelUbi.Name = "labelUbi";
            this.labelUbi.Size = new System.Drawing.Size(107, 30);
            this.labelUbi.TabIndex = 6;
            this.labelUbi.Text = "Ubicación";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.BackColor = System.Drawing.Color.Transparent;
            this.labelCom.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.labelCom.Location = new System.Drawing.Point(10, 632);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(124, 30);
            this.labelCom.TabIndex = 6;
            this.labelCom.Text = "Comunidad";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(12, 403);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(408, 213);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // dateTimePickerLimite
            // 
            this.dateTimePickerLimite.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerLimite.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLimite.Location = new System.Drawing.Point(12, 195);
            this.dateTimePickerLimite.Name = "dateTimePickerLimite";
            this.dateTimePickerLimite.Size = new System.Drawing.Size(408, 27);
            this.dateTimePickerLimite.TabIndex = 5;
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaLimite.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.labelFechaLimite.Location = new System.Drawing.Point(7, 164);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(325, 28);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha y hora límite para inscribirse";
            // 
            // comboBoxComunidades
            // 
            this.comboBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidades.DisplayMember = "nombre";
            this.comboBoxComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidades.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComunidades.FormattingEnabled = true;
            this.comboBoxComunidades.Location = new System.Drawing.Point(16, 665);
            this.comboBoxComunidades.Name = "comboBoxComunidades";
            this.comboBoxComunidades.Size = new System.Drawing.Size(408, 31);
            this.comboBoxComunidades.TabIndex = 8;
            this.comboBoxComunidades.ValueMember = "id";
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Projecte_Chrysallis.Comunidades);
            // 
            // buttonAccionEvento
            // 
            this.buttonAccionEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.buttonAccionEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccionEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccionEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccionEvento.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccionEvento.Image = global::Projecte_Chrysallis.Properties.Resources.calendar;
            this.buttonAccionEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAccionEvento.Location = new System.Drawing.Point(673, 720);
            this.buttonAccionEvento.Name = "buttonAccionEvento";
            this.buttonAccionEvento.Size = new System.Drawing.Size(248, 72);
            this.buttonAccionEvento.TabIndex = 10;
            this.buttonAccionEvento.Text = "CREAR EVENTO";
            this.buttonAccionEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccionEvento.UseVisualStyleBackColor = false;
            this.buttonAccionEvento.Click += new System.EventHandler(this.buttonAccionEvento_Click);
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackColor = System.Drawing.Color.Transparent;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción";
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.DataSource = this.bindingSourceDocumentos;
            this.listBoxDocumentos.DisplayMember = "url";
            this.listBoxDocumentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.HorizontalScrollbar = true;
            this.listBoxDocumentos.ItemHeight = 18;
            this.listBoxDocumentos.Location = new System.Drawing.Point(484, 131);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(437, 184);
            this.listBoxDocumentos.TabIndex = 21;
            this.listBoxDocumentos.ValueMember = "id";
            // 
            // bindingSourceDocumentos
            // 
            this.bindingSourceDocumentos.DataSource = typeof(Projecte_Chrysallis.Documentos);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(480, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de documentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(480, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notificación";
            // 
            // dateTimePickerNotificacion
            // 
            this.dateTimePickerNotificacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNotificacion.Location = new System.Drawing.Point(484, 440);
            this.dateTimePickerNotificacion.Name = "dateTimePickerNotificacion";
            this.dateTimePickerNotificacion.Size = new System.Drawing.Size(348, 23);
            this.dateTimePickerNotificacion.TabIndex = 22;
            // 
            // pictureBoxAnadirNotificacion
            // 
            this.pictureBoxAnadirNotificacion.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxAnadirNotificacion.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.botonAnadir;
            this.pictureBoxAnadirNotificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAnadirNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAnadirNotificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAnadirNotificacion.Location = new System.Drawing.Point(837, 434);
            this.pictureBoxAnadirNotificacion.Name = "pictureBoxAnadirNotificacion";
            this.pictureBoxAnadirNotificacion.Size = new System.Drawing.Size(83, 37);
            this.pictureBoxAnadirNotificacion.TabIndex = 20;
            this.pictureBoxAnadirNotificacion.TabStop = false;
            this.pictureBoxAnadirNotificacion.Click += new System.EventHandler(this.pictureBoxAnadirNotificacion_Click);
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.DataSource = this.notificacionesBindingSource;
            this.listBoxNotificaciones.DisplayMember = "fechaHora";
            this.listBoxNotificaciones.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 20;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(484, 516);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(437, 124);
            this.listBoxNotificaciones.TabIndex = 24;
            this.listBoxNotificaciones.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(480, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lista de notificaciones";
            // 
            // pictureBoxAddDocumento
            // 
            this.pictureBoxAddDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddDocumento.BackColor = System.Drawing.Color.Transparent;
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
            this.pictureBoxEliminarDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEliminarDoc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEliminarDoc.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.delete;
            this.pictureBoxEliminarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.pictureBoxEliminarNotificacion.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.botonEliminar;
            this.pictureBoxEliminarNotificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEliminarNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEliminarNotificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEliminarNotificacion.Location = new System.Drawing.Point(484, 652);
            this.pictureBoxEliminarNotificacion.Name = "pictureBoxEliminarNotificacion";
            this.pictureBoxEliminarNotificacion.Size = new System.Drawing.Size(100, 42);
            this.pictureBoxEliminarNotificacion.TabIndex = 26;
            this.pictureBoxEliminarNotificacion.TabStop = false;
            this.pictureBoxEliminarNotificacion.Click += new System.EventHandler(this.pictureBoxEliminarNotificacion_Click);
            // 
            // labelValoracion
            // 
            this.labelValoracion.AutoSize = true;
            this.labelValoracion.BackColor = System.Drawing.Color.Transparent;
            this.labelValoracion.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.labelValoracion.Location = new System.Drawing.Point(12, 744);
            this.labelValoracion.Name = "labelValoracion";
            this.labelValoracion.Size = new System.Drawing.Size(216, 32);
            this.labelValoracion.TabIndex = 6;
            this.labelValoracion.Text = "Valoración media: ";
            this.labelValoracion.Visible = false;
            // 
            // pictureBoxVerDoc
            // 
            this.pictureBoxVerDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxVerDoc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVerDoc.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.ojo;
            this.pictureBoxVerDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVerDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVerDoc.Location = new System.Drawing.Point(624, 328);
            this.pictureBoxVerDoc.Name = "pictureBoxVerDoc";
            this.pictureBoxVerDoc.Size = new System.Drawing.Size(59, 59);
            this.pictureBoxVerDoc.TabIndex = 27;
            this.pictureBoxVerDoc.TabStop = false;
            this.pictureBoxVerDoc.Click += new System.EventHandler(this.pictureBoxVerDoc_Click);
            // 
            // notificacionesBindingSource
            // 
            this.notificacionesBindingSource.DataSource = typeof(Projecte_Chrysallis.Notificaciones);
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 804);
            this.Controls.Add(this.pictureBoxVerDoc);
            this.Controls.Add(this.pictureBoxEliminarNotificacion);
            this.Controls.Add(this.pictureBoxEliminarDoc);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerNotificacion);
            this.Controls.Add(this.listBoxDocumentos);
            this.Controls.Add(this.pictureBoxAnadirNotificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccionEvento);
            this.Controls.Add(this.comboBoxComunidades);
            this.Controls.Add(this.pictureBoxAddDocumento);
            this.Controls.Add(this.labelValoracion);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUbi);
            this.Controls.Add(this.labelFechaLimite);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerLimite);
            this.Controls.Add(this.dateTimePickerEvento);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxUbi);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.pictureBoxAtras);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Evento";
            this.Activated += new System.EventHandler(this.FormEvento_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEvento_FormClosing);
            this.Load += new System.EventHandler(this.FormEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadirNotificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarNotificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxUbi;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUbi;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerLimite;
        private System.Windows.Forms.Label labelFechaLimite;
        private System.Windows.Forms.ComboBox comboBoxComunidades;
        private System.Windows.Forms.Button buttonAccionEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNotificacion;
        private System.Windows.Forms.PictureBox pictureBoxAnadirNotificacion;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxAddDocumento;
        private System.Windows.Forms.PictureBox pictureBoxEliminarDoc;
        private System.Windows.Forms.PictureBox pictureBoxEliminarNotificacion;
        private System.Windows.Forms.Label labelValoracion;
        private System.Windows.Forms.PictureBox pictureBoxVerDoc;
        private System.Windows.Forms.BindingSource bindingSourceDocumentos;
        private System.Windows.Forms.BindingSource notificacionesBindingSource;
    }
}