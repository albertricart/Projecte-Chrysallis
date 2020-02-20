﻿namespace Projecte_Chrysallis.Formularios
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
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.dataGridViewAdmins = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.listBoxComunidades = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxFiltrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(6, 19);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(100, 28);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmins.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.Size = new System.Drawing.Size(437, 338);
            this.dataGridViewAdmins.TabIndex = 1;
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
            this.comboBoxFiltro.Location = new System.Drawing.Point(169, 26);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(163, 21);
            this.comboBoxFiltro.TabIndex = 2;
            // 
            // listBoxComunidades
            // 
            this.listBoxComunidades.FormattingEnabled = true;
            this.listBoxComunidades.Location = new System.Drawing.Point(6, 23);
            this.listBoxComunidades.Name = "listBoxComunidades";
            this.listBoxComunidades.Size = new System.Drawing.Size(209, 303);
            this.listBoxComunidades.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxComunidades);
            this.groupBox1.Location = new System.Drawing.Point(455, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 338);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunidades que administra";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(5, 27);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(158, 20);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNuevo);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Herramientas de gestión";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxFiltrar);
            this.groupBox3.Controls.Add(this.textBoxFiltro);
            this.groupBox3.Controls.Add(this.comboBoxFiltro);
            this.groupBox3.Location = new System.Drawing.Point(338, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por";
            // 
            // checkBoxFiltrar
            // 
            this.checkBoxFiltrar.AutoSize = true;
            this.checkBoxFiltrar.Location = new System.Drawing.Point(58, 0);
            this.checkBoxFiltrar.Name = "checkBoxFiltrar";
            this.checkBoxFiltrar.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFiltrar.TabIndex = 10;
            this.checkBoxFiltrar.UseVisualStyleBackColor = true;
            this.checkBoxFiltrar.CheckedChanged += new System.EventHandler(this.checkBoxFiltrar_CheckedChanged);
            // 
            // FormAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAdmins);
            this.Name = "FormAdmins";
            this.Text = "Gestión de Administradores - MeetChrysallis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.DataGridView dataGridViewAdmins;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.ListBox listBoxComunidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxFiltrar;
    }
}