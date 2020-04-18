namespace Projecte_Chrysallis.Formularios
{
    partial class FormAdmins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmins));
            this.dataGridViewAdmins = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superadminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eventosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.listBoxComunidades = new System.Windows.Forms.ListBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxComunidades = new System.Windows.Forms.GroupBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            this.groupBoxComunidades.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.AllowUserToAddRows = false;
            this.dataGridViewAdmins.AllowUserToDeleteRows = false;
            this.dataGridViewAdmins.AutoGenerateColumns = false;
            this.dataGridViewAdmins.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAdmins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAdmins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmins.ColumnHeadersHeight = 75;
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.superadminDataGridViewCheckBoxColumn,
            this.eventosDataGridViewTextBoxColumn,
            this.comunidadesDataGridViewTextBoxColumn});
            this.dataGridViewAdmins.DataSource = this.administradoresBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdmins.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAdmins.EnableHeadersVisualStyles = false;
            this.dataGridViewAdmins.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAdmins.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewAdmins.MultiSelect = false;
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.ReadOnly = true;
            this.dataGridViewAdmins.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAdmins.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAdmins.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAdmins.RowTemplate.Height = 35;
            this.dataGridViewAdmins.RowTemplate.ReadOnly = true;
            this.dataGridViewAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmins.Size = new System.Drawing.Size(861, 338);
            this.dataGridViewAdmins.TabIndex = 1;
            this.dataGridViewAdmins.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmins_CellDoubleClick);
            this.dataGridViewAdmins.SelectionChanged += new System.EventHandler(this.dataGridViewAdmins_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.apellidosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Visible = false;
            // 
            // superadminDataGridViewCheckBoxColumn
            // 
            this.superadminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.superadminDataGridViewCheckBoxColumn.DataPropertyName = "superadmin";
            this.superadminDataGridViewCheckBoxColumn.HeaderText = "Administrador estatal";
            this.superadminDataGridViewCheckBoxColumn.Name = "superadminDataGridViewCheckBoxColumn";
            this.superadminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // eventosDataGridViewTextBoxColumn
            // 
            this.eventosDataGridViewTextBoxColumn.DataPropertyName = "Eventos";
            this.eventosDataGridViewTextBoxColumn.HeaderText = "Eventos";
            this.eventosDataGridViewTextBoxColumn.Name = "eventosDataGridViewTextBoxColumn";
            this.eventosDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventosDataGridViewTextBoxColumn.Visible = false;
            // 
            // comunidadesDataGridViewTextBoxColumn
            // 
            this.comunidadesDataGridViewTextBoxColumn.DataPropertyName = "Comunidades";
            this.comunidadesDataGridViewTextBoxColumn.HeaderText = "Comunidades";
            this.comunidadesDataGridViewTextBoxColumn.Name = "comunidadesDataGridViewTextBoxColumn";
            this.comunidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunidadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataSource = typeof(Projecte_Chrysallis.Administradores);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Apellidos",
            "Email",
            "Comunidad Autónoma"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(234, 25);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(212, 29);
            this.comboBoxFiltro.TabIndex = 2;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // listBoxComunidades
            // 
            this.listBoxComunidades.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxComunidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.listBoxComunidades.DisplayMember = "nombre";
            this.listBoxComunidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxComunidades.FormattingEnabled = true;
            this.listBoxComunidades.ItemHeight = 21;
            this.listBoxComunidades.Location = new System.Drawing.Point(8, 30);
            this.listBoxComunidades.Name = "listBoxComunidades";
            this.listBoxComunidades.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxComunidades.Size = new System.Drawing.Size(272, 300);
            this.listBoxComunidades.TabIndex = 3;
            this.listBoxComunidades.ValueMember = "id";
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Projecte_Chrysallis.Comunidades);
            // 
            // groupBoxComunidades
            // 
            this.groupBoxComunidades.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxComunidades.Controls.Add(this.listBoxComunidades);
            this.groupBoxComunidades.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxComunidades.Location = new System.Drawing.Point(896, 238);
            this.groupBoxComunidades.Name = "groupBoxComunidades";
            this.groupBoxComunidades.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxComunidades.Size = new System.Drawing.Size(288, 338);
            this.groupBoxComunidades.TabIndex = 5;
            this.groupBoxComunidades.TabStop = false;
            this.groupBoxComunidades.Text = "Comunidades que administra";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(6, 26);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(222, 29);
            this.textBoxFiltro.TabIndex = 6;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBoxFiltro);
            this.groupBox3.Controls.Add(this.comboBoxFiltro);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(730, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por";
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAtras.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.atras;
            this.pictureBoxAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAtras.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(72, 56);
            this.pictureBoxAtras.TabIndex = 13;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.LogoChrysallis;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1016, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.botonEliminar;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(322, 164);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 50);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Image = global::Projecte_Chrysallis.Properties.Resources.botonModificar;
            this.buttonModificar.Location = new System.Drawing.Point(166, 164);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(119, 50);
            this.buttonModificar.TabIndex = 16;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnadir.Image = global::Projecte_Chrysallis.Properties.Resources.botonAnadir;
            this.buttonAnadir.Location = new System.Drawing.Point(12, 164);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(120, 50);
            this.buttonAnadir.TabIndex = 15;
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // FormAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 588);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxComunidades);
            this.Controls.Add(this.dataGridViewAdmins);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1212, 627);
            this.MinimumSize = new System.Drawing.Size(1212, 627);
            this.Name = "FormAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Administradores - MeetChrysallis";
            this.Activated += new System.EventHandler(this.FormAdmins_Activated);
            this.Load += new System.EventHandler(this.FormAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            this.groupBoxComunidades.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAdmins;
        private System.Windows.Forms.ListBox listBoxComunidades;
        private System.Windows.Forms.GroupBox groupBoxComunidades;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn superadminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadesDataGridViewTextBoxColumn;
    }
}