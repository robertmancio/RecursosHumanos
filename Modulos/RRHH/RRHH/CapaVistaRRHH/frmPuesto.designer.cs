
namespace CapaVista
{
    partial class frmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuesto));
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrestacionLaboral = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoSup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(424, 136);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.ReadOnly = true;
            this.dvgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgConsulta.Size = new System.Drawing.Size(715, 325);
            this.dvgConsulta.TabIndex = 37;
            this.dvgConsulta.SelectionChanged += new System.EventHandler(this.dgvImpuesto_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Puesto:";
            // 
            // lblPrestacionLaboral
            // 
            this.lblPrestacionLaboral.AutoSize = true;
            this.lblPrestacionLaboral.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestacionLaboral.Location = new System.Drawing.Point(59, 227);
            this.lblPrestacionLaboral.Name = "lblPrestacionLaboral";
            this.lblPrestacionLaboral.Size = new System.Drawing.Size(47, 13);
            this.lblPrestacionLaboral.TabIndex = 31;
            this.lblPrestacionLaboral.Text = "Nombre:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(59, 174);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(43, 13);
            this.lblempleado.TabIndex = 30;
            this.lblempleado.Text = "Puesto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(206, 227);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.Tag = "nombre";
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Location = new System.Drawing.Point(206, 278);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(121, 20);
            this.txtExperiencia.TabIndex = 41;
            this.txtExperiencia.Tag = "añosDeExperiencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Años de Experiencia:";
            // 
            // txtPuestoSup
            // 
            this.txtPuestoSup.Location = new System.Drawing.Point(206, 323);
            this.txtPuestoSup.Name = "txtPuestoSup";
            this.txtPuestoSup.Size = new System.Drawing.Size(121, 20);
            this.txtPuestoSup.TabIndex = 43;
            this.txtPuestoSup.Tag = "fkIdPuestoSuperior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Puesto superior:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(206, 171);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(121, 20);
            this.txtPuesto.TabIndex = 44;
            this.txtPuesto.Tag = "pkIdPuesto";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, 1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 45;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(96, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(316, 423);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 49;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1188, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrestacionLaboral);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPuestoSup);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.navegador1);
            this.Name = "frmPuesto";
            this.Text = "5003 Puesto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrestacionLaboral;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuestoSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuesto;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstado;
    }
}