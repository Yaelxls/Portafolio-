namespace NOTE4DAYZ
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRegUsuario = new System.Windows.Forms.TextBox();
            this.txtRegContra = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtRegApellido = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LinklblAceptar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.LinkLabelAqui = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 213);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(111, 372);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtRegUsuario
            // 
            this.txtRegUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtRegUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsuario.ForeColor = System.Drawing.Color.White;
            this.txtRegUsuario.Location = new System.Drawing.Point(191, 213);
            this.txtRegUsuario.Multiline = true;
            this.txtRegUsuario.Name = "txtRegUsuario";
            this.txtRegUsuario.Size = new System.Drawing.Size(271, 49);
            this.txtRegUsuario.TabIndex = 29;
            this.txtRegUsuario.Text = "Usuario";
            this.txtRegUsuario.TextChanged += new System.EventHandler(this.txtRegUsuario_TextChanged);
            this.txtRegUsuario.Enter += new System.EventHandler(this.txtRegUsuarioEnter_TextChanged);
            this.txtRegUsuario.Leave += new System.EventHandler(this.txtRegUsuarioLeave_TextChanged);
            // 
            // txtRegContra
            // 
            this.txtRegContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtRegContra.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegContra.ForeColor = System.Drawing.Color.White;
            this.txtRegContra.Location = new System.Drawing.Point(191, 294);
            this.txtRegContra.Multiline = true;
            this.txtRegContra.Name = "txtRegContra";
            this.txtRegContra.Size = new System.Drawing.Size(271, 49);
            this.txtRegContra.TabIndex = 30;
            this.txtRegContra.Text = "Contraseña";
            this.txtRegContra.TextChanged += new System.EventHandler(this.txtRegContra_TextChanged);
            this.txtRegContra.Enter += new System.EventHandler(this.txtRegContraseña_Enter);
            this.txtRegContra.Leave += new System.EventHandler(this.txtRegContraseña_Leave);
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtRegEmail.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.ForeColor = System.Drawing.Color.White;
            this.txtRegEmail.Location = new System.Drawing.Point(191, 372);
            this.txtRegEmail.Multiline = true;
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(271, 49);
            this.txtRegEmail.TabIndex = 31;
            this.txtRegEmail.Text = "Email";
            this.txtRegEmail.TextChanged += new System.EventHandler(this.txtRegEmail_TextChanged);
            this.txtRegEmail.Enter += new System.EventHandler(this.txtRegEmailEnter_TextChanged);
            this.txtRegEmail.Leave += new System.EventHandler(this.txtRegEmailLeave_TextChanged);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(203, 579);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(177, 78);
            this.btnRegistrarse.TabIndex = 32;
            this.btnRegistrarse.Text = "Registrase";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtRegApellido
            // 
            this.txtRegApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtRegApellido.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegApellido.ForeColor = System.Drawing.Color.White;
            this.txtRegApellido.Location = new System.Drawing.Point(191, 125);
            this.txtRegApellido.Multiline = true;
            this.txtRegApellido.Name = "txtRegApellido";
            this.txtRegApellido.Size = new System.Drawing.Size(271, 49);
            this.txtRegApellido.TabIndex = 33;
            this.txtRegApellido.Text = "Apellido";
            this.txtRegApellido.TextChanged += new System.EventHandler(this.txtRegApellido_TextChanged);
            this.txtRegApellido.Enter += new System.EventHandler(this.txtRegApellidoEnter_TextChanged);
            this.txtRegApellido.Leave += new System.EventHandler(this.txtRegApellidoLeave_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(111, 125);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtRegNombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNombre.ForeColor = System.Drawing.Color.White;
            this.txtRegNombre.Location = new System.Drawing.Point(191, 32);
            this.txtRegNombre.Multiline = true;
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(271, 49);
            this.txtRegNombre.TabIndex = 35;
            this.txtRegNombre.Text = "Nombre";
            this.txtRegNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtRegNombre.Enter += new System.EventHandler(this.textRegBox3Enter_TextChanged);
            this.txtRegNombre.Leave += new System.EventHandler(this.textRegBox3Leave_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(111, 32);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // LinklblAceptar
            // 
            this.LinklblAceptar.AutoSize = true;
            this.LinklblAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinklblAceptar.ForeColor = System.Drawing.Color.White;
            this.LinklblAceptar.Location = new System.Drawing.Point(220, 527);
            this.LinklblAceptar.Name = "LinklblAceptar";
            this.LinklblAceptar.Size = new System.Drawing.Size(210, 24);
            this.LinklblAceptar.TabIndex = 37;
            this.LinklblAceptar.Text = "Acepto crear una cuenta";
            this.LinklblAceptar.UseVisualStyleBackColor = true;
            this.LinklblAceptar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 38;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(111, 294);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(48, 49);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 39;
            this.pbPassword.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Si no tienes un Email, puedes crear uno\r\n";
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(551, 4);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(18, 18);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 42;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // LinkLabelAqui
            // 
            this.LinkLabelAqui.AutoSize = true;
            this.LinkLabelAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabelAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAqui.LinkColor = System.Drawing.Color.White;
            this.LinkLabelAqui.Location = new System.Drawing.Point(384, 463);
            this.LinkLabelAqui.Name = "LinkLabelAqui";
            this.LinkLabelAqui.Size = new System.Drawing.Size(46, 24);
            this.LinkLabelAqui.TabIndex = 43;
            this.LinkLabelAqui.TabStop = true;
            this.LinkLabelAqui.Text = "aquí";
            this.LinkLabelAqui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAqui_LinkClicked);
            // 
            // FrmRegistro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(570, 738);
            this.Controls.Add(this.LinkLabelAqui);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinklblAceptar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtRegNombre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtRegApellido);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtRegContra);
            this.Controls.Add(this.txtRegUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRegistro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtRegUsuario;
        private System.Windows.Forms.TextBox txtRegContra;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtRegApellido;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox LinklblAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.LinkLabel LinkLabelAqui;
    }
}