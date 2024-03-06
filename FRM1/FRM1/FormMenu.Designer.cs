namespace FRM1
{
    partial class FRMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMenu));
            this.lbl_calculodearea = new System.Windows.Forms.Label();
            this.Trapezio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_retangulo = new System.Windows.Forms.Button();
            this.btn_quadrado = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculoDeAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapézioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_calculodearea
            // 
            this.lbl_calculodearea.AutoSize = true;
            this.lbl_calculodearea.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculodearea.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_calculodearea.Location = new System.Drawing.Point(49, 57);
            this.lbl_calculodearea.Name = "lbl_calculodearea";
            this.lbl_calculodearea.Size = new System.Drawing.Size(258, 40);
            this.lbl_calculodearea.TabIndex = 0;
            this.lbl_calculodearea.Text = "Cálculo de Área";
            // 
            // Trapezio
            // 
            this.Trapezio.FlatAppearance.BorderSize = 0;
            this.Trapezio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trapezio.Image = ((System.Drawing.Image)(resources.GetObject("Trapezio.Image")));
            this.Trapezio.Location = new System.Drawing.Point(190, 196);
            this.Trapezio.Name = "Trapezio";
            this.Trapezio.Size = new System.Drawing.Size(172, 50);
            this.Trapezio.TabIndex = 4;
            this.Trapezio.Text = "Trapézio";
            this.Trapezio.UseVisualStyleBackColor = true;
            this.Trapezio.Click += new System.EventHandler(this.Trapezio_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(190, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Triângulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_retangulo
            // 
            this.btn_retangulo.FlatAppearance.BorderSize = 0;
            this.btn_retangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retangulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_retangulo.Image = ((System.Drawing.Image)(resources.GetObject("btn_retangulo.Image")));
            this.btn_retangulo.Location = new System.Drawing.Point(12, 196);
            this.btn_retangulo.Name = "btn_retangulo";
            this.btn_retangulo.Size = new System.Drawing.Size(172, 50);
            this.btn_retangulo.TabIndex = 2;
            this.btn_retangulo.Text = "Retângulo";
            this.btn_retangulo.UseVisualStyleBackColor = true;
            this.btn_retangulo.Click += new System.EventHandler(this.btn_retangulo_Click);
            // 
            // btn_quadrado
            // 
            this.btn_quadrado.FlatAppearance.BorderSize = 0;
            this.btn_quadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quadrado.ForeColor = System.Drawing.Color.Black;
            this.btn_quadrado.Image = ((System.Drawing.Image)(resources.GetObject("btn_quadrado.Image")));
            this.btn_quadrado.Location = new System.Drawing.Point(12, 127);
            this.btn_quadrado.Name = "btn_quadrado";
            this.btn_quadrado.Size = new System.Drawing.Size(172, 49);
            this.btn_quadrado.TabIndex = 1;
            this.btn_quadrado.Text = "Quadrado";
            this.btn_quadrado.UseVisualStyleBackColor = true;
            this.btn_quadrado.Click += new System.EventHandler(this.btn_quadrado_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeAreasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculoDeAreasToolStripMenuItem
            // 
            this.calculoDeAreasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadradoToolStripMenuItem1,
            this.retânguloToolStripMenuItem,
            this.triânguloToolStripMenuItem,
            this.trapézioToolStripMenuItem});
            this.calculoDeAreasToolStripMenuItem.Name = "calculoDeAreasToolStripMenuItem";
            this.calculoDeAreasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.calculoDeAreasToolStripMenuItem.Text = "Cálculo de Áreas";
            this.calculoDeAreasToolStripMenuItem.Click += new System.EventHandler(this.calculoDeAreasToolStripMenuItem_Click);
            // 
            // quadradoToolStripMenuItem1
            // 
            this.quadradoToolStripMenuItem1.Name = "quadradoToolStripMenuItem1";
            this.quadradoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quadradoToolStripMenuItem1.Text = "Quadrado";
            // 
            // retânguloToolStripMenuItem
            // 
            this.retânguloToolStripMenuItem.Name = "retânguloToolStripMenuItem";
            this.retânguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retânguloToolStripMenuItem.Text = "Retângulo";
            // 
            // triânguloToolStripMenuItem
            // 
            this.triânguloToolStripMenuItem.Name = "triânguloToolStripMenuItem";
            this.triânguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triânguloToolStripMenuItem.Text = "Triângulo";
            // 
            // trapézioToolStripMenuItem
            // 
            this.trapézioToolStripMenuItem.Name = "trapézioToolStripMenuItem";
            this.trapézioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trapézioToolStripMenuItem.Text = "Trapézio";
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(379, 294);
            this.Controls.Add(this.Trapezio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_retangulo);
            this.Controls.Add(this.btn_quadrado);
            this.Controls.Add(this.lbl_calculodearea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMMenu";
            this.Text = "Cálculo de Área";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_calculodearea;
        private System.Windows.Forms.Button btn_quadrado;
        private System.Windows.Forms.Button btn_retangulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Trapezio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculoDeAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retânguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapézioToolStripMenuItem;
    }
}