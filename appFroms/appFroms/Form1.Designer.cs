namespace appFroms
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(61, 135);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(108, 38);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(222, 135);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 38);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(38, 26);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(60, 13);
            this.lbl_texto.TabIndex = 2;
            this.lbl_texto.Text = "Bienvenido";
            this.lbl_texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(125, 23);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(146, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 203);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}

