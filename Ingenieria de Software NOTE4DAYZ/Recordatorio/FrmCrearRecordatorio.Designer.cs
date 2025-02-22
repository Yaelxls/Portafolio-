namespace NOTE4DAYZ.Recordatorio
{
    partial class FrmCrearRecordatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearRecordatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.txtMensajeRecordatorio = new System.Windows.Forms.TextBox();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerRecordatorio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(41, 23);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(501, 36);
            this.comboBoxClasificacion.TabIndex = 0;
            this.comboBoxClasificacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasificacion_SelectedIndexChanged);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnviarCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarCorreo.Image")));
            this.btnEnviarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(1100, 419);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(276, 85);
            this.btnEnviarCorreo.TabIndex = 3;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // txtMensajeRecordatorio
            // 
            this.txtMensajeRecordatorio.Location = new System.Drawing.Point(0, 1174);
            this.txtMensajeRecordatorio.Name = "txtMensajeRecordatorio";
            this.txtMensajeRecordatorio.Size = new System.Drawing.Size(100, 26);
            this.txtMensajeRecordatorio.TabIndex = 6;
            this.txtMensajeRecordatorio.Visible = false;
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewNotas.EnableHeadersVisualStyles = false;
            this.dataGridViewNotas.GridColor = System.Drawing.Color.Azure;
            this.dataGridViewNotas.Location = new System.Drawing.Point(41, 85);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNotas.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewNotas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNotas.RowTemplate.Height = 28;
            this.dataGridViewNotas.Size = new System.Drawing.Size(927, 639);
            this.dataGridViewNotas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(984, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Establece una Fecha de Recordatorio:";
            // 
            // dateTimePickerRecordatorio
            // 
            this.dateTimePickerRecordatorio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRecordatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerRecordatorio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerRecordatorio.Location = new System.Drawing.Point(1009, 249);
            this.dateTimePickerRecordatorio.Name = "dateTimePickerRecordatorio";
            this.dateTimePickerRecordatorio.Size = new System.Drawing.Size(410, 32);
            this.dateTimePickerRecordatorio.TabIndex = 81;
            // 
            // FrmCrearRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1610, 1100);
            this.Controls.Add(this.dateTimePickerRecordatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.txtMensajeRecordatorio);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.comboBoxClasificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearRecordatorio";
            this.Text = "FrmRecordatorio";
            this.Load += new System.EventHandler(this.FrmCrearRecordatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.TextBox txtMensajeRecordatorio;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordatorio;
    }
}