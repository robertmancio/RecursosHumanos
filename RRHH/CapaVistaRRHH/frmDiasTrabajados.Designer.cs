
namespace CapaVista
{
    partial class frmDiasTrabajados
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
            this.dgvDiasTrabajados = new System.Windows.Forms.DataGridView();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFebrero = new System.Windows.Forms.TextBox();
            this.txtMarzo = new System.Windows.Forms.TextBox();
            this.txtAbril = new System.Windows.Forms.TextBox();
            this.txtMayo = new System.Windows.Forms.TextBox();
            this.txtJunio = new System.Windows.Forms.TextBox();
            this.txtDiciembre = new System.Windows.Forms.TextBox();
            this.txtNoviembre = new System.Windows.Forms.TextBox();
            this.txtOctubre = new System.Windows.Forms.TextBox();
            this.txtSeptiembre = new System.Windows.Forms.TextBox();
            this.txtAgosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJulio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalDias = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.txtIdDias = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasTrabajados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiasTrabajados
            // 
            this.dgvDiasTrabajados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasTrabajados.Location = new System.Drawing.Point(408, 162);
            this.dgvDiasTrabajados.Name = "dgvDiasTrabajados";
            this.dgvDiasTrabajados.Size = new System.Drawing.Size(725, 370);
            this.dgvDiasTrabajados.TabIndex = 37;
            this.dgvDiasTrabajados.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(122, 201);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 33;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dias Trabajados:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(57, 209);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(57, 13);
            this.lblempleado.TabIndex = 30;
            this.lblempleado.Text = "Empleado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(57, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Mayo:";
            // 
            // txtEnero
            // 
            this.txtEnero.Location = new System.Drawing.Point(122, 281);
            this.txtEnero.Name = "txtEnero";
            this.txtEnero.Size = new System.Drawing.Size(27, 20);
            this.txtEnero.TabIndex = 61;
            this.txtEnero.Tag = "enero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(57, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Abril:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(57, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Marzo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(57, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Febrero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(57, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Enero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Junio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(61, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Total Dias Trabajados:";
            // 
            // txtFebrero
            // 
            this.txtFebrero.Location = new System.Drawing.Point(122, 307);
            this.txtFebrero.Name = "txtFebrero";
            this.txtFebrero.Size = new System.Drawing.Size(27, 20);
            this.txtFebrero.TabIndex = 72;
            this.txtFebrero.Tag = "febrero";
            // 
            // txtMarzo
            // 
            this.txtMarzo.Location = new System.Drawing.Point(122, 333);
            this.txtMarzo.Name = "txtMarzo";
            this.txtMarzo.Size = new System.Drawing.Size(27, 20);
            this.txtMarzo.TabIndex = 73;
            this.txtMarzo.Tag = "marzo";
            // 
            // txtAbril
            // 
            this.txtAbril.Location = new System.Drawing.Point(122, 359);
            this.txtAbril.Name = "txtAbril";
            this.txtAbril.Size = new System.Drawing.Size(27, 20);
            this.txtAbril.TabIndex = 74;
            this.txtAbril.Tag = "abril";
            // 
            // txtMayo
            // 
            this.txtMayo.Location = new System.Drawing.Point(122, 385);
            this.txtMayo.Name = "txtMayo";
            this.txtMayo.Size = new System.Drawing.Size(27, 20);
            this.txtMayo.TabIndex = 75;
            this.txtMayo.Tag = "mayo";
            // 
            // txtJunio
            // 
            this.txtJunio.Location = new System.Drawing.Point(122, 411);
            this.txtJunio.Name = "txtJunio";
            this.txtJunio.Size = new System.Drawing.Size(27, 20);
            this.txtJunio.TabIndex = 76;
            this.txtJunio.Tag = "junio";
            // 
            // txtDiciembre
            // 
            this.txtDiciembre.Location = new System.Drawing.Point(278, 411);
            this.txtDiciembre.Name = "txtDiciembre";
            this.txtDiciembre.Size = new System.Drawing.Size(27, 20);
            this.txtDiciembre.TabIndex = 88;
            this.txtDiciembre.Tag = "diciembre";
            // 
            // txtNoviembre
            // 
            this.txtNoviembre.Location = new System.Drawing.Point(278, 385);
            this.txtNoviembre.Name = "txtNoviembre";
            this.txtNoviembre.Size = new System.Drawing.Size(27, 20);
            this.txtNoviembre.TabIndex = 87;
            this.txtNoviembre.Tag = "noviembre";
            // 
            // txtOctubre
            // 
            this.txtOctubre.Location = new System.Drawing.Point(278, 359);
            this.txtOctubre.Name = "txtOctubre";
            this.txtOctubre.Size = new System.Drawing.Size(27, 20);
            this.txtOctubre.TabIndex = 86;
            this.txtOctubre.Tag = "octubre";
            // 
            // txtSeptiembre
            // 
            this.txtSeptiembre.Location = new System.Drawing.Point(278, 333);
            this.txtSeptiembre.Name = "txtSeptiembre";
            this.txtSeptiembre.Size = new System.Drawing.Size(27, 20);
            this.txtSeptiembre.TabIndex = 85;
            this.txtSeptiembre.Tag = "septiembre";
            // 
            // txtAgosto
            // 
            this.txtAgosto.Location = new System.Drawing.Point(278, 307);
            this.txtAgosto.Name = "txtAgosto";
            this.txtAgosto.Size = new System.Drawing.Size(27, 20);
            this.txtAgosto.TabIndex = 84;
            this.txtAgosto.Tag = "agosto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(210, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Diciembre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(210, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Noviembre:";
            // 
            // txtJulio
            // 
            this.txtJulio.Location = new System.Drawing.Point(278, 281);
            this.txtJulio.Name = "txtJulio";
            this.txtJulio.Size = new System.Drawing.Size(27, 20);
            this.txtJulio.TabIndex = 81;
            this.txtJulio.Tag = "julio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(210, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Octubre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(210, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Septiembre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(210, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Agosto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(210, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Julio:";
            // 
            // txtTotalDias
            // 
            this.txtTotalDias.Location = new System.Drawing.Point(181, 462);
            this.txtTotalDias.Name = "txtTotalDias";
            this.txtTotalDias.Size = new System.Drawing.Size(39, 20);
            this.txtTotalDias.TabIndex = 89;
            this.txtTotalDias.Tag = "totalDiasTrabajados";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 90;
            // 
            // txtIdDias
            // 
            this.txtIdDias.Location = new System.Drawing.Point(122, 232);
            this.txtIdDias.Name = "txtIdDias";
            this.txtIdDias.Size = new System.Drawing.Size(49, 20);
            this.txtIdDias.TabIndex = 92;
            this.txtIdDias.Tag = "pkDiasTrabajados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(58, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "ID Dias:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(122, 255);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(49, 20);
            this.txtAño.TabIndex = 94;
            this.txtAño.Tag = "año";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(58, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 93;
            this.label16.Text = "Año:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(256, 201);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(49, 20);
            this.txtEmpleado.TabIndex = 95;
            this.txtEmpleado.Tag = "fkIdEmpleado";
            this.txtEmpleado.Visible = false;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(67, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 96;
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
            this.txtEstado.Location = new System.Drawing.Point(295, 547);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 97;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // frmDiasTrabajados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaRRHH.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1188, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtTotalDias);
            this.Controls.Add(this.txtDiciembre);
            this.Controls.Add(this.txtNoviembre);
            this.Controls.Add(this.txtOctubre);
            this.Controls.Add(this.txtSeptiembre);
            this.Controls.Add(this.txtAgosto);
            this.Controls.Add(this.txtJulio);
            this.Controls.Add(this.txtJunio);
            this.Controls.Add(this.txtMayo);
            this.Controls.Add(this.txtAbril);
            this.Controls.Add(this.txtMarzo);
            this.Controls.Add(this.txtFebrero);
            this.Controls.Add(this.txtEnero);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIdDias);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvDiasTrabajados);
            this.Name = "frmDiasTrabajados";
            this.Text = "5004 Dias Trabajados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasTrabajados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiasTrabajados;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFebrero;
        private System.Windows.Forms.TextBox txtMarzo;
        private System.Windows.Forms.TextBox txtAbril;
        private System.Windows.Forms.TextBox txtMayo;
        private System.Windows.Forms.TextBox txtJunio;
        private System.Windows.Forms.TextBox txtDiciembre;
        private System.Windows.Forms.TextBox txtNoviembre;
        private System.Windows.Forms.TextBox txtOctubre;
        private System.Windows.Forms.TextBox txtSeptiembre;
        private System.Windows.Forms.TextBox txtAgosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJulio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalDias;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtIdDias;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
    }
}