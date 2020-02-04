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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento));
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBoxNuevoEvento = new System.Windows.Forms.PictureBox();
            this.pictureBoxModifEvento = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsultaEvento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevoEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultaEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAtras.Location = new System.Drawing.Point(9, 5);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(51, 51);
            this.pictureBoxAtras.TabIndex = 0;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBoxNuevoEvento
            // 
            this.pictureBoxNuevoEvento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNuevoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNuevoEvento.Location = new System.Drawing.Point(44, 168);
            this.pictureBoxNuevoEvento.Name = "pictureBoxNuevoEvento";
            this.pictureBoxNuevoEvento.Size = new System.Drawing.Size(348, 51);
            this.pictureBoxNuevoEvento.TabIndex = 1;
            this.pictureBoxNuevoEvento.TabStop = false;
            this.pictureBoxNuevoEvento.Click += new System.EventHandler(this.pictureBoxNuevoEvento_Click);
            // 
            // pictureBoxModifEvento
            // 
            this.pictureBoxModifEvento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxModifEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxModifEvento.Location = new System.Drawing.Point(44, 242);
            this.pictureBoxModifEvento.Name = "pictureBoxModifEvento";
            this.pictureBoxModifEvento.Size = new System.Drawing.Size(348, 51);
            this.pictureBoxModifEvento.TabIndex = 2;
            this.pictureBoxModifEvento.TabStop = false;
            // 
            // pictureBoxConsultaEvento
            // 
            this.pictureBoxConsultaEvento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConsultaEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConsultaEvento.Location = new System.Drawing.Point(43, 315);
            this.pictureBoxConsultaEvento.Name = "pictureBoxConsultaEvento";
            this.pictureBoxConsultaEvento.Size = new System.Drawing.Size(348, 51);
            this.pictureBoxConsultaEvento.TabIndex = 3;
            this.pictureBoxConsultaEvento.TabStop = false;
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Projecte_Chrysallis.Properties.Resources.Gestionar_Evento;
            this.ClientSize = new System.Drawing.Size(434, 539);
            this.Controls.Add(this.pictureBoxConsultaEvento);
            this.Controls.Add(this.pictureBoxModifEvento);
            this.Controls.Add(this.pictureBoxNuevoEvento);
            this.Controls.Add(this.pictureBoxAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvento";
            this.Text = "Gestor de eventos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevoEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsultaEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBoxNuevoEvento;
        private System.Windows.Forms.PictureBox pictureBoxModifEvento;
        private System.Windows.Forms.PictureBox pictureBoxConsultaEvento;
    }
}