namespace NOTE4DAYZ
{
    partial class FrmCrearNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearNota));
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.datefechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtContenido = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxFuente = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxTamaño = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAlinearIzquierda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCentrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAlinearDerecha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mayúsculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minúsculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeshacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRehacer = new System.Windows.Forms.ToolStripButton();
            this.checkRecordatorio = new System.Windows.Forms.CheckBox();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkGuardadoAuto = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(310, 189);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(1270, 43);
            this.txtTitulo.TabIndex = 43;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // datefechaLimite
            // 
            this.datefechaLimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datefechaLimite.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefechaLimite.Location = new System.Drawing.Point(1172, 129);
            this.datefechaLimite.Name = "datefechaLimite";
            this.datefechaLimite.Size = new System.Drawing.Size(409, 32);
            this.datefechaLimite.TabIndex = 46;
            this.datefechaLimite.ValueChanged += new System.EventHandler(this.datefechaLimite_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1166, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Establecer fecha límite:";
            // 
            // richTxtContenido
            // 
            this.richTxtContenido.Location = new System.Drawing.Point(42, 262);
            this.richTxtContenido.Name = "richTxtContenido";
            this.richTxtContenido.Size = new System.Drawing.Size(1538, 847);
            this.richTxtContenido.TabIndex = 48;
            this.richTxtContenido.Text = "";
            this.richTxtContenido.TextChanged += new System.EventHandler(this.richTxtContenido_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxFuente,
            this.toolStripSeparator9,
            this.toolStripComboBoxTamaño,
            this.toolStripSeparator8,
            this.toolStripButtonAlinearIzquierda,
            this.toolStripSeparator7,
            this.toolStripButtonCentrar,
            this.toolStripSeparator6,
            this.toolStripButtonAlinearDerecha,
            this.toolStripSeparator5,
            this.toolStripButtonColor,
            this.toolStripSeparator4,
            this.toolStripButtonBold,
            this.toolStripSeparator3,
            this.toolStripButtonItalic,
            this.toolStripSeparator2,
            this.toolStripButtonUnderline,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator10,
            this.btnCortar,
            this.toolStripSeparator12,
            this.btnCopiar,
            this.toolStripSeparator13,
            this.btnPegar,
            this.toolStripSeparator14,
            this.toolStripButtonDeshacer,
            this.toolStripSeparator11,
            this.toolStripButtonRehacer});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1624, 33);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripComboBoxFuente
            // 
            this.toolStripComboBoxFuente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxFuente.Name = "toolStripComboBoxFuente";
            this.toolStripComboBoxFuente.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBoxFuente.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFuente_SelectedIndexChanged);
            this.toolStripComboBoxFuente.Click += new System.EventHandler(this.toolStripComboBoxFuente_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripComboBoxTamaño
            // 
            this.toolStripComboBoxTamaño.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxTamaño.Name = "toolStripComboBoxTamaño";
            this.toolStripComboBoxTamaño.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBoxTamaño.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxTamaño_SelectedIndexChanged);
            this.toolStripComboBoxTamaño.Click += new System.EventHandler(this.toolStripComboBoxTamaño_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonAlinearIzquierda
            // 
            this.toolStripButtonAlinearIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlinearIzquierda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAlinearIzquierda.Image")));
            this.toolStripButtonAlinearIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlinearIzquierda.Name = "toolStripButtonAlinearIzquierda";
            this.toolStripButtonAlinearIzquierda.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAlinearIzquierda.Text = "Alinear a la izquierda";
            this.toolStripButtonAlinearIzquierda.Click += new System.EventHandler(this.toolStripButtonAlinearIzquierda_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonCentrar
            // 
            this.toolStripButtonCentrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentrar.Image")));
            this.toolStripButtonCentrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentrar.Name = "toolStripButtonCentrar";
            this.toolStripButtonCentrar.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonCentrar.Text = "Centrar";
            this.toolStripButtonCentrar.Click += new System.EventHandler(this.toolStripButtonCentrar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonAlinearDerecha
            // 
            this.toolStripButtonAlinearDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlinearDerecha.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAlinearDerecha.Image")));
            this.toolStripButtonAlinearDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlinearDerecha.Name = "toolStripButtonAlinearDerecha";
            this.toolStripButtonAlinearDerecha.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAlinearDerecha.Text = "Alinear a la derecha";
            this.toolStripButtonAlinearDerecha.Click += new System.EventHandler(this.toolStripButtonAlinearDerecha_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonColor.Text = "Color de fuente";
            this.toolStripButtonColor.Click += new System.EventHandler(this.toolStripButtonColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonBold.Text = "Negrita";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonItalic.Text = "Cursiva";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonUnderline.Text = "Subrayar";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayúsculasToolStripMenuItem,
            this.minúsculasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripDropDownButton1.Text = "Cambiar mayúsculas y minúsculas";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // mayúsculasToolStripMenuItem
            // 
            this.mayúsculasToolStripMenuItem.Name = "mayúsculasToolStripMenuItem";
            this.mayúsculasToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.mayúsculasToolStripMenuItem.Text = "mayúsculas";
            this.mayúsculasToolStripMenuItem.Click += new System.EventHandler(this.mayúsculasToolStripMenuItem_Click_1);
            // 
            // minúsculasToolStripMenuItem
            // 
            this.minúsculasToolStripMenuItem.Name = "minúsculasToolStripMenuItem";
            this.minúsculasToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.minúsculasToolStripMenuItem.Text = "minúsculas ";
            this.minúsculasToolStripMenuItem.Click += new System.EventHandler(this.minúsculasToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 33);
            // 
            // btnCortar
            // 
            this.btnCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCortar.Image = ((System.Drawing.Image)(resources.GetObject("btnCortar.Image")));
            this.btnCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(34, 28);
            this.btnCortar.Text = "Cortar";
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 33);
            // 
            // btnCopiar
            // 
            this.btnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
            this.btnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(34, 28);
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 33);
            // 
            // btnPegar
            // 
            this.btnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPegar.Image = ((System.Drawing.Image)(resources.GetObject("btnPegar.Image")));
            this.btnPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(34, 28);
            this.btnPegar.Text = "Pegar";
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonDeshacer
            // 
            this.toolStripButtonDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeshacer.Image")));
            this.toolStripButtonDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeshacer.Name = "toolStripButtonDeshacer";
            this.toolStripButtonDeshacer.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonDeshacer.Text = "Deshacer";
            this.toolStripButtonDeshacer.Click += new System.EventHandler(this.toolStripButtonDeshacer_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonRehacer
            // 
            this.toolStripButtonRehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRehacer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRehacer.Image")));
            this.toolStripButtonRehacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRehacer.Name = "toolStripButtonRehacer";
            this.toolStripButtonRehacer.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonRehacer.Text = "Rehacer";
            this.toolStripButtonRehacer.Click += new System.EventHandler(this.toolStripButtonRehacer_Click);
            // 
            // checkRecordatorio
            // 
            this.checkRecordatorio.AutoSize = true;
            this.checkRecordatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRecordatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRecordatorio.Location = new System.Drawing.Point(1052, 2);
            this.checkRecordatorio.Name = "checkRecordatorio";
            this.checkRecordatorio.Size = new System.Drawing.Size(188, 32);
            this.checkRecordatorio.TabIndex = 54;
            this.checkRecordatorio.Text = "Recordatorio";
            this.checkRecordatorio.UseVisualStyleBackColor = true;
            this.checkRecordatorio.CheckedChanged += new System.EventHandler(this.checkRecordatorio_CheckedChanged);
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(792, 129);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(350, 31);
            this.comboBoxClasificacion.TabIndex = 60;
            this.comboBoxClasificacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasificacion_SelectedIndexChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(42, 52);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(262, 194);
            this.pictureBoxImagen.TabIndex = 62;
            this.pictureBoxImagen.TabStop = false;
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarNota.Image")));
            this.btnGuardarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarNota.Location = new System.Drawing.Point(568, 88);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(212, 71);
            this.btnGuardarNota.TabIndex = 63;
            this.btnGuardarNota.Text = "Crear Nota";
            this.btnGuardarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarImagen.Image")));
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarImagen.Location = new System.Drawing.Point(318, 88);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(244, 71);
            this.btnCargarImagen.TabIndex = 64;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(786, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 28);
            this.label2.TabIndex = 65;
            this.label2.Text = "Selecciona una Clasificación:\r\n";
            // 
            // checkGuardadoAuto
            // 
            this.checkGuardadoAuto.AutoSize = true;
            this.checkGuardadoAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkGuardadoAuto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGuardadoAuto.Location = new System.Drawing.Point(1276, 2);
            this.checkGuardadoAuto.Name = "checkGuardadoAuto";
            this.checkGuardadoAuto.Size = new System.Drawing.Size(300, 32);
            this.checkGuardadoAuto.TabIndex = 55;
            this.checkGuardadoAuto.Text = "Guardado autómatico";
            this.checkGuardadoAuto.UseVisualStyleBackColor = true;
            this.checkGuardadoAuto.CheckedChanged += new System.EventHandler(this.checkGuardadoAuto_CheckedChanged);
            // 
            // FrmCrearNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1624, 1120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.comboBoxClasificacion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.checkGuardadoAuto);
            this.Controls.Add(this.checkRecordatorio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datefechaLimite);
            this.Controls.Add(this.richTxtContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearNota";
            this.Text = "FrmCrearNota";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker datefechaLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtContenido;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTamaño;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlinearIzquierda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlinearDerecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mayúsculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minúsculasToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkRecordatorio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFuente;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButtonRehacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnCortar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btnCopiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton btnPegar;
        private System.Windows.Forms.CheckBox checkGuardadoAuto;
    }
}