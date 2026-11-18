namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCilindrad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvMotores = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHealer1 = new System.Windows.Forms.Panel();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.pnlRegistro2 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IblTitulo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotores)).BeginInit();
            this.pnlHealer1.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlRegistro2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Motor:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(226, 121);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(168, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fabricante:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.BackColor = System.Drawing.Color.DarkGray;
            this.txtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFabricante.ForeColor = System.Drawing.Color.White;
            this.txtFabricante.Location = new System.Drawing.Point(147, 37);
            this.txtFabricante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(190, 29);
            this.txtFabricante.TabIndex = 3;
            this.txtFabricante.TextChanged += new System.EventHandler(this.txtFabricante_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del Motor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(226, 168);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 19);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Motor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTipoMotor
            // 
            this.txtTipoMotor.BackColor = System.Drawing.Color.DarkGray;
            this.txtTipoMotor.ForeColor = System.Drawing.Color.White;
            this.txtTipoMotor.Location = new System.Drawing.Point(147, 87);
            this.txtTipoMotor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTipoMotor.Name = "txtTipoMotor";
            this.txtTipoMotor.Size = new System.Drawing.Size(190, 29);
            this.txtTipoMotor.TabIndex = 7;
            this.txtTipoMotor.TextChanged += new System.EventHandler(this.txtTipoMotor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cilindrada (L):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCilindrad
            // 
            this.txtCilindrad.BackColor = System.Drawing.Color.DarkGray;
            this.txtCilindrad.Location = new System.Drawing.Point(226, 213);
            this.txtCilindrad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCilindrad.Name = "txtCilindrad";
            this.txtCilindrad.Size = new System.Drawing.Size(168, 26);
            this.txtCilindrad.TabIndex = 9;
            this.txtCilindrad.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Potencia (HP):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPotencia
            // 
            this.txtPotencia.BackColor = System.Drawing.Color.DarkGray;
            this.txtPotencia.Location = new System.Drawing.Point(147, 135);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(190, 29);
            this.txtPotencia.TabIndex = 11;
            this.txtPotencia.TextChanged += new System.EventHandler(this.txtPotencia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Vehiculo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.BackColor = System.Drawing.Color.DarkGray;
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVehiculo.ForeColor = System.Drawing.Color.White;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Coche",
            "Camioneta",
            "SUV",
            "Motocicleta"});
            this.cmbVehiculo.Location = new System.Drawing.Point(226, 252);
            this.cmbVehiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(168, 28);
            this.cmbVehiculo.TabIndex = 13;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio (MXN):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.Location = new System.Drawing.Point(147, 177);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(190, 29);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Existencias:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtExistencias
            // 
            this.txtExistencias.BackColor = System.Drawing.Color.DarkGray;
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExistencias.ForeColor = System.Drawing.Color.White;
            this.txtExistencias.Location = new System.Drawing.Point(226, 302);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(168, 26);
            this.txtExistencias.TabIndex = 17;
            this.txtExistencias.TextChanged += new System.EventHandler(this.txtExistencias_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(37, 355);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 52);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "+Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(185, 356);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 52);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(794, 355);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 52);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(654, 355);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 52);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(503, 355);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 52);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvMotores
            // 
            this.dgvMotores.AllowUserToAddRows = false;
            this.dgvMotores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMotores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMotores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMotores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotores.EnableHeadersVisualStyles = false;
            this.dgvMotores.GridColor = System.Drawing.Color.DimGray;
            this.dgvMotores.Location = new System.Drawing.Point(36, 415);
            this.dgvMotores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMotores.MultiSelect = false;
            this.dgvMotores.Name = "dgvMotores";
            this.dgvMotores.ReadOnly = true;
            this.dgvMotores.RowHeadersVisible = false;
            this.dgvMotores.RowHeadersWidth = 51;
            this.dgvMotores.RowTemplate.Height = 24;
            this.dgvMotores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotores.Size = new System.Drawing.Size(869, 197);
            this.dgvMotores.TabIndex = 23;
            this.dgvMotores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotores_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(342, 355);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 52);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(945, 0);
            this.pnlHeader.TabIndex = 25;
            // 
            // pnlHealer1
            // 
            this.pnlHealer1.BackColor = System.Drawing.Color.Black;
            this.pnlHealer1.Controls.Add(this.label10);
            this.pnlHealer1.Controls.Add(this.pictureBox1);
            this.pnlHealer1.Controls.Add(this.IblTitulo);
            this.pnlHealer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHealer1.Location = new System.Drawing.Point(0, 0);
            this.pnlHealer1.Name = "pnlHealer1";
            this.pnlHealer1.Size = new System.Drawing.Size(945, 77);
            this.pnlHealer1.TabIndex = 26;
            this.pnlHealer1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHealer1_Paint);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.Color.Black;
            this.pnlRegistro.Controls.Add(this.label9);
            this.pnlRegistro.Controls.Add(this.label7);
            this.pnlRegistro.Controls.Add(this.label5);
            this.pnlRegistro.Controls.Add(this.label3);
            this.pnlRegistro.Controls.Add(this.label1);
            this.pnlRegistro.Location = new System.Drawing.Point(60, 75);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(167, 260);
            this.pnlRegistro.TabIndex = 27;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro_Paint);
            // 
            // pnlRegistro2
            // 
            this.pnlRegistro2.BackColor = System.Drawing.Color.Black;
            this.pnlRegistro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRegistro2.Controls.Add(this.txtPrecio);
            this.pnlRegistro2.Controls.Add(this.label8);
            this.pnlRegistro2.Controls.Add(this.txtPotencia);
            this.pnlRegistro2.Controls.Add(this.label6);
            this.pnlRegistro2.Controls.Add(this.txtTipoMotor);
            this.pnlRegistro2.Controls.Add(this.label4);
            this.pnlRegistro2.Controls.Add(this.txtFabricante);
            this.pnlRegistro2.Controls.Add(this.label2);
            this.pnlRegistro2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistro2.ForeColor = System.Drawing.Color.Transparent;
            this.pnlRegistro2.Location = new System.Drawing.Point(417, 83);
            this.pnlRegistro2.Name = "pnlRegistro2";
            this.pnlRegistro2.Size = new System.Drawing.Size(379, 245);
            this.pnlRegistro2.TabIndex = 28;
            this.pnlRegistro2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources.motoricon;
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.logoApex;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // IblTitulo
            // 
            this.IblTitulo.AutoSize = true;
            this.IblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.IblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTitulo.ForeColor = System.Drawing.Color.White;
            this.IblTitulo.Location = new System.Drawing.Point(186, 0);
            this.IblTitulo.Name = "IblTitulo";
            this.IblTitulo.Size = new System.Drawing.Size(154, 60);
            this.IblTitulo.TabIndex = 1;
            this.IblTitulo.Text = "APEX ";
            this.IblTitulo.Click += new System.EventHandler(this.IblTitulo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(324, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 60);
            this.label10.TabIndex = 3;
            this.label10.Text = "MOTORSPORTS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "label11";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 39);
            this.panel1.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(65, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "REGISTRO DE MOTORES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(945, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.pnlRegistro2);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.txtCilindrad);
            this.Controls.Add(this.pnlHealer1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.dgvMotores);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apex Motorsport  Engines";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotores)).EndInit();
            this.pnlHealer1.ResumeLayout(false);
            this.pnlHealer1.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlRegistro2.ResumeLayout(false);
            this.pnlRegistro2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCilindrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvMotores;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHealer1;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Panel pnlRegistro2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label IblTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}

