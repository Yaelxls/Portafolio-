namespace Proyecto_Final.Consultas
{
    partial class FrmEliminar
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
            this.btnEliminarEstablecimiento = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEliminarEstablecimiento
            // 
            this.btnEliminarEstablecimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEstablecimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEstablecimiento.Location = new System.Drawing.Point(809, 164);
            this.btnEliminarEstablecimiento.Name = "btnEliminarEstablecimiento";
            this.btnEliminarEstablecimiento.Size = new System.Drawing.Size(309, 125);
            this.btnEliminarEstablecimiento.TabIndex = 58;
            this.btnEliminarEstablecimiento.Text = "Eliminar Establecimiento";
            this.btnEliminarEstablecimiento.UseVisualStyleBackColor = true;
            this.btnEliminarEstablecimiento.Click += new System.EventHandler(this.btnEliminarEstablecimiento_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(141, 164);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(485, 49);
            this.txtId.TabIndex = 57;
            this.txtId.Text = "id";
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1546, 1117);
            this.Controls.Add(this.btnEliminarEstablecimiento);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarEstablecimiento;
        private System.Windows.Forms.TextBox txtId;
    }
}