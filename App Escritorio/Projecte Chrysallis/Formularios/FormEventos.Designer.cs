namespace Projecte_Chrysallis
{
    partial class FormEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnadir = new System.Windows.Forms.PictureBox();
            this.pictureBoxModificar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEventos.ColumnHeadersHeight = 75;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechalimiteDataGridViewTextBoxColumn,
            this.idComunidadDataGridViewTextBoxColumn,
            this.idAdminDataGridViewTextBoxColumn,
            this.asistirDataGridViewTextBoxColumn,
            this.documentosDataGridViewTextBoxColumn,
            this.notificacionesDataGridViewTextBoxColumn,
            this.comunidadesDataGridViewTextBoxColumn,
            this.administradoresDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.bindingSourceEventos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEventos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEventos.EnableHeadersVisualStyles = false;
            this.dataGridViewEventos.Location = new System.Drawing.Point(98, 169);
            this.dataGridViewEventos.MultiSelect = false;
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEventos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEventos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(1318, 485);
            this.dataGridViewEventos.TabIndex = 0;
            this.dataGridViewEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventos_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechalimiteDataGridViewTextBoxColumn
            // 
            this.fechalimiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechalimiteDataGridViewTextBoxColumn.DataPropertyName = "fecha_limite";
            this.fechalimiteDataGridViewTextBoxColumn.HeaderText = "Fecha Límite";
            this.fechalimiteDataGridViewTextBoxColumn.Name = "fechalimiteDataGridViewTextBoxColumn";
            this.fechalimiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idComunidadDataGridViewTextBoxColumn
            // 
            this.idComunidadDataGridViewTextBoxColumn.DataPropertyName = "idComunidad";
            this.idComunidadDataGridViewTextBoxColumn.HeaderText = "idComunidad";
            this.idComunidadDataGridViewTextBoxColumn.Name = "idComunidadDataGridViewTextBoxColumn";
            this.idComunidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComunidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAdminDataGridViewTextBoxColumn
            // 
            this.idAdminDataGridViewTextBoxColumn.DataPropertyName = "idAdmin";
            this.idAdminDataGridViewTextBoxColumn.HeaderText = "idAdmin";
            this.idAdminDataGridViewTextBoxColumn.Name = "idAdminDataGridViewTextBoxColumn";
            this.idAdminDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAdminDataGridViewTextBoxColumn.Visible = false;
            // 
            // asistirDataGridViewTextBoxColumn
            // 
            this.asistirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asistirDataGridViewTextBoxColumn.DataPropertyName = "Asistir";
            this.asistirDataGridViewTextBoxColumn.HeaderText = "Asistentes";
            this.asistirDataGridViewTextBoxColumn.Name = "asistirDataGridViewTextBoxColumn";
            this.asistirDataGridViewTextBoxColumn.ReadOnly = true;
            this.asistirDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // documentosDataGridViewTextBoxColumn
            // 
            this.documentosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentosDataGridViewTextBoxColumn.DataPropertyName = "Documentos";
            this.documentosDataGridViewTextBoxColumn.HeaderText = "Documentos";
            this.documentosDataGridViewTextBoxColumn.Name = "documentosDataGridViewTextBoxColumn";
            this.documentosDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // notificacionesDataGridViewTextBoxColumn
            // 
            this.notificacionesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notificacionesDataGridViewTextBoxColumn.DataPropertyName = "Notificaciones";
            this.notificacionesDataGridViewTextBoxColumn.HeaderText = "Notificaciones";
            this.notificacionesDataGridViewTextBoxColumn.Name = "notificacionesDataGridViewTextBoxColumn";
            this.notificacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notificacionesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // comunidadesDataGridViewTextBoxColumn
            // 
            this.comunidadesDataGridViewTextBoxColumn.DataPropertyName = "Comunidades";
            this.comunidadesDataGridViewTextBoxColumn.HeaderText = "Comunidades";
            this.comunidadesDataGridViewTextBoxColumn.Name = "comunidadesDataGridViewTextBoxColumn";
            this.comunidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunidadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // administradoresDataGridViewTextBoxColumn
            // 
            this.administradoresDataGridViewTextBoxColumn.DataPropertyName = "Administradores";
            this.administradoresDataGridViewTextBoxColumn.HeaderText = "Administradores";
            this.administradoresDataGridViewTextBoxColumn.Name = "administradoresDataGridViewTextBoxColumn";
            this.administradoresDataGridViewTextBoxColumn.ReadOnly = true;
            this.administradoresDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(Projecte_Chrysallis.Eventos);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "documentos";
            this.dataGridViewImageColumn1.HeaderText = "Documentos";
            this.dataGridViewImageColumn1.Image = global::Projecte_Chrysallis.Properties.Resources.add;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Añadir";
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
            this.pictureBoxAtras.TabIndex = 5;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBoxAnadir
            // 
            this.pictureBoxAnadir.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxAnadir.Location = new System.Drawing.Point(98, 90);
            this.pictureBoxAnadir.Name = "pictureBoxAnadir";
            this.pictureBoxAnadir.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAnadir.TabIndex = 6;
            this.pictureBoxAnadir.TabStop = false;
            this.pictureBoxAnadir.Click += new System.EventHandler(this.pictureBoxAnadir_Click);
            // 
            // pictureBoxModificar
            // 
            this.pictureBoxModificar.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxModificar.Location = new System.Drawing.Point(244, 90);
            this.pictureBoxModificar.Name = "pictureBoxModificar";
            this.pictureBoxModificar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxModificar.TabIndex = 6;
            this.pictureBoxModificar.TabStop = false;
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.BackColor = System.Drawing.Color.Red;
            this.pictureBoxEliminar.Location = new System.Drawing.Point(387, 90);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEliminar.TabIndex = 6;
            this.pictureBoxEliminar.TabStop = false;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1444, 702);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.pictureBoxModificar);
            this.Controls.Add(this.pictureBoxAnadir);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.dataGridViewEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEventos";
            this.Text = "Gestor de Eventos";
            this.Activated += new System.EventHandler(this.FormEventos_Activated);
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administradoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBoxAnadir;
        private System.Windows.Forms.PictureBox pictureBoxModificar;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
    }
}