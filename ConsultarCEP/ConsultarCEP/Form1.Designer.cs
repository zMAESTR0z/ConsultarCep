namespace ConsultarCEP
{
    partial class Form1
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
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.lb_CEP = new System.Windows.Forms.Label();
            this.dgv_CEP = new System.Windows.Forms.DataGridView();
            this.bt_CEP = new System.Windows.Forms.Button();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_logradouro = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_filtrarE = new System.Windows.Forms.Button();
            this.btn_filtrarC = new System.Windows.Forms.Button();
            this.txt_FiltraEstado = new System.Windows.Forms.TextBox();
            this.txt_FiltraCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CEP)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(253, 65);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(100, 20);
            this.txt_CEP.TabIndex = 0;
            // 
            // lb_CEP
            // 
            this.lb_CEP.AutoSize = true;
            this.lb_CEP.Location = new System.Drawing.Point(171, 68);
            this.lb_CEP.Name = "lb_CEP";
            this.lb_CEP.Size = new System.Drawing.Size(73, 13);
            this.lb_CEP.TabIndex = 1;
            this.lb_CEP.Text = "Digite o CEP: ";
            // 
            // dgv_CEP
            // 
            this.dgv_CEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CEP.Location = new System.Drawing.Point(174, 300);
            this.dgv_CEP.Name = "dgv_CEP";
            this.dgv_CEP.Size = new System.Drawing.Size(269, 150);
            this.dgv_CEP.TabIndex = 2;
            // 
            // bt_CEP
            // 
            this.bt_CEP.Location = new System.Drawing.Point(368, 63);
            this.bt_CEP.Name = "bt_CEP";
            this.bt_CEP.Size = new System.Drawing.Size(75, 23);
            this.bt_CEP.TabIndex = 3;
            this.bt_CEP.Text = "Buscar";
            this.bt_CEP.UseVisualStyleBackColor = true;
            this.bt_CEP.Click += new System.EventHandler(this.bt_CEP_Click);
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(253, 91);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(190, 20);
            this.txt_logradouro.TabIndex = 4;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(253, 117);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(100, 20);
            this.txt_bairro.TabIndex = 5;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(253, 143);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(100, 20);
            this.txt_cidade.TabIndex = 6;
            // 
            // lb_logradouro
            // 
            this.lb_logradouro.AutoSize = true;
            this.lb_logradouro.Location = new System.Drawing.Point(171, 94);
            this.lb_logradouro.Name = "lb_logradouro";
            this.lb_logradouro.Size = new System.Drawing.Size(67, 13);
            this.lb_logradouro.TabIndex = 7;
            this.lb_logradouro.Text = "Logradouro: ";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Location = new System.Drawing.Point(171, 120);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(40, 13);
            this.lb_bairro.TabIndex = 8;
            this.lb_bairro.Text = "Bairro: ";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(171, 146);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(43, 13);
            this.lb_cidade.TabIndex = 9;
            this.lb_cidade.Text = "Cidade:";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(171, 172);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(43, 13);
            this.lb_estado.TabIndex = 11;
            this.lb_estado.Text = "Estado:";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(253, 169);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(100, 20);
            this.txt_estado.TabIndex = 10;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(174, 213);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_filtrarE
            // 
            this.btn_filtrarE.Location = new System.Drawing.Point(159, 242);
            this.btn_filtrarE.Name = "btn_filtrarE";
            this.btn_filtrarE.Size = new System.Drawing.Size(90, 23);
            this.btn_filtrarE.TabIndex = 13;
            this.btn_filtrarE.Text = "Filtrar Estado";
            this.btn_filtrarE.UseVisualStyleBackColor = true;
            this.btn_filtrarE.Click += new System.EventHandler(this.btn_filtrarE_Click);
            // 
            // btn_filtrarC
            // 
            this.btn_filtrarC.Location = new System.Drawing.Point(159, 271);
            this.btn_filtrarC.Name = "btn_filtrarC";
            this.btn_filtrarC.Size = new System.Drawing.Size(90, 23);
            this.btn_filtrarC.TabIndex = 14;
            this.btn_filtrarC.Text = "Filtrar Cidade";
            this.btn_filtrarC.UseVisualStyleBackColor = true;
            this.btn_filtrarC.Click += new System.EventHandler(this.btn_filtrarC_Click);
            // 
            // txt_FiltraEstado
            // 
            this.txt_FiltraEstado.Location = new System.Drawing.Point(255, 244);
            this.txt_FiltraEstado.Name = "txt_FiltraEstado";
            this.txt_FiltraEstado.Size = new System.Drawing.Size(100, 20);
            this.txt_FiltraEstado.TabIndex = 15;
            // 
            // txt_FiltraCidade
            // 
            this.txt_FiltraCidade.Location = new System.Drawing.Point(255, 270);
            this.txt_FiltraCidade.Name = "txt_FiltraCidade";
            this.txt_FiltraCidade.Size = new System.Drawing.Size(100, 20);
            this.txt_FiltraCidade.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 508);
            this.Controls.Add(this.txt_FiltraCidade);
            this.Controls.Add(this.txt_FiltraEstado);
            this.Controls.Add(this.btn_filtrarC);
            this.Controls.Add(this.btn_filtrarE);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.lb_logradouro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.bt_CEP);
            this.Controls.Add(this.dgv_CEP);
            this.Controls.Add(this.lb_CEP);
            this.Controls.Add(this.txt_CEP);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.Label lb_CEP;
        private System.Windows.Forms.DataGridView dgv_CEP;
        private System.Windows.Forms.Button bt_CEP;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_logradouro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_filtrarE;
        private System.Windows.Forms.Button btn_filtrarC;
        private System.Windows.Forms.TextBox txt_FiltraEstado;
        private System.Windows.Forms.TextBox txt_FiltraCidade;
    }
}

