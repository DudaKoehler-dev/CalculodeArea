namespace FRM1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btn_Calcular2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volta2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor da Base";
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(109, 10);
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(100, 20);
            this.txt_base.TabIndex = 0;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(109, 52);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 1;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(109, 98);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // btn_fechar
            // 
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(175, 172);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Limpar
            // 
            this.Limpar.FlatAppearance.BorderSize = 0;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Image = ((System.Drawing.Image)(resources.GetObject("Limpar.Image")));
            this.Limpar.Location = new System.Drawing.Point(94, 171);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 5;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // btn_Calcular2
            // 
            this.btn_Calcular2.FlatAppearance.BorderSize = 0;
            this.btn_Calcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calcular2.Image")));
            this.btn_Calcular2.Location = new System.Drawing.Point(13, 171);
            this.btn_Calcular2.Name = "btn_Calcular2";
            this.btn_Calcular2.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular2.TabIndex = 4;
            this.btn_Calcular2.Text = "Calcular";
            this.btn_Calcular2.UseVisualStyleBackColor = true;
            this.btn_Calcular2.Click += new System.EventHandler(this.btn_Calcular2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volta2
            // 
            this.btn_volta2.FlatAppearance.BorderSize = 0;
            this.btn_volta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volta2.Image = ((System.Drawing.Image)(resources.GetObject("btn_volta2.Image")));
            this.btn_volta2.Location = new System.Drawing.Point(462, 172);
            this.btn_volta2.Name = "btn_volta2";
            this.btn_volta2.Size = new System.Drawing.Size(76, 24);
            this.btn_volta2.TabIndex = 7;
            this.btn_volta2.Text = "Voltar ";
            this.btn_volta2.UseVisualStyleBackColor = true;
            this.btn_volta2.Click += new System.EventHandler(this.btn_volta2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.btn_Calcular2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volta2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Calcular2;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btn_fechar;
    }
}