namespace NOTE4DAYZ.Desarrollador
{
    partial class FrmAgregarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.txtRegApellido = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegContra = new System.Windows.Forms.TextBox();
            this.txtRegUsuario = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.BackColor = System.Drawing.Color.White;
            this.txtRegNombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNombre.ForeColor = System.Drawing.Color.Black;
            this.txtRegNombre.Location = new System.Drawing.Point(1069, 150);
            this.txtRegNombre.Multiline = true;
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(397, 49);
            this.txtRegNombre.TabIndex = 40;
            this.txtRegNombre.Text = "Nombre";
            // 
            // txtRegApellido
            // 
            this.txtRegApellido.BackColor = System.Drawing.Color.White;
            this.txtRegApellido.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegApellido.ForeColor = System.Drawing.Color.Black;
            this.txtRegApellido.Location = new System.Drawing.Point(1069, 243);
            this.txtRegApellido.Multiline = true;
            this.txtRegApellido.Name = "txtRegApellido";
            this.txtRegApellido.Size = new System.Drawing.Size(397, 49);
            this.txtRegApellido.TabIndex = 39;
            this.txtRegApellido.Text = "Apellido";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BackColor = System.Drawing.Color.White;
            this.txtRegEmail.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.ForeColor = System.Drawing.Color.Black;
            this.txtRegEmail.Location = new System.Drawing.Point(1069, 490);
            this.txtRegEmail.Multiline = true;
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(397, 49);
            this.txtRegEmail.TabIndex = 38;
            this.txtRegEmail.Text = "Email";
            // 
            // txtRegContra
            // 
            this.txtRegContra.BackColor = System.Drawing.Color.White;
            this.txtRegContra.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegContra.ForeColor = System.Drawing.Color.Black;
            this.txtRegContra.Location = new System.Drawing.Point(1069, 412);
            this.txtRegContra.Multiline = true;
            this.txtRegContra.Name = "txtRegContra";
            this.txtRegContra.Size = new System.Drawing.Size(397, 49);
            this.txtRegContra.TabIndex = 37;
            this.txtRegContra.Text = "Contraseña";
            // 
            // txtRegUsuario
            // 
            this.txtRegUsuario.BackColor = System.Drawing.Color.White;
            this.txtRegUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtRegUsuario.Location = new System.Drawing.Point(1069, 331);
            this.txtRegUsuario.Multiline = true;
            this.txtRegUsuario.Name = "txtRegUsuario";
            this.txtRegUsuario.Size = new System.Drawing.Size(397, 49);
            this.txtRegUsuario.TabIndex = 36;
            this.txtRegUsuario.Text = "Usuario";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnviarCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarCorreo.Image")));
            this.btnEnviarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(1154, 597);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(276, 85);
            this.btnEnviarCorreo.TabIndex = 41;
            this.btnEnviarCorreo.Text = "Agregar Usuario";
            this.btnEnviarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewNotas.EnableHeadersVisualStyles = false;
            this.dataGridViewNotas.GridColor = System.Drawing.Color.Azure;
            this.dataGridViewNotas.Location = new System.Drawing.Point(89, 95);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNotas.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewNotas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNotas.RowTemplate.Height = 28;
            this.dataGridViewNotas.Size = new System.Drawing.Size(927, 639);
            this.dataGridViewNotas.TabIndex = 42;
            // 
            // FrmAgregarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1610, 1100);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.txtRegNombre);
            this.Controls.Add(this.txtRegApellido);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtRegContra);
            this.Controls.Add(this.txtRegUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarUser";
            this.Text = "FrmAgregarUser";
            this.Load += new System.EventHandler(this.FrmAgregarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.TextBox txtRegApellido;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegContra;
        private System.Windows.Forms.TextBox txtRegUsuario;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
    }
}