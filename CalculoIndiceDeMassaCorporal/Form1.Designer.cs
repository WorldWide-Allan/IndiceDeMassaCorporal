namespace CalculoIndiceDeMassaCorporal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_centimetros = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.btt_limpar = new System.Windows.Forms.Button();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.lbl_04 = new System.Windows.Forms.Label();
            this.lbl_05 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Massa Corporal";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(86, 80);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(127, 20);
            this.lbl_peso.TabIndex = 1;
            this.lbl_peso.Text = "Digite seu peso: ";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(86, 143);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(132, 20);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "Digite sua altura: ";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(219, 77);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(46, 26);
            this.txt_peso.TabIndex = 3;
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(271, 80);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(53, 20);
            this.lbl_kg.TabIndex = 4;
            this.lbl_kg.Text = "Quilos";
            // 
            // lbl_centimetros
            // 
            this.lbl_centimetros.AutoSize = true;
            this.lbl_centimetros.Location = new System.Drawing.Point(271, 140);
            this.lbl_centimetros.Name = "lbl_centimetros";
            this.lbl_centimetros.Size = new System.Drawing.Size(161, 20);
            this.lbl_centimetros.TabIndex = 6;
            this.lbl_centimetros.Text = "Metros e Centímetros";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(219, 137);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(46, 26);
            this.txt_altura.TabIndex = 5;
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(107, 203);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(82, 31);
            this.btt_calcular.TabIndex = 7;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // btt_limpar
            // 
            this.btt_limpar.Location = new System.Drawing.Point(207, 203);
            this.btt_limpar.Name = "btt_limpar";
            this.btt_limpar.Size = new System.Drawing.Size(82, 31);
            this.btt_limpar.TabIndex = 8;
            this.btt_limpar.Text = "Limpar";
            this.btt_limpar.UseVisualStyleBackColor = true;
            this.btt_limpar.Click += new System.EventHandler(this.btt_limpar_Click);
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(14, 33);
            this.lbl_01.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_01.Size = new System.Drawing.Size(279, 26);
            this.lbl_01.TabIndex = 9;
            this.lbl_01.Text = "Abaixo de 18.5 - Abaixo do peso ideal";
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Location = new System.Drawing.Point(13, 58);
            this.lbl_02.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_02.Size = new System.Drawing.Size(210, 26);
            this.lbl_02.TabIndex = 10;
            this.lbl_02.Text = "Entre 18.5 e 25 - Peso ideal";
            // 
            // lbl_03
            // 
            this.lbl_03.AutoSize = true;
            this.lbl_03.Location = new System.Drawing.Point(14, 79);
            this.lbl_03.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_03.Size = new System.Drawing.Size(202, 26);
            this.lbl_03.TabIndex = 11;
            this.lbl_03.Text = "Entre 25 e 30 - Sobrepeso";
            // 
            // lbl_04
            // 
            this.lbl_04.AutoSize = true;
            this.lbl_04.Location = new System.Drawing.Point(14, 104);
            this.lbl_04.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_04.Name = "lbl_04";
            this.lbl_04.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_04.Size = new System.Drawing.Size(171, 26);
            this.lbl_04.TabIndex = 12;
            this.lbl_04.Text = "Entre 30 e 40 - Obeso";
            // 
            // lbl_05
            // 
            this.lbl_05.AutoSize = true;
            this.lbl_05.Location = new System.Drawing.Point(14, 125);
            this.lbl_05.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_05.Name = "lbl_05";
            this.lbl_05.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_05.Size = new System.Drawing.Size(254, 26);
            this.lbl_05.TabIndex = 13;
            this.lbl_05.Text = "Acima de 40 - Obesidade mórbida";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(86, 261);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(21, 20);
            this.lbl_resultado.TabIndex = 14;
            this.lbl_resultado.Text = "   ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_01);
            this.groupBox1.Controls.Add(this.lbl_02);
            this.groupBox1.Controls.Add(this.lbl_05);
            this.groupBox1.Controls.Add(this.lbl_03);
            this.groupBox1.Controls.Add(this.lbl_04);
            this.groupBox1.Location = new System.Drawing.Point(468, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btt_limpar);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.lbl_centimetros);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.Label lbl_centimetros;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Button btt_calcular;
        private System.Windows.Forms.Button btt_limpar;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.Label lbl_04;
        private System.Windows.Forms.Label lbl_05;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

