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
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.dateTimePickerEvento = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelUbi = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePickerLimite = new System.Windows.Forms.DateTimePicker();
            this.labelFechaLimite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDocumento1 = new System.Windows.Forms.TextBox();
            this.textBoxDocumento2 = new System.Windows.Forms.TextBox();
            this.textBoxDocumento3 = new System.Windows.Forms.TextBox();
            this.textBoxDocumento4 = new System.Windows.Forms.TextBox();
            this.textBoxDocumento5 = new System.Windows.Forms.TextBox();
            this.textBoxDocumento6 = new System.Windows.Forms.TextBox();
            this.comboBoxComunidades = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCrearEvento = new System.Windows.Forms.Button();
            this.pictureBoxDocumento6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDocumento5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDocumento4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDocumento3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDocumento2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDocumento1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
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
            this.textBoxTitulo.Size = new System.Drawing.Size(631, 35);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Text = "Evento...";
            this.textBoxTitulo.UseSystemPasswordChar = true;
            this.textBoxTitulo.Enter += new System.EventHandler(this.textBoxTitulo_Enter);
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUbicacion.Location = new System.Drawing.Point(12, 275);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(408, 27);
            this.textBoxUbicacion.TabIndex = 3;
            // 
            // dateTimePickerEvento
            // 
            this.dateTimePickerEvento.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerEvento.Location = new System.Drawing.Point(14, 131);
            this.dateTimePickerEvento.Name = "dateTimePickerEvento";
            this.dateTimePickerEvento.Size = new System.Drawing.Size(406, 23);
            this.dateTimePickerEvento.TabIndex = 5;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(12, 102);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(202, 24);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha del evento";
            // 
            // labelUbi
            // 
            this.labelUbi.AutoSize = true;
            this.labelUbi.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbi.Location = new System.Drawing.Point(12, 248);
            this.labelUbi.Name = "labelUbi";
            this.labelUbi.Size = new System.Drawing.Size(118, 24);
            this.labelUbi.TabIndex = 6;
            this.labelUbi.Text = "Ubicación";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(8, 506);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(118, 24);
            this.labelCom.TabIndex = 6;
            this.labelCom.Text = "Comunidad";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(12, 345);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(408, 134);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // dateTimePickerLimite
            // 
            this.dateTimePickerLimite.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePickerLimite.Location = new System.Drawing.Point(12, 195);
            this.dateTimePickerLimite.Name = "dateTimePickerLimite";
            this.dateTimePickerLimite.Size = new System.Drawing.Size(408, 23);
            this.dateTimePickerLimite.TabIndex = 5;
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLimite.Location = new System.Drawing.Point(10, 166);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(334, 24);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha límite de inscripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Documentos";
            // 
            // textBoxDocumento1
            // 
            this.textBoxDocumento1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento1.Location = new System.Drawing.Point(547, 150);
            this.textBoxDocumento1.Name = "textBoxDocumento1";
            this.textBoxDocumento1.ReadOnly = true;
            this.textBoxDocumento1.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento1.TabIndex = 3;
            this.textBoxDocumento1.Text = "(Ruta...)";
            // 
            // textBoxDocumento2
            // 
            this.textBoxDocumento2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento2.Location = new System.Drawing.Point(547, 225);
            this.textBoxDocumento2.Name = "textBoxDocumento2";
            this.textBoxDocumento2.ReadOnly = true;
            this.textBoxDocumento2.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento2.TabIndex = 3;
            // 
            // textBoxDocumento3
            // 
            this.textBoxDocumento3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento3.Location = new System.Drawing.Point(547, 301);
            this.textBoxDocumento3.Name = "textBoxDocumento3";
            this.textBoxDocumento3.ReadOnly = true;
            this.textBoxDocumento3.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento3.TabIndex = 3;
            // 
            // textBoxDocumento4
            // 
            this.textBoxDocumento4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento4.Location = new System.Drawing.Point(547, 376);
            this.textBoxDocumento4.Name = "textBoxDocumento4";
            this.textBoxDocumento4.ReadOnly = true;
            this.textBoxDocumento4.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento4.TabIndex = 3;
            // 
            // textBoxDocumento5
            // 
            this.textBoxDocumento5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento5.Location = new System.Drawing.Point(547, 452);
            this.textBoxDocumento5.Name = "textBoxDocumento5";
            this.textBoxDocumento5.ReadOnly = true;
            this.textBoxDocumento5.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento5.TabIndex = 3;
            // 
            // textBoxDocumento6
            // 
            this.textBoxDocumento6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocumento6.Location = new System.Drawing.Point(547, 534);
            this.textBoxDocumento6.Name = "textBoxDocumento6";
            this.textBoxDocumento6.ReadOnly = true;
            this.textBoxDocumento6.Size = new System.Drawing.Size(228, 27);
            this.textBoxDocumento6.TabIndex = 3;
            // 
            // comboBoxComunidades
            // 
            this.comboBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidades.DisplayMember = "nombre";
            this.comboBoxComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComunidades.FormattingEnabled = true;
            this.comboBoxComunidades.Location = new System.Drawing.Point(12, 534);
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
            this.buttonCrearEvento.Location = new System.Drawing.Point(547, 611);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(248, 72);
            this.buttonCrearEvento.TabIndex = 10;
            this.buttonCrearEvento.Text = "CREAR EVENTO";
            this.buttonCrearEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrearEvento.UseVisualStyleBackColor = false;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click);
            // 
            // pictureBoxDocumento6
            // 
            this.pictureBoxDocumento6.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento6.Location = new System.Drawing.Point(484, 522);
            this.pictureBoxDocumento6.Name = "pictureBoxDocumento6";
            this.pictureBoxDocumento6.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento6.TabIndex = 12;
            this.pictureBoxDocumento6.TabStop = false;
            // 
            // pictureBoxDocumento5
            // 
            this.pictureBoxDocumento5.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento5.Location = new System.Drawing.Point(484, 441);
            this.pictureBoxDocumento5.Name = "pictureBoxDocumento5";
            this.pictureBoxDocumento5.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento5.TabIndex = 13;
            this.pictureBoxDocumento5.TabStop = false;
            // 
            // pictureBoxDocumento4
            // 
            this.pictureBoxDocumento4.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento4.Location = new System.Drawing.Point(484, 364);
            this.pictureBoxDocumento4.Name = "pictureBoxDocumento4";
            this.pictureBoxDocumento4.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento4.TabIndex = 14;
            this.pictureBoxDocumento4.TabStop = false;
            // 
            // pictureBoxDocumento3
            // 
            this.pictureBoxDocumento3.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento3.Location = new System.Drawing.Point(484, 288);
            this.pictureBoxDocumento3.Name = "pictureBoxDocumento3";
            this.pictureBoxDocumento3.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento3.TabIndex = 15;
            this.pictureBoxDocumento3.TabStop = false;
            // 
            // pictureBoxDocumento2
            // 
            this.pictureBoxDocumento2.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento2.Location = new System.Drawing.Point(484, 213);
            this.pictureBoxDocumento2.Name = "pictureBoxDocumento2";
            this.pictureBoxDocumento2.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento2.TabIndex = 16;
            this.pictureBoxDocumento2.TabStop = false;
            // 
            // pictureBoxDocumento1
            // 
            this.pictureBoxDocumento1.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.add;
            this.pictureBoxDocumento1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDocumento1.Location = new System.Drawing.Point(484, 140);
            this.pictureBoxDocumento1.Name = "pictureBoxDocumento1";
            this.pictureBoxDocumento1.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxDocumento1.TabIndex = 17;
            this.pictureBoxDocumento1.TabStop = false;
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.atras;
            this.pictureBoxAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAtras.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrearEvento);
            this.Controls.Add(this.comboBoxComunidades);
            this.Controls.Add(this.pictureBoxDocumento6);
            this.Controls.Add(this.pictureBoxDocumento5);
            this.Controls.Add(this.pictureBoxDocumento4);
            this.Controls.Add(this.pictureBoxDocumento3);
            this.Controls.Add(this.pictureBoxDocumento2);
            this.Controls.Add(this.pictureBoxDocumento1);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUbi);
            this.Controls.Add(this.labelFechaLimite);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerLimite);
            this.Controls.Add(this.dateTimePickerEvento);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxDocumento6);
            this.Controls.Add(this.textBoxDocumento5);
            this.Controls.Add(this.textBoxDocumento4);
            this.Controls.Add(this.textBoxDocumento3);
            this.Controls.Add(this.textBoxDocumento2);
            this.Controls.Add(this.textBoxDocumento1);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.pictureBoxAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvento";
            this.Text = "Crear Evento";
            this.Load += new System.EventHandler(this.FormCrearEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocumento1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelUbi;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerLimite;
        private System.Windows.Forms.Label labelFechaLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxDocumento1;
        private System.Windows.Forms.PictureBox pictureBoxDocumento2;
        private System.Windows.Forms.PictureBox pictureBoxDocumento3;
        private System.Windows.Forms.PictureBox pictureBoxDocumento4;
        private System.Windows.Forms.PictureBox pictureBoxDocumento5;
        private System.Windows.Forms.PictureBox pictureBoxDocumento6;
        private System.Windows.Forms.TextBox textBoxDocumento1;
        private System.Windows.Forms.TextBox textBoxDocumento2;
        private System.Windows.Forms.TextBox textBoxDocumento3;
        private System.Windows.Forms.TextBox textBoxDocumento4;
        private System.Windows.Forms.TextBox textBoxDocumento5;
        private System.Windows.Forms.TextBox textBoxDocumento6;
        private System.Windows.Forms.ComboBox comboBoxComunidades;
        private System.Windows.Forms.Button buttonCrearEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
    }
}