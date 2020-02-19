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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
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
            this.dataGridViewEventos.Location = new System.Drawing.Point(100, 108);
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
            this.dataGridViewEventos.Size = new System.Drawing.Size(1122, 485);
            this.dataGridViewEventos.TabIndex = 0;
            this.dataGridViewEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventos_CellContentClick);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 12);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(64, 25);
            this.buttonAtras.TabIndex = 1;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(100, 46);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(130, 42);
            this.buttonAnadir.TabIndex = 2;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(272, 46);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(130, 42);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(451, 46);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 42);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button4_Click);
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
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(Projecte_Chrysallis.Eventos);
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
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1244, 623);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.dataGridViewEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEventos";
            this.Text = "Gestor de Eventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
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
    }
}