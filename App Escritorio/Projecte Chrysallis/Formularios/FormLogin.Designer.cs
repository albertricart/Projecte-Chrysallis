namespace Projecte_Chrysallis.Formularios
{
    partial class FormLogin
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
            this.labelIncorrectos = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxOjo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIncorrectos
            // 
            this.labelIncorrectos.AutoSize = true;
            this.labelIncorrectos.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectos.Location = new System.Drawing.Point(49, 130);
            this.labelIncorrectos.Name = "labelIncorrectos";
            this.labelIncorrectos.Size = new System.Drawing.Size(176, 13);
            this.labelIncorrectos.TabIndex = 0;
            this.labelIncorrectos.Text = "Usuario y/o contraseña incorrectos ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(83, 45);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(142, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(63, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Me olvidé de la contraseña\r\n";
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Location = new System.Drawing.Point(83, 155);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(93, 36);
            this.buttonAcceder.TabIndex = 3;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(83, 98);
            this.textBoxContrasenya.MaxLength = 16;
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.PasswordChar = '•';
            this.textBoxContrasenya.Size = new System.Drawing.Size(142, 20);
            this.textBoxContrasenya.TabIndex = 2;
            this.textBoxContrasenya.Enter += new System.EventHandler(this.textBoxContrasenya_Enter);
            this.textBoxContrasenya.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContrasenya_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // pictureBoxOjo
            // 
            this.pictureBoxOjo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOjo.Image = global::Projecte_Chrysallis.Properties.Resources.ojo;
            this.pictureBoxOjo.Location = new System.Drawing.Point(231, 95);
            this.pictureBoxOjo.Name = "pictureBoxOjo";
            this.pictureBoxOjo.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOjo.TabIndex = 9;
            this.pictureBoxOjo.TabStop = false;
            this.pictureBoxOjo.Click += new System.EventHandler(this.pictureBoxOjo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Projecte_Chrysallis.Properties.Resources.candado;
            this.pictureBox2.Location = new System.Drawing.Point(47, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Projecte_Chrysallis.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(47, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.pictureBoxOjo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelIncorrectos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIncorrectos;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxOjo;
    }
}