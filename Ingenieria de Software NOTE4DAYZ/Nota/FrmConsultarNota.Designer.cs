namespace NOTE4DAYZ.Nota
{
    partial class FrmConsultarNota
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarNota));
            this.btnCargarNota = new System.Windows.Forms.Button();
            this.richTextBoxContenido = new System.Windows.Forms.RichTextBox();
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
            this.btnPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeshacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRehacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBuscarPalabra = new System.Windows.Forms.TextBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBoxNotas = new System.Windows.Forms.ComboBox();
            this.timerGuardadoAuto = new System.Windows.Forms.Timer(this.components);
            this.checkGuardadoAuto = new System.Windows.Forms.CheckBox();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblcrea = new System.Windows.Forms.Label();
            this.lblmodi = new System.Windows.Forms.Label();
            this.lblfechaCreacion = new System.Windows.Forms.Label();
            this.lblfechaModificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxModificarClasificacion = new System.Windows.Forms.ComboBox();
            this.btnModificarClasificacion = new System.Windows.Forms.Button();
            this.btnEliminarClasificacion = new System.Windows.Forms.Button();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarNota
            // 
            this.btnCargarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCargarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarNota.Image")));
            this.btnCargarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarNota.Location = new System.Drawing.Point(655, 53);
            this.btnCargarNota.Name = "btnCargarNota";
            this.btnCargarNota.Size = new System.Drawing.Size(219, 71);
            this.btnCargarNota.TabIndex = 2;
            this.btnCargarNota.Text = "Cargar Nota";
            this.btnCargarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarNota.UseVisualStyleBackColor = true;
            this.btnCargarNota.Click += new System.EventHandler(this.btnCargarNota_Click);
            // 
            // richTextBoxContenido
            // 
            this.richTextBoxContenido.Location = new System.Drawing.Point(45, 260);
            this.richTextBoxContenido.Name = "richTextBoxContenido";
            this.richTextBoxContenido.Size = new System.Drawing.Size(1538, 847);
            this.richTextBoxContenido.TabIndex = 4;
            this.richTextBoxContenido.Text = "";
            this.richTextBoxContenido.TextChanged += new System.EventHandler(this.richTextBoxContenido_TextChanged);
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
            this.btnPegar,
            this.toolStripSeparator14,
            this.btnCopiar,
            this.toolStripSeparator13,
            this.btnCortar,
            this.toolStripButtonDeshacer,
            this.toolStripSeparator11,
            this.toolStripButtonRehacer,
            this.toolStripSeparator12});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1630, 33);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripComboBoxFuente
            // 
            this.toolStripComboBoxFuente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
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
            this.toolStripComboBoxTamaño.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
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
            // 
            // mayúsculasToolStripMenuItem
            // 
            this.mayúsculasToolStripMenuItem.Name = "mayúsculasToolStripMenuItem";
            this.mayúsculasToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.mayúsculasToolStripMenuItem.Text = "mayúsculas";
            this.mayúsculasToolStripMenuItem.Click += new System.EventHandler(this.mayúsculasToolStripMenuItem_Click);
            // 
            // minúsculasToolStripMenuItem
            // 
            this.minúsculasToolStripMenuItem.Name = "minúsculasToolStripMenuItem";
            this.minúsculasToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.minúsculasToolStripMenuItem.Text = "minúsculas ";
            this.minúsculasToolStripMenuItem.Click += new System.EventHandler(this.minúsculasToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 33);
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
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 33);
            // 
            // textBuscarPalabra
            // 
            this.textBuscarPalabra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarPalabra.Location = new System.Drawing.Point(1335, 2);
            this.textBuscarPalabra.Multiline = true;
            this.textBuscarPalabra.Name = "textBuscarPalabra";
            this.textBuscarPalabra.Size = new System.Drawing.Size(137, 41);
            this.textBuscarPalabra.TabIndex = 63;
            this.textBuscarPalabra.Text = "Buscar";
            this.textBuscarPalabra.Enter += new System.EventHandler(this.textBuscarPalabra_Enter);
            this.textBuscarPalabra.Leave += new System.EventHandler(this.textBuscarPalabra_Leave);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(45, 51);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(262, 194);
            this.pictureBoxImagen.TabIndex = 70;
            this.pictureBoxImagen.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(330, 202);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(1256, 43);
            this.txtTitulo.TabIndex = 71;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1496, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 43);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Aceptar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBoxNotas
            // 
            this.comboBoxNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNotas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxNotas.FormattingEnabled = true;
            this.comboBoxNotas.Location = new System.Drawing.Point(330, 97);
            this.comboBoxNotas.Name = "comboBoxNotas";
            this.comboBoxNotas.Size = new System.Drawing.Size(300, 27);
            this.comboBoxNotas.TabIndex = 77;
            // 
            // timerGuardadoAuto
            // 
            this.timerGuardadoAuto.Interval = 5000;
            this.timerGuardadoAuto.Tick += new System.EventHandler(this.timerGuardadoAuto_Tick);
            // 
            // checkGuardadoAuto
            // 
            this.checkGuardadoAuto.AutoSize = true;
            this.checkGuardadoAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkGuardadoAuto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGuardadoAuto.Location = new System.Drawing.Point(1027, 2);
            this.checkGuardadoAuto.Name = "checkGuardadoAuto";
            this.checkGuardadoAuto.Size = new System.Drawing.Size(257, 27);
            this.checkGuardadoAuto.TabIndex = 78;
            this.checkGuardadoAuto.Text = "Guardado Automático";
            this.checkGuardadoAuto.UseVisualStyleBackColor = true;
            this.checkGuardadoAuto.CheckedChanged += new System.EventHandler(this.checkGuardadoAuto_CheckedChanged_1);
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(330, 53);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(300, 27);
            this.comboBoxClasificacion.TabIndex = 79;
            this.comboBoxClasificacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasificacion_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1027, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 27);
            this.checkBox1.TabIndex = 80;
            this.checkBox1.Text = "Guardado Periódico";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblcrea
            // 
            this.lblcrea.AutoSize = true;
            this.lblcrea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrea.Location = new System.Drawing.Point(1309, 112);
            this.lblcrea.Name = "lblcrea";
            this.lblcrea.Size = new System.Drawing.Size(186, 22);
            this.lblcrea.TabIndex = 64;
            this.lblcrea.Text = "Fecha de creacion:";
            // 
            // lblmodi
            // 
            this.lblmodi.AutoSize = true;
            this.lblmodi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodi.Location = new System.Drawing.Point(1276, 73);
            this.lblmodi.Name = "lblmodi";
            this.lblmodi.Size = new System.Drawing.Size(222, 22);
            this.lblmodi.TabIndex = 65;
            this.lblmodi.Text = "Fecha de modificación:";
            // 
            // lblfechaCreacion
            // 
            this.lblfechaCreacion.AutoSize = true;
            this.lblfechaCreacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaCreacion.Location = new System.Drawing.Point(1485, 113);
            this.lblfechaCreacion.Name = "lblfechaCreacion";
            this.lblfechaCreacion.Size = new System.Drawing.Size(114, 21);
            this.lblfechaCreacion.TabIndex = 66;
            this.lblfechaCreacion.Text = "dd/MM/yyyy";
            // 
            // lblfechaModificacion
            // 
            this.lblfechaModificacion.AutoSize = true;
            this.lblfechaModificacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaModificacion.Location = new System.Drawing.Point(1485, 73);
            this.lblfechaModificacion.Name = "lblfechaModificacion";
            this.lblfechaModificacion.Size = new System.Drawing.Size(114, 21);
            this.lblfechaModificacion.TabIndex = 67;
            this.lblfechaModificacion.Text = "dd/MM/yyyy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1369, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha Límite:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.Location = new System.Drawing.Point(1485, 155);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(114, 21);
            this.lblFechaLimite.TabIndex = 69;
            this.lblFechaLimite.Text = "dd/MM/yyyy";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(880, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(90, 121);
            this.listView1.TabIndex = 81;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(976, 71);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(90, 121);
            this.listView2.TabIndex = 82;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1118, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 83;
            this.button1.Text = "Restaurar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxModificarClasificacion
            // 
            this.comboBoxModificarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxModificarClasificacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModificarClasificacion.FormattingEnabled = true;
            this.comboBoxModificarClasificacion.Location = new System.Drawing.Point(330, 153);
            this.comboBoxModificarClasificacion.Name = "comboBoxModificarClasificacion";
            this.comboBoxModificarClasificacion.Size = new System.Drawing.Size(300, 27);
            this.comboBoxModificarClasificacion.TabIndex = 84;
            // 
            // btnModificarClasificacion
            // 
            this.btnModificarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarClasificacion.Location = new System.Drawing.Point(636, 136);
            this.btnModificarClasificacion.Name = "btnModificarClasificacion";
            this.btnModificarClasificacion.Size = new System.Drawing.Size(126, 56);
            this.btnModificarClasificacion.TabIndex = 85;
            this.btnModificarClasificacion.Text = "Modificar  Clasificación";
            this.btnModificarClasificacion.UseVisualStyleBackColor = true;
            this.btnModificarClasificacion.Click += new System.EventHandler(this.btnModificarClasificacion_Click);
            // 
            // btnEliminarClasificacion
            // 
            this.btnEliminarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarClasificacion.Location = new System.Drawing.Point(764, 135);
            this.btnEliminarClasificacion.Name = "btnEliminarClasificacion";
            this.btnEliminarClasificacion.Size = new System.Drawing.Size(115, 56);
            this.btnEliminarClasificacion.TabIndex = 86;
            this.btnEliminarClasificacion.Text = "Eliminar  Clasificación";
            this.btnEliminarClasificacion.UseVisualStyleBackColor = true;
            this.btnEliminarClasificacion.Click += new System.EventHandler(this.btnEliminarClasificacion_Click);
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarNota.Image")));
            this.btnGuardarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarNota.Location = new System.Drawing.Point(1085, 125);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(219, 71);
            this.btnGuardarNota.TabIndex = 75;
            this.btnGuardarNota.Text = "Guardar Nota";
            this.btnGuardarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // FrmConsultarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1630, 1120);
            this.Controls.Add(this.btnEliminarClasificacion);
            this.Controls.Add(this.btnModificarClasificacion);
            this.Controls.Add(this.comboBoxModificarClasificacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxClasificacion);
            this.Controls.Add(this.checkGuardadoAuto);
            this.Controls.Add(this.comboBoxNotas);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.lblFechaLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfechaModificacion);
            this.Controls.Add(this.lblfechaCreacion);
            this.Controls.Add(this.lblmodi);
            this.Controls.Add(this.lblcrea);
            this.Controls.Add(this.textBuscarPalabra);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBoxContenido);
            this.Controls.Add(this.btnCargarNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarNota";
            this.Text = "FrmConsultarNota";
            this.Load += new System.EventHandler(this.FrmConsultarNota_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargarNota;
        private System.Windows.Forms.RichTextBox richTextBoxContenido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFuente;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButtonRehacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBuscarPalabra;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxNotas;
        private System.Windows.Forms.Timer timerGuardadoAuto;
        private System.Windows.Forms.CheckBox checkGuardadoAuto;
        private System.Windows.Forms.ToolStripButton btnPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton btnCopiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btnCortar;
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblcrea;
        private System.Windows.Forms.Label lblmodi;
        private System.Windows.Forms.Label lblfechaCreacion;
        private System.Windows.Forms.Label lblfechaModificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxModificarClasificacion;
        private System.Windows.Forms.Button btnModificarClasificacion;
        private System.Windows.Forms.Button btnEliminarClasificacion;
        private System.Windows.Forms.Button btnGuardarNota;
    }
}