namespace NOTE4DAYZ.Nota
{
    partial class FrmEliminarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarNota));
            this.comboBoxNotas = new System.Windows.Forms.ComboBox();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.richTxtContenido = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNotas
            // 
            this.comboBoxNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNotas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNotas.FormattingEnabled = true;
            this.comboBoxNotas.Location = new System.Drawing.Point(379, 61);
            this.comboBoxNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNotas.Name = "comboBoxNotas";
            this.comboBoxNotas.Size = new System.Drawing.Size(248, 27);
            this.comboBoxNotas.TabIndex = 0;
            this.comboBoxNotas.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotas_SelectedIndexChanged);
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(72, 61);
            this.comboBoxClasificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(272, 27);
            this.comboBoxClasificacion.TabIndex = 2;
            this.comboBoxClasificacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasificacion_SelectedIndexChanged);
            // 
            // richTxtContenido
            // 
            this.richTxtContenido.Location = new System.Drawing.Point(19, 154);
            this.richTxtContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtContenido.Name = "richTxtContenido";
            this.richTxtContenido.Size = new System.Drawing.Size(1027, 552);
            this.richTxtContenido.TabIndex = 49;
            this.richTxtContenido.Text = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(690, 47);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(199, 62);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar Nota";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Selecciona una Clasificación:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(375, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Selecciona una Nota:\r\n";
            // 
            // FrmEliminarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1080, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.richTxtContenido);
            this.Controls.Add(this.comboBoxClasificacion);
            this.Controls.Add(this.comboBoxNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEliminarNota";
            this.Text = "FrmEliminarNota";
            this.Load += new System.EventHandler(this.FrmEliminarNota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNotas;
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.RichTextBox richTxtContenido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}