
namespace Semana11
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClean = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.labelAFP = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelDUI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btSeeAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Dui,
            this.AFP});
            this.dataGridView1.Location = new System.Drawing.Point(316, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 233);
            this.dataGridView1.TabIndex = 34;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Dui
            // 
            this.Dui.HeaderText = "Dui";
            this.Dui.Name = "Dui";
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.Name = "AFP";
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(48, 320);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.TabIndex = 33;
            this.btClean.Text = "Limpiar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(438, 66);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(100, 20);
            this.txtConsultar.TabIndex = 32;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(316, 66);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 20);
            this.btConsultar.TabIndex = 31;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(48, 265);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 38);
            this.btInsertar.TabIndex = 30;
            this.btInsertar.Text = "Insertar Registro";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(45, 228);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(27, 13);
            this.labelAFP.TabIndex = 29;
            this.labelAFP.Text = "AFP";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(198, 182);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 28;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(42, 182);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 27;
            this.labelSalario.Text = "Salario";
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(198, 222);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 26;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(198, 142);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(42, 142);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 23;
            this.labelDUI.Text = "DUI";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(42, 107);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(316, 356);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 20);
            this.btEliminar.TabIndex = 35;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(424, 356);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 20);
            this.btModificar.TabIndex = 36;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btSeeAll
            // 
            this.btSeeAll.Location = new System.Drawing.Point(521, 356);
            this.btSeeAll.Name = "btSeeAll";
            this.btSeeAll.Size = new System.Drawing.Size(75, 20);
            this.btSeeAll.TabIndex = 37;
            this.btSeeAll.Text = "Ver todo";
            this.btSeeAll.UseVisualStyleBackColor = true;
            this.btSeeAll.Click += new System.EventHandler(this.btSeeAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSeeAll);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Label labelAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btSeeAll;
    }
}

