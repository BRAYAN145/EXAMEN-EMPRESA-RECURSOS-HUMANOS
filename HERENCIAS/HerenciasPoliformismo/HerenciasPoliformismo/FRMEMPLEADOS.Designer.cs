
namespace HerenciasPoliformismo
{
    partial class FRMEMPLEADOS
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
            this.GboEmpleados = new System.Windows.Forms.GroupBox();
            this.DGVEMPLEADOS = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CboTipoContrato = new System.Windows.Forms.ComboBox();
            this.CboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.TxtNumSegSoc = new System.Windows.Forms.TextBox();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblTipoContrato = new System.Windows.Forms.Label();
            this.LblTipoEmpleado = new System.Windows.Forms.Label();
            this.LblNumSegSoc = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.GboEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GboEmpleados
            // 
            this.GboEmpleados.Controls.Add(this.TxtCedula);
            this.GboEmpleados.Controls.Add(this.LblCedula);
            this.GboEmpleados.Controls.Add(this.DGVEMPLEADOS);
            this.GboEmpleados.Controls.Add(this.BtnGuardar);
            this.GboEmpleados.Controls.Add(this.CboTipoContrato);
            this.GboEmpleados.Controls.Add(this.CboTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.CboSexo);
            this.GboEmpleados.Controls.Add(this.TxtNumSegSoc);
            this.GboEmpleados.Controls.Add(this.TxtApMaterno);
            this.GboEmpleados.Controls.Add(this.TxtApPaterno);
            this.GboEmpleados.Controls.Add(this.TxtNombres);
            this.GboEmpleados.Controls.Add(this.LblTipoContrato);
            this.GboEmpleados.Controls.Add(this.LblTipoEmpleado);
            this.GboEmpleados.Controls.Add(this.LblNumSegSoc);
            this.GboEmpleados.Controls.Add(this.LblSexo);
            this.GboEmpleados.Controls.Add(this.LblNombres);
            this.GboEmpleados.Controls.Add(this.LblApMaterno);
            this.GboEmpleados.Controls.Add(this.LblApPaterno);
            this.GboEmpleados.Location = new System.Drawing.Point(12, 12);
            this.GboEmpleados.Name = "GboEmpleados";
            this.GboEmpleados.Size = new System.Drawing.Size(953, 325);
            this.GboEmpleados.TabIndex = 0;
            this.GboEmpleados.TabStop = false;
            this.GboEmpleados.Text = "Empleados";
            // 
            // DGVEMPLEADOS
            // 
            this.DGVEMPLEADOS.AllowUserToAddRows = false;
            this.DGVEMPLEADOS.AllowUserToOrderColumns = true;
            this.DGVEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.SEXO,
            this.NUMSEGSOC,
            this.TIPOEMPLEADO,
            this.TIPOCONTRATO,
            this.SUELDO,
            this.CEDULA});
            this.DGVEMPLEADOS.Location = new System.Drawing.Point(9, 182);
            this.DGVEMPLEADOS.Name = "DGVEMPLEADOS";
            this.DGVEMPLEADOS.Size = new System.Drawing.Size(940, 137);
            this.DGVEMPLEADOS.TabIndex = 15;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
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
            // 
            // TIPOEMPLEADO
            // 
            this.TIPOEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPOEMPLEADO.Name = "TIPOEMPLEADO";
            // 
            // TIPOCONTRATO
            // 
            this.TIPOCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPOCONTRATO.Name = "TIPOCONTRATO";
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.Name = "SUELDO";
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(702, 60);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 55);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CboTipoContrato
            // 
            this.CboTipoContrato.FormattingEnabled = true;
            this.CboTipoContrato.Items.AddRange(new object[] {
            "NUEVO",
            "LOGEVO"});
            this.CboTipoContrato.Location = new System.Drawing.Point(387, 134);
            this.CboTipoContrato.Name = "CboTipoContrato";
            this.CboTipoContrato.Size = new System.Drawing.Size(149, 21);
            this.CboTipoContrato.TabIndex = 13;
            this.CboTipoContrato.Text = "NUEVO";
            // 
            // CboTipoEmpleado
            // 
            this.CboTipoEmpleado.FormattingEnabled = true;
            this.CboTipoEmpleado.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR"});
            this.CboTipoEmpleado.Location = new System.Drawing.Point(210, 134);
            this.CboTipoEmpleado.Name = "CboTipoEmpleado";
            this.CboTipoEmpleado.Size = new System.Drawing.Size(149, 21);
            this.CboTipoEmpleado.TabIndex = 12;
            this.CboTipoEmpleado.Text = "VENDEDOR";
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CboSexo.Location = new System.Drawing.Point(563, 60);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(121, 21);
            this.CboSexo.TabIndex = 11;
            this.CboSexo.Text = "FEMENINO";
            // 
            // TxtNumSegSoc
            // 
            this.TxtNumSegSoc.Location = new System.Drawing.Point(6, 135);
            this.TxtNumSegSoc.Name = "TxtNumSegSoc";
            this.TxtNumSegSoc.Size = new System.Drawing.Size(184, 20);
            this.TxtNumSegSoc.TabIndex = 10;
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(183, 60);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(147, 20);
            this.TxtApMaterno.TabIndex = 9;
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(6, 60);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(147, 20);
            this.TxtApPaterno.TabIndex = 8;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(353, 60);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(183, 20);
            this.TxtNombres.TabIndex = 7;
            // 
            // LblTipoContrato
            // 
            this.LblTipoContrato.AutoSize = true;
            this.LblTipoContrato.Location = new System.Drawing.Point(414, 103);
            this.LblTipoContrato.Name = "LblTipoContrato";
            this.LblTipoContrato.Size = new System.Drawing.Size(86, 13);
            this.LblTipoContrato.TabIndex = 6;
            this.LblTipoContrato.Text = "Tipo de Contrato";
            // 
            // LblTipoEmpleado
            // 
            this.LblTipoEmpleado.AutoSize = true;
            this.LblTipoEmpleado.Location = new System.Drawing.Point(237, 103);
            this.LblTipoEmpleado.Name = "LblTipoEmpleado";
            this.LblTipoEmpleado.Size = new System.Drawing.Size(93, 13);
            this.LblTipoEmpleado.TabIndex = 5;
            this.LblTipoEmpleado.Text = "Tipo de Empleado";
            this.LblTipoEmpleado.Click += new System.EventHandler(this.LblTipoEmpleado_Click);
            // 
            // LblNumSegSoc
            // 
            this.LblNumSegSoc.AutoSize = true;
            this.LblNumSegSoc.Location = new System.Drawing.Point(3, 103);
            this.LblNumSegSoc.Name = "LblNumSegSoc";
            this.LblNumSegSoc.Size = new System.Drawing.Size(138, 13);
            this.LblNumSegSoc.TabIndex = 4;
            this.LblNumSegSoc.Text = "Numero de seguridad social";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(592, 35);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 3;
            this.LblSexo.Text = "Sexo";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(414, 35);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(49, 13);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(207, 35);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(89, 13);
            this.LblApMaterno.TabIndex = 1;
            this.LblApMaterno.Text = "Apellido  Materno";
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(6, 35);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(86, 13);
            this.LblApPaterno.TabIndex = 0;
            this.LblApPaterno.Text = "Apellido  paterno";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(607, 103);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(40, 13);
            this.LblCedula.TabIndex = 16;
            this.LblCedula.Text = "Cedula";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(563, 134);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(155, 20);
            this.TxtCedula.TabIndex = 17;
            // 
            // FRMEMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 343);
            this.Controls.Add(this.GboEmpleados);
            this.Name = "FRMEMPLEADOS";
            this.Text = "FRMEMPLEADOS";
            this.GboEmpleados.ResumeLayout(false);
            this.GboEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboEmpleados;
        private System.Windows.Forms.ComboBox CboTipoEmpleado;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.TextBox TxtNumSegSoc;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblTipoContrato;
        private System.Windows.Forms.Label LblTipoEmpleado;
        private System.Windows.Forms.Label LblNumSegSoc;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApMaterno;
        private System.Windows.Forms.Label LblApPaterno;
        private System.Windows.Forms.ComboBox CboTipoContrato;
        private System.Windows.Forms.DataGridView DGVEMPLEADOS;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblCedula;
    }
}