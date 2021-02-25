
namespace HerenciasPoliformismo
{
    partial class FRMPORTADA
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
            this.GBONavegdor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEmpledo = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBONavegdor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBONavegdor
            // 
            this.GBONavegdor.BackColor = System.Drawing.Color.Gray;
            this.GBONavegdor.BackgroundImage = global::HerenciasPoliformismo.Properties.Resources.maxresdefault;
            this.GBONavegdor.Controls.Add(this.label4);
            this.GBONavegdor.Controls.Add(this.label3);
            this.GBONavegdor.Controls.Add(this.label2);
            this.GBONavegdor.Controls.Add(this.label1);
            this.GBONavegdor.Controls.Add(this.BtnSalir);
            this.GBONavegdor.Controls.Add(this.BtnEmpledo);
            this.GBONavegdor.Controls.Add(this.BtnCliente);
            this.GBONavegdor.Location = new System.Drawing.Point(12, 128);
            this.GBONavegdor.Name = "GBONavegdor";
            this.GBONavegdor.Size = new System.Drawing.Size(823, 368);
            this.GBONavegdor.TabIndex = 0;
            this.GBONavegdor.TabStop = false;
            this.GBONavegdor.Text = "Navegador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROGRAMACION VISUAL\r\n              NRC:4101\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXAMEN DE SEGUNDO PARCIAL";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Lime;
            this.BtnSalir.Location = new System.Drawing.Point(671, 315);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(146, 44);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEmpledo
            // 
            this.BtnEmpledo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEmpledo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpledo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEmpledo.Location = new System.Drawing.Point(295, 293);
            this.BtnEmpledo.Name = "BtnEmpledo";
            this.BtnEmpledo.Size = new System.Drawing.Size(166, 44);
            this.BtnEmpledo.TabIndex = 1;
            this.BtnEmpledo.Text = "Empleado";
            this.BtnEmpledo.UseVisualStyleBackColor = false;
            this.BtnEmpledo.Click += new System.EventHandler(this.BtnEmpledo_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCliente.Location = new System.Drawing.Point(325, 245);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(111, 42);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // button1
            // 
            this.button1.Image = global::HerenciasPoliformismo.Properties.Resources.descarga;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(538, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(501, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDOS Y NOMBRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(534, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 77);
            this.label4.TabIndex = 6;
            this.label4.Text = "CHICAIZA JEFFERSON\r\nDIAZ BRAYAN\r\nZAMBRANO ESTEFANIA ";
            // 
            // FRMPORTADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::HerenciasPoliformismo.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(847, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GBONavegdor);
            this.Name = "FRMPORTADA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PORTADA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GBONavegdor.ResumeLayout(false);
            this.GBONavegdor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBONavegdor;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEmpledo;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}