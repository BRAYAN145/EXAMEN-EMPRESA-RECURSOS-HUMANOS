
namespace HerenciasPoliformismo
{
    partial class FRMCLIENTES
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
            this.GPBCliente = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCodigoPedido = new System.Windows.Forms.TextBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtNumsegsoc = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblNumsegsoc = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCliente
            // 
            this.GPBCliente.Controls.Add(this.TxtCedula);
            this.GPBCliente.Controls.Add(this.LblCedula);
            this.GPBCliente.Controls.Add(this.dataGridView1);
            this.GPBCliente.Controls.Add(this.BtnGuardar);
            this.GPBCliente.Controls.Add(this.TxtCodigoPedido);
            this.GPBCliente.Controls.Add(this.CmbCategoria);
            this.GPBCliente.Controls.Add(this.TxtNumsegsoc);
            this.GPBCliente.Controls.Add(this.CmbSexo);
            this.GPBCliente.Controls.Add(this.TxtNombres);
            this.GPBCliente.Controls.Add(this.TxtApMaterno);
            this.GPBCliente.Controls.Add(this.TxtApPaterno);
            this.GPBCliente.Controls.Add(this.LblCategoria);
            this.GPBCliente.Controls.Add(this.LblSexo);
            this.GPBCliente.Controls.Add(this.LblCodigoPedido);
            this.GPBCliente.Controls.Add(this.LblNumsegsoc);
            this.GPBCliente.Controls.Add(this.LblNombres);
            this.GPBCliente.Controls.Add(this.LblApMaterno);
            this.GPBCliente.Controls.Add(this.LblApPaterno);
            this.GPBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBCliente.Location = new System.Drawing.Point(4, 11);
            this.GPBCliente.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.GPBCliente.Name = "GPBCliente";
            this.GPBCliente.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.GPBCliente.Size = new System.Drawing.Size(993, 289);
            this.GPBCliente.TabIndex = 0;
            this.GPBCliente.TabStop = false;
            this.GPBCliente.Text = "Cliente";
            this.GPBCliente.Enter += new System.EventHandler(this.GPBCliente_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.CATEGORIA,
            this.CODIGOPEDIDO,
            this.CEDULA});
            this.dataGridView1.Location = new System.Drawing.Point(6, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(991, 298);
            this.dataGridView1.TabIndex = 15;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(652, 46);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(137, 77);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCodigoPedido
            // 
            this.TxtCodigoPedido.Location = new System.Drawing.Point(363, 122);
            this.TxtCodigoPedido.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TxtCodigoPedido.Name = "TxtCodigoPedido";
            this.TxtCodigoPedido.Size = new System.Drawing.Size(99, 20);
            this.TxtCodigoPedido.TabIndex = 14;
            this.TxtCodigoPedido.TextChanged += new System.EventHandler(this.TxtCodigoPedido_TextChanged);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CmbCategoria.Location = new System.Drawing.Point(194, 122);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(106, 21);
            this.CmbCategoria.TabIndex = 13;
            this.CmbCategoria.Text = "NUEVO";
            // 
            // TxtNumsegsoc
            // 
            this.TxtNumsegsoc.Location = new System.Drawing.Point(3, 123);
            this.TxtNumsegsoc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TxtNumsegsoc.Name = "TxtNumsegsoc";
            this.TxtNumsegsoc.Size = new System.Drawing.Size(160, 20);
            this.TxtNumsegsoc.TabIndex = 12;
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCOLINO ",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(433, 61);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(143, 21);
            this.CmbSexo.TabIndex = 11;
            this.CmbSexo.Text = "FEMENINO";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(267, 62);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(140, 20);
            this.TxtNombres.TabIndex = 10;
            this.TxtNombres.TextChanged += new System.EventHandler(this.TxtNombres_TextChanged);
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(112, 62);
            this.TxtApMaterno.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(143, 20);
            this.TxtApMaterno.TabIndex = 9;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(5, 62);
            this.TxtApPaterno.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(105, 20);
            this.TxtApPaterno.TabIndex = 8;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(216, 107);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 7;
            this.LblCategoria.Text = "Categoria";
            this.LblCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(482, 46);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 6;
            this.LblSexo.Text = "Sexo";
            this.LblSexo.Click += new System.EventHandler(this.LblSexo_Click);
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Location = new System.Drawing.Point(360, 107);
            this.LblCodigoPedido.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(92, 13);
            this.LblCodigoPedido.TabIndex = 5;
            this.LblCodigoPedido.Text = "Codigo del pedido";
            this.LblCodigoPedido.Click += new System.EventHandler(this.LblCodigoPedido_Click);
            // 
            // LblNumsegsoc
            // 
            this.LblNumsegsoc.AutoSize = true;
            this.LblNumsegsoc.Location = new System.Drawing.Point(3, 108);
            this.LblNumsegsoc.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblNumsegsoc.Name = "LblNumsegsoc";
            this.LblNumsegsoc.Size = new System.Drawing.Size(126, 13);
            this.LblNumsegsoc.TabIndex = 4;
            this.LblNumsegsoc.Text = "Numero del seguro social";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(301, 46);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(49, 13);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(138, 46);
            this.LblApMaterno.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(85, 13);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido materno";
            this.LblApMaterno.Click += new System.EventHandler(this.LblApMaterno_Click);
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(6, 46);
            this.LblApPaterno.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(83, 13);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido paterno";
            this.LblApPaterno.Click += new System.EventHandler(this.LblApPaterno_Click);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(515, 107);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(40, 13);
            this.LblCedula.TabIndex = 17;
            this.LblCedula.Text = "Cedula";
            this.LblCedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(485, 123);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(117, 20);
            this.TxtCedula.TabIndex = 18;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 125;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 125;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 125;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            // 
            // NUMSEGSOC
            // 
            this.NUMSEGSOC.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOC.Name = "NUMSEGSOC";
            this.NUMSEGSOC.Width = 150;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO DEL PEDIDO";
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 125;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(2F, 5F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 470);
            this.Controls.Add(this.GPBCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FRMCLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMCLIENTES_Load);
            this.GPBCliente.ResumeLayout(false);
            this.GPBCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCliente;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Label LblNumsegsoc;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.TextBox TxtCodigoPedido;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.TextBox TxtNumsegsoc;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
    }
}