
namespace Empleados
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
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vertodo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSliquido = new System.Windows.Forms.TextBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonLimpiarLaTabla = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(541, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(75, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.BackColor = System.Drawing.Color.Transparent;
            this.labelDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDUI.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDUI.Location = new System.Drawing.Point(75, 72);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(34, 17);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(200, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.Location = new System.Drawing.Point(200, 72);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.BackColor = System.Drawing.Color.Maroon;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegistro.Location = new System.Drawing.Point(58, 84);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 17);
            this.labelRegistro.TabIndex = 7;
            this.labelRegistro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAFP
            // 
            this.txtAFP.Enabled = false;
            this.txtAFP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAFP.Location = new System.Drawing.Point(200, 176);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salario";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(200, 140);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "AFP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(178, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = " Anadir Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(504, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(341, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Consultar por id";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.DUI,
            this.Codigo,
            this.Salario,
            this.AFP,
            this.ISSS,
            this.Descuento,
            this.SalarioLiquido});
            this.dataGridView1.Location = new System.Drawing.Point(341, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 135);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // DUI
            // 
            this.DUI.HeaderText = "DUI";
            this.DUI.MinimumWidth = 6;
            this.DUI.Name = "DUI";
            this.DUI.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
            this.Salario.Width = 125;
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.MinimumWidth = 6;
            this.AFP.Name = "AFP";
            this.AFP.ReadOnly = true;
            this.AFP.Width = 125;
            // 
            // ISSS
            // 
            this.ISSS.HeaderText = "ISSS";
            this.ISSS.Name = "ISSS";
            this.ISSS.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.HeaderText = "Salario liquido";
            this.SalarioLiquido.Name = "SalarioLiquido";
            this.SalarioLiquido.ReadOnly = true;
            // 
            // Vertodo
            // 
            this.Vertodo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Vertodo.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.Vertodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vertodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vertodo.ForeColor = System.Drawing.SystemColors.Control;
            this.Vertodo.Location = new System.Drawing.Point(850, 34);
            this.Vertodo.Margin = new System.Windows.Forms.Padding(2);
            this.Vertodo.Name = "Vertodo";
            this.Vertodo.Size = new System.Drawing.Size(93, 25);
            this.Vertodo.TabIndex = 20;
            this.Vertodo.Text = "Ver todo";
            this.Vertodo.UseVisualStyleBackColor = false;
            this.Vertodo.Click += new System.EventHandler(this.Vertodo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(722, 218);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Guardar cambios";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btEliminar.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btEliminar.Location = new System.Drawing.Point(424, 218);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(117, 32);
            this.btEliminar.TabIndex = 22;
            this.btEliminar.Text = "Eliminar Registro";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "ISSS";
            // 
            // txtIsss
            // 
            this.txtIsss.Enabled = false;
            this.txtIsss.Location = new System.Drawing.Point(200, 211);
            this.txtIsss.Name = "txtIsss";
            this.txtIsss.Size = new System.Drawing.Size(100, 20);
            this.txtIsss.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(75, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(200, 246);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(75, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Salario liquido";
            // 
            // txtSliquido
            // 
            this.txtSliquido.Enabled = false;
            this.txtSliquido.Location = new System.Drawing.Point(200, 281);
            this.txtSliquido.Name = "txtSliquido";
            this.txtSliquido.Size = new System.Drawing.Size(100, 20);
            this.txtSliquido.TabIndex = 27;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.botonLimpiar.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonLimpiar.Location = new System.Drawing.Point(90, 324);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(70, 26);
            this.botonLimpiar.TabIndex = 29;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // botonLimpiarLaTabla
            // 
            this.botonLimpiarLaTabla.BackColor = System.Drawing.SystemColors.Control;
            this.botonLimpiarLaTabla.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.botonLimpiarLaTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonLimpiarLaTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLimpiarLaTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiarLaTabla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonLimpiarLaTabla.Location = new System.Drawing.Point(589, 220);
            this.botonLimpiarLaTabla.Margin = new System.Windows.Forms.Padding(2);
            this.botonLimpiarLaTabla.Name = "botonLimpiarLaTabla";
            this.botonLimpiarLaTabla.Size = new System.Drawing.Size(70, 26);
            this.botonLimpiarLaTabla.TabIndex = 30;
            this.botonLimpiarLaTabla.Text = "Limpiar";
            this.botonLimpiarLaTabla.UseVisualStyleBackColor = false;
            this.botonLimpiarLaTabla.Click += new System.EventHandler(this.botonLimpiarLaTabla_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 106);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 32;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCodigo.Location = new System.Drawing.Point(75, 106);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 17);
            this.labelCodigo.TabIndex = 31;
            this.labelCodigo.Text = "Código";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(652, 33);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 29);
            this.button4.TabIndex = 33;
            this.button4.Text = "Consultar por codigo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empleados.Properties.Resources._39751;
            this.ClientSize = new System.Drawing.Size(1028, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonLimpiarLaTabla);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSliquido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsss);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Vertodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Vertodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSliquido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsss;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonLimpiarLaTabla;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioLiquido;
        private System.Windows.Forms.Button button4;
    }
}

