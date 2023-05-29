namespace FormsCPF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.pan_titulo = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.lb_peso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboB_sexo = new System.Windows.Forms.ComboBox();
            this.lb_resultado1 = new System.Windows.Forms.Label();
            this.lb_resultado2 = new System.Windows.Forms.Label();
            this.lb_resultado3 = new System.Windows.Forms.Label();
            this.tx_peso = new System.Windows.Forms.TextBox();
            this.tx_altura = new System.Windows.Forms.TextBox();
            this.lb_veriCpf = new System.Windows.Forms.Label();
            this.pan_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_nome.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(50, 150);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(58, 20);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_cpf.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(361, 255);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(43, 20);
            this.lb_cpf.TabIndex = 1;
            this.lb_cpf.Text = "CPF";
            this.lb_cpf.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_altura.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_altura.Location = new System.Drawing.Point(53, 254);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(60, 20);
            this.lb_altura.TabIndex = 2;
            this.lb_altura.Text = "Altura";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_sexo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(359, 150);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(49, 20);
            this.lb_sexo.TabIndex = 3;
            this.lb_sexo.Text = "Sexo";
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_idade.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(361, 204);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(57, 20);
            this.lb_idade.TabIndex = 4;
            this.lb_idade.Text = "Idade";
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_nome.Location = new System.Drawing.Point(132, 150);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(195, 22);
            this.tx_nome.TabIndex = 5;
            this.tx_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tx_idade
            // 
            this.tx_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_idade.Location = new System.Drawing.Point(437, 204);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(126, 22);
            this.tx_idade.TabIndex = 6;
            this.tx_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mask_cpf
            // 
            this.mask_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_cpf.Location = new System.Drawing.Point(446, 255);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(117, 22);
            this.mask_cpf.TabIndex = 9;
            this.mask_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pan_titulo
            // 
            this.pan_titulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pan_titulo.Controls.Add(this.lb_titulo);
            this.pan_titulo.Location = new System.Drawing.Point(3, 1);
            this.pan_titulo.Name = "pan_titulo";
            this.pan_titulo.Size = new System.Drawing.Size(728, 119);
            this.pan_titulo.TabIndex = 10;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lb_titulo.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(257, 34);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(178, 39);
            this.lb_titulo.TabIndex = 11;
            this.lb_titulo.Text = "Calcúlo de IMC";
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_Cancelar.Location = new System.Drawing.Point(104, 420);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(110, 42);
            this.bt_Cancelar.TabIndex = 11;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_Calcular.Location = new System.Drawing.Point(342, 420);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(110, 42);
            this.bt_Calcular.TabIndex = 12;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = false;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lb_peso.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(53, 206);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(47, 20);
            this.lb_peso.TabIndex = 13;
            this.lb_peso.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Rockwell", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "*Em metros";
            // 
            // comboB_sexo
            // 
            this.comboB_sexo.FormattingEnabled = true;
            this.comboB_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Maculino",
            "Helicoptero de combate",
            "ecologico"});
            this.comboB_sexo.Location = new System.Drawing.Point(437, 150);
            this.comboB_sexo.Name = "comboB_sexo";
            this.comboB_sexo.Size = new System.Drawing.Size(213, 24);
            this.comboB_sexo.TabIndex = 16;
            // 
            // lb_resultado1
            // 
            this.lb_resultado1.AutoSize = true;
            this.lb_resultado1.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_resultado1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado1.Location = new System.Drawing.Point(12, 324);
            this.lb_resultado1.Name = "lb_resultado1";
            this.lb_resultado1.Size = new System.Drawing.Size(0, 17);
            this.lb_resultado1.TabIndex = 19;
            // 
            // lb_resultado2
            // 
            this.lb_resultado2.AutoSize = true;
            this.lb_resultado2.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_resultado2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado2.Location = new System.Drawing.Point(224, 324);
            this.lb_resultado2.Name = "lb_resultado2";
            this.lb_resultado2.Size = new System.Drawing.Size(0, 17);
            this.lb_resultado2.TabIndex = 20;
            // 
            // lb_resultado3
            // 
            this.lb_resultado3.AutoSize = true;
            this.lb_resultado3.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_resultado3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado3.Location = new System.Drawing.Point(12, 386);
            this.lb_resultado3.Name = "lb_resultado3";
            this.lb_resultado3.Size = new System.Drawing.Size(0, 17);
            this.lb_resultado3.TabIndex = 21;
            // 
            // tx_peso
            // 
            this.tx_peso.Location = new System.Drawing.Point(132, 204);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(100, 22);
            this.tx_peso.TabIndex = 23;
            // 
            // tx_altura
            // 
            this.tx_altura.Location = new System.Drawing.Point(132, 254);
            this.tx_altura.Name = "tx_altura";
            this.tx_altura.Size = new System.Drawing.Size(100, 22);
            this.tx_altura.TabIndex = 24;
            // 
            // lb_veriCpf
            // 
            this.lb_veriCpf.AutoSize = true;
            this.lb_veriCpf.BackColor = System.Drawing.Color.PeachPuff;
            this.lb_veriCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veriCpf.Location = new System.Drawing.Point(443, 287);
            this.lb_veriCpf.Name = "lb_veriCpf";
            this.lb_veriCpf.Size = new System.Drawing.Size(0, 17);
            this.lb_veriCpf.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(728, 498);
            this.Controls.Add(this.lb_veriCpf);
            this.Controls.Add(this.tx_altura);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.lb_resultado3);
            this.Controls.Add(this.lb_resultado2);
            this.Controls.Add(this.lb_resultado1);
            this.Controls.Add(this.comboB_sexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.pan_titulo);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Name = "Form1";
            this.Text = "IMC";
            this.pan_titulo.ResumeLayout(false);
            this.pan_titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Panel pan_titulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboB_sexo;
        private System.Windows.Forms.Label lb_resultado1;
        private System.Windows.Forms.Label lb_resultado2;
        private System.Windows.Forms.Label lb_resultado3;
        private System.Windows.Forms.TextBox tx_peso;
        private System.Windows.Forms.TextBox tx_altura;
        private System.Windows.Forms.Label lb_veriCpf;
    }
}

