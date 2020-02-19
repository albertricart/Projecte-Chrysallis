namespace Projecte_Chrysallis.Formularios
{
    partial class FormPerfil
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
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(34, 53);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(179, 35);
            this.buttonEmail.TabIndex = 0;
            this.buttonEmail.Text = "Modificar email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonContraseña
            // 
            this.buttonContraseña.Location = new System.Drawing.Point(34, 116);
            this.buttonContraseña.Name = "buttonContraseña";
            this.buttonContraseña.Size = new System.Drawing.Size(179, 34);
            this.buttonContraseña.TabIndex = 1;
            this.buttonContraseña.Text = "Modificar contraseña";
            this.buttonContraseña.UseVisualStyleBackColor = true;
            this.buttonContraseña.Click += new System.EventHandler(this.buttonContraseña_Click);
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 207);
            this.Controls.Add(this.buttonContraseña);
            this.Controls.Add(this.buttonEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPerfil";
            this.Text = "Perfil - MeetChrysallis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Button buttonContraseña;
    }
}