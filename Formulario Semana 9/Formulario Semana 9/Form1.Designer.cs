
namespace Formulario_Semana_9
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bAFP = new System.Windows.Forms.Button();
            this.bISSS = new System.Windows.Forms.Button();
            this.bSalarioN = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(162, 148);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(162, 197);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 1;
            this.labelDUI.Text = "DUI";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(162, 97);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(476, 254);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 3;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(165, 281);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bAFP
            // 
            this.bAFP.Location = new System.Drawing.Point(479, 87);
            this.bAFP.Name = "bAFP";
            this.bAFP.Size = new System.Drawing.Size(75, 23);
            this.bAFP.TabIndex = 5;
            this.bAFP.Text = "AFP";
            this.bAFP.UseVisualStyleBackColor = true;
            this.bAFP.Click += new System.EventHandler(this.bAFP_Click);
            // 
            // bISSS
            // 
            this.bISSS.Location = new System.Drawing.Point(479, 138);
            this.bISSS.Name = "bISSS";
            this.bISSS.Size = new System.Drawing.Size(75, 23);
            this.bISSS.TabIndex = 6;
            this.bISSS.Text = "ISSS";
            this.bISSS.UseVisualStyleBackColor = true;
            this.bISSS.Click += new System.EventHandler(this.bISSS_Click);
            // 
            // bSalarioN
            // 
            this.bSalarioN.Location = new System.Drawing.Point(479, 187);
            this.bSalarioN.Name = "bSalarioN";
            this.bSalarioN.Size = new System.Drawing.Size(75, 23);
            this.bSalarioN.TabIndex = 7;
            this.bSalarioN.Text = "Salario Neto";
            this.bSalarioN.UseVisualStyleBackColor = true;
            this.bSalarioN.Click += new System.EventHandler(this.bSalarioN_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(251, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(251, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(251, 190);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 10;
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(597, 138);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 11;
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(597, 187);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNeto.TabIndex = 12;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(597, 90);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(162, 245);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 14;
            this.labelSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(251, 238);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bSalarioN);
            this.Controls.Add(this.bISSS);
            this.Controls.Add(this.bAFP);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bAFP;
        private System.Windows.Forms.Button bISSS;
        private System.Windows.Forms.Button bSalarioN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelSalario;
    }
}

