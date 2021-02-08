namespace AsyncAwait
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
            this.botoSequencial = new System.Windows.Forms.Button();
            this.botoAsync = new System.Windows.Forms.Button();
            this.Llista = new System.Windows.Forms.ListBox();
            this.llista2 = new System.Windows.Forms.ListBox();
            this.temps2 = new System.Windows.Forms.TextBox();
            this.temps1 = new System.Windows.Forms.TextBox();
            this.horaLocal = new System.Windows.Forms.Button();
            this.textHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botoSequencial
            // 
            this.botoSequencial.Location = new System.Drawing.Point(29, 30);
            this.botoSequencial.Name = "botoSequencial";
            this.botoSequencial.Size = new System.Drawing.Size(84, 36);
            this.botoSequencial.TabIndex = 0;
            this.botoSequencial.Text = "button1";
            this.botoSequencial.UseVisualStyleBackColor = true;
            this.botoSequencial.Click += new System.EventHandler(this.botoSequencial_click);
            // 
            // botoAsync
            // 
            this.botoAsync.Location = new System.Drawing.Point(657, 30);
            this.botoAsync.Name = "botoAsync";
            this.botoAsync.Size = new System.Drawing.Size(84, 36);
            this.botoAsync.TabIndex = 1;
            this.botoAsync.Text = "button2";
            this.botoAsync.UseVisualStyleBackColor = true;
            this.botoAsync.Click += new System.EventHandler(this.botoAsync_Click);
            // 
            // Llista
            // 
            this.Llista.FormattingEnabled = true;
            this.Llista.ItemHeight = 20;
            this.Llista.Location = new System.Drawing.Point(29, 85);
            this.Llista.Name = "Llista";
            this.Llista.Size = new System.Drawing.Size(270, 264);
            this.Llista.TabIndex = 2;
            // 
            // llista2
            // 
            this.llista2.FormattingEnabled = true;
            this.llista2.ItemHeight = 20;
            this.llista2.Location = new System.Drawing.Point(471, 85);
            this.llista2.Name = "llista2";
            this.llista2.Size = new System.Drawing.Size(270, 264);
            this.llista2.TabIndex = 3;
            // 
            // temps2
            // 
            this.temps2.Location = new System.Drawing.Point(471, 356);
            this.temps2.Name = "temps2";
            this.temps2.Size = new System.Drawing.Size(100, 26);
            this.temps2.TabIndex = 4;
            this.temps2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // temps1
            // 
            this.temps1.Location = new System.Drawing.Point(29, 356);
            this.temps1.Name = "temps1";
            this.temps1.Size = new System.Drawing.Size(100, 26);
            this.temps1.TabIndex = 5;
            // 
            // horaLocal
            // 
            this.horaLocal.Location = new System.Drawing.Point(215, 410);
            this.horaLocal.Name = "horaLocal";
            this.horaLocal.Size = new System.Drawing.Size(84, 36);
            this.horaLocal.TabIndex = 6;
            this.horaLocal.Text = "button3";
            this.horaLocal.UseVisualStyleBackColor = true;
            this.horaLocal.Click += new System.EventHandler(this.horaLocal_Click);
            // 
            // textHora
            // 
            this.textHora.Location = new System.Drawing.Point(305, 415);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(198, 26);
            this.textHora.TabIndex = 7;
            this.textHora.TextChanged += new System.EventHandler(this.textHora_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 483);
            this.Controls.Add(this.textHora);
            this.Controls.Add(this.horaLocal);
            this.Controls.Add(this.temps1);
            this.Controls.Add(this.temps2);
            this.Controls.Add(this.llista2);
            this.Controls.Add(this.Llista);
            this.Controls.Add(this.botoAsync);
            this.Controls.Add(this.botoSequencial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoSequencial;
        private System.Windows.Forms.Button botoAsync;
        private System.Windows.Forms.ListBox Llista;
        private System.Windows.Forms.ListBox llista2;
        private System.Windows.Forms.TextBox temps2;
        private System.Windows.Forms.TextBox temps1;
        private System.Windows.Forms.Button horaLocal;
        private System.Windows.Forms.TextBox textHora;
    }
}

