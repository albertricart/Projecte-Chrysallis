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
            this.groupBoxComunidades = new System.Windows.Forms.GroupBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxAnadir = new System.Windows.Forms.PictureBox();
            this.pictureBoxModificar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            this.groupBoxComunidades.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.AllowUserToAddRows = false;
            this.dataGridViewAdmins.AllowUserToDeleteRows = false;
            this.dataGridViewAdmins.AutoGenerateColumns = false;
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridViewAdmins.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAdmins.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewAdmins.MultiSelect = false;
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.ReadOnly = true;
            this.dataGridViewAdmins.RowHeadersVisible = false;
            this.dataGridViewAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmins.Size = new System.Drawing.Size(752, 338);
            this.dataGridViewAdmins.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
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
            this.superadminDataGridViewCheckBoxColumn.HeaderText = "Superadmin";
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
            this.listBoxComunidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxComunidades.FormattingEnabled = true;
            this.listBoxComunidades.ItemHeight = 21;
            this.listBoxComunidades.Location = new System.Drawing.Point(8, 30);
            this.listBoxComunidades.Name = "listBoxComunidades";
            this.listBoxComunidades.Size = new System.Drawing.Size(272, 300);
            this.listBoxComunidades.TabIndex = 3;
            // 
            // groupBoxComunidades
            // 
            this.groupBoxComunidades.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxComunidades.Controls.Add(this.listBoxComunidades);
            this.groupBoxComunidades.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxComunidades.Location = new System.Drawing.Point(782, 228);
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
            this.groupBox3.Location = new System.Drawing.Point(616, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 68);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por";
            // 
            // pictureBoxAnadir
            // 
            this.pictureBoxAnadir.Location = new System.Drawing.Point(12, 164);
            this.pictureBoxAnadir.Name = "pictureBoxAnadir";
            this.pictureBoxAnadir.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAnadir.TabIndex = 10;
            this.pictureBoxAnadir.TabStop = false;
            this.pictureBoxAnadir.Click += new System.EventHandler(this.pictureBoxAnadir_Click);
            // 
            // pictureBoxModificar
            // 
            this.pictureBoxModificar.Location = new System.Drawing.Point(146, 164);
            this.pictureBoxModificar.Name = "pictureBoxModificar";
            this.pictureBoxModificar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxModificar.TabIndex = 11;
            this.pictureBoxModificar.TabStop = false;
            this.pictureBoxModificar.Click += new System.EventHandler(this.pictureBoxModificar_Click);
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.Location = new System.Drawing.Point(287, 164);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEliminar.TabIndex = 12;
            this.pictureBoxEliminar.TabStop = false;
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
            this.pictureBox1.Location = new System.Drawing.Point(902, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.pictureBoxModificar);
            this.Controls.Add(this.pictureBoxAnadir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxComunidades);
            this.Controls.Add(this.dataGridViewAdmins);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1112, 627);
            this.MinimumSize = new System.Drawing.Size(1112, 627);
            this.Name = "FormAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Administradores - MeetChrysallis";
            this.Activated += new System.EventHandler(this.FormAdmins_Activated);
            this.Load += new System.EventHandler(this.FormAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            this.groupBoxComunidades.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxAnadir;
        private System.Windows.Forms.PictureBox pictureBoxModificar;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn superadminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
    }
}