
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.labelAFP = new System.Windows.Forms.Label();
            this.btInsertar = new System.Windows.Forms.Button();
            this.labConsNombre = new System.Windows.Forms.Label();
            this.labConsDUI = new System.Windows.Forms.Label();
            this.labConsSalario = new System.Windows.Forms.Label();
            this.labConsAFP = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(118, 84);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(118, 119);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(274, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(274, 119);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(82, 257);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(271, 262);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(274, 199);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(118, 159);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 10;
            this.labelSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(274, 159);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(121, 205);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(27, 13);
            this.labelAFP.TabIndex = 12;
            this.labelAFP.Text = "AFP";
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(391, 249);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 38);
            this.btInsertar.TabIndex = 13;
            this.btInsertar.Text = "Insertar Registro";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // labConsNombre
            // 
            this.labConsNombre.AutoSize = true;
            this.labConsNombre.Location = new System.Drawing.Point(509, 44);
            this.labConsNombre.Name = "labConsNombre";
            this.labConsNombre.Size = new System.Drawing.Size(35, 13);
            this.labConsNombre.TabIndex = 14;
            this.labConsNombre.Text = "label1";
            // 
            // labConsDUI
            // 
            this.labConsDUI.AutoSize = true;
            this.labConsDUI.Location = new System.Drawing.Point(509, 86);
            this.labConsDUI.Name = "labConsDUI";
            this.labConsDUI.Size = new System.Drawing.Size(35, 13);
            this.labConsDUI.TabIndex = 15;
            this.labConsDUI.Text = "label2";
            // 
            // labConsSalario
            // 
            this.labConsSalario.AutoSize = true;
            this.labConsSalario.Location = new System.Drawing.Point(509, 126);
            this.labConsSalario.Name = "labConsSalario";
            this.labConsSalario.Size = new System.Drawing.Size(35, 13);
            this.labConsSalario.TabIndex = 16;
            this.labConsSalario.Text = "label3";
            // 
            // labConsAFP
            // 
            this.labConsAFP.AutoSize = true;
            this.labConsAFP.Location = new System.Drawing.Point(509, 166);
            this.labConsAFP.Name = "labConsAFP";
            this.labConsAFP.Size = new System.Drawing.Size(35, 13);
            this.labConsAFP.TabIndex = 17;
            this.labConsAFP.Text = "label4";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(512, 249);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 38);
            this.btConsultar.TabIndex = 18;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(82, 297);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.TabIndex = 20;
            this.btClean.Text = "Limpiar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 332);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.labConsAFP);
            this.Controls.Add(this.labConsSalario);
            this.Controls.Add(this.labConsDUI);
            this.Controls.Add(this.labConsNombre);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelAFP;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label labConsAFP;
        private System.Windows.Forms.Label labConsSalario;
        private System.Windows.Forms.Label labConsDUI;
        private System.Windows.Forms.Label labConsNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btClean;
    }
}

