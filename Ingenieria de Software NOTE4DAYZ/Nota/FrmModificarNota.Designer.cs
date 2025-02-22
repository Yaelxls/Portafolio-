namespace NOTE4DAYZ.Nota
{
    partial class FrmModificarNota
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
            this.dataGridMoficarNota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoficarNota)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMoficarNota
            // 
            this.dataGridMoficarNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoficarNota.Location = new System.Drawing.Point(26, 152);
            this.dataGridMoficarNota.Name = "dataGridMoficarNota";
            this.dataGridMoficarNota.RowHeadersWidth = 62;
            this.dataGridMoficarNota.RowTemplate.Height = 28;
            this.dataGridMoficarNota.Size = new System.Drawing.Size(671, 729);
            this.dataGridMoficarNota.TabIndex = 1;
            this.dataGridMoficarNota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMoficarNota_CellClick);
            this.dataGridMoficarNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMoficarNota_CellContentClick);
            // 
            // FrmModificarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1130);
            this.Controls.Add(this.dataGridMoficarNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarNota";
            this.Text = "FrmModificarNota";
            this.Load += new System.EventHandler(this.FrmModificarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoficarNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMoficarNota;
    }
}