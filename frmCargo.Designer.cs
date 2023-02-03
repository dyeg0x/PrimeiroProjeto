namespace PrimeiroProjeto
{
    partial class frmCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Cargo = new System.Windows.Forms.TextBox();
            this.Novo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Localizar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.labelCódigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            this.label2.Click += new System.EventHandler(this.labelCargo_Click);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(12, 37);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(37, 20);
            this.Codigo.TabIndex = 2;
            this.Codigo.TextChanged += new System.EventHandler(this.textCódigo_TextChanged);
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(12, 91);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(623, 20);
            this.Cargo.TabIndex = 3;
            this.Cargo.TextChanged += new System.EventHandler(this.textCargo_TextChanged);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(12, 10);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 4;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(93, 10);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 5;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(174, 10);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(255, 10);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 7;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Localizar
            // 
            this.Localizar.Location = new System.Drawing.Point(336, 10);
            this.Localizar.Name = "Localizar";
            this.Localizar.Size = new System.Drawing.Size(75, 23);
            this.Localizar.TabIndex = 8;
            this.Localizar.Text = "Localizar";
            this.Localizar.UseVisualStyleBackColor = true;
            this.Localizar.Click += new System.EventHandler(this.Localizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(563, 10);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 9;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Novo);
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Controls.Add(this.Salvar);
            this.panel1.Controls.Add(this.Localizar);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.Excluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 45);
            this.panel1.TabIndex = 10;
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(666, 233);
            this.MinimumSize = new System.Drawing.Size(666, 233);
            this.Name = "frmCargo";
            this.Text = "Cadastro de Cargos";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Cargo;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Localizar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Panel panel1;
    }
}