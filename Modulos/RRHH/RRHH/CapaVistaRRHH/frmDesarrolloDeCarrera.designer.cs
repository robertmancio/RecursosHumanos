
namespace CapaVista
{
    partial class frmDesarrolloDeCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesarrolloDeCarrera));
            this.dvgPrestacionesLaborales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrestacionLaboral = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtAspiracion = new System.Windows.Forms.TextBox();
            this.txtAusencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtDesarrollo = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestacionesLaborales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgPrestacionesLaborales
            // 
            this.dvgPrestacionesLaborales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPrestacionesLaborales.Location = new System.Drawing.Point(484, 153);
            this.dvgPrestacionesLaborales.Name = "dvgPrestacionesLaborales";
            this.dvgPrestacionesLaborales.ReadOnly = true;
            this.dvgPrestacionesLaborales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPrestacionesLaborales.Size = new System.Drawing.Size(659, 346);
            this.dvgPrestacionesLaborales.TabIndex = 37;
            this.dvgPrestacionesLaborales.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Aspiracion Sueldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Desarrollo de Carrera:";
            // 
            // lblPrestacionLaboral
            // 
            this.lblPrestacionLaboral.AutoSize = true;
            this.lblPrestacionLaboral.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestacionLaboral.Location = new System.Drawing.Point(90, 279);
            this.lblPrestacionLaboral.Name = "lblPrestacionLaboral";
            this.lblPrestacionLaboral.Size = new System.Drawing.Size(81, 13);
            this.lblPrestacionLaboral.TabIndex = 31;
            this.lblPrestacionLaboral.Text = "Observaciones:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(90, 235);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(69, 13);
            this.lblempleado.TabIndex = 30;
            this.lblempleado.Text = "Id Desarrollo:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(237, 276);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(121, 20);
            this.txtObservaciones.TabIndex = 38;
            this.txtObservaciones.Tag = "observaciones";
            // 
            // txtAspiracion
            // 
            this.txtAspiracion.Location = new System.Drawing.Point(237, 324);
            this.txtAspiracion.Name = "txtAspiracion";
            this.txtAspiracion.Size = new System.Drawing.Size(121, 20);
            this.txtAspiracion.TabIndex = 39;
            this.txtAspiracion.Tag = "aspiradorSueldo";
            // 
            // txtAusencias
            // 
            this.txtAusencias.Location = new System.Drawing.Point(237, 371);
            this.txtAusencias.Name = "txtAusencias";
            this.txtAusencias.Size = new System.Drawing.Size(121, 20);
            this.txtAusencias.TabIndex = 40;
            this.txtAusencias.Tag = "ausencias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(90, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ausencias:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 42;
            // 
            // txtDesarrollo
            // 
            this.txtDesarrollo.Location = new System.Drawing.Point(237, 232);
            this.txtDesarrollo.Name = "txtDesarrollo";
            this.txtDesarrollo.Size = new System.Drawing.Size(121, 20);
            this.txtDesarrollo.TabIndex = 43;
            this.txtDesarrollo.Tag = "pkIdDesarrolloDeCarrera";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(364, 188);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(45, 20);
            this.txtEmpleado.TabIndex = 46;
            this.txtEmpleado.Tag = "fkIdEmpleado";
            this.txtEmpleado.Visible = false;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(237, 188);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 45;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Empleado:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(106, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(23, 29);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 46;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(23, 62);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 47;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(326, 455);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 51;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // frmDesarrolloDeCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1189, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrestacionLaboral);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtAusencias);
            this.Controls.Add(this.txtAspiracion);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDesarrollo);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dvgPrestacionesLaborales);
            this.Name = "frmDesarrolloDeCarrera";
            this.Text = "5006 Desarrollo de Carrera";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestacionesLaborales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPrestacionesLaborales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrestacionLaboral;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtAspiracion;
        private System.Windows.Forms.TextBox txtAusencias;
        private System.Windows.Forms.Label label3;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtDesarrollo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
    }
}