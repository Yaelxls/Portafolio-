namespace Proyecto_Final.Consultas
{
    partial class FrmTablaAuditoria
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
            this.dataGridViewTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabla
            // 
            this.dataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTabla.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTabla.Name = "dataGridViewTabla";
            this.dataGridViewTabla.RowHeadersVisible = false;
            this.dataGridViewTabla.RowHeadersWidth = 62;
            this.dataGridViewTabla.RowTemplate.Height = 28;
            this.dataGridViewTabla.Size = new System.Drawing.Size(1546, 1061);
            this.dataGridViewTabla.TabIndex = 1;
            // 
            // FrmTablaAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 1061);
            this.Controls.Add(this.dataGridViewTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablaAuditoria";
            this.Text = "FrmTablaAuditoria";
            this.Load += new System.EventHandler(this.FrmTablaAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabla;
    }
}