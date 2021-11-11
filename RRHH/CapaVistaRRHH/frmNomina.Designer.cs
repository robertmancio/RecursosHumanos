
namespace CapaVista
{
    partial class frmNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHorasOrdinarias = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHorasExtraordinarias = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSalarioExtraordinario = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSalarioOrdinario = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIGSS = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDeduccionTotal = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.dgvNominaEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCalcularNomina = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSueldoNomina = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmpleadoNomina = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCodigoEmpleadoNomina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMesCalcular = new System.Windows.Forms.ComboBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtValidaciones = new System.Windows.Forms.Label();
            this.btnGuardarMes = new System.Windows.Forms.Button();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Salario Total";
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(630, 610);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.ReadOnly = true;
            this.txtSalarioTotal.Size = new System.Drawing.Size(106, 20);
            this.txtSalarioTotal.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(339, 504);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 18);
            this.label18.TabIndex = 42;
            this.label18.Text = "Horas Laboradas";
            // 
            // txtHorasOrdinarias
            // 
            this.txtHorasOrdinarias.Location = new System.Drawing.Point(292, 546);
            this.txtHorasOrdinarias.Name = "txtHorasOrdinarias";
            this.txtHorasOrdinarias.ReadOnly = true;
            this.txtHorasOrdinarias.Size = new System.Drawing.Size(107, 20);
            this.txtHorasOrdinarias.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(292, 525);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 18);
            this.label19.TabIndex = 43;
            this.label19.Text = "Ordinarias";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(416, 525);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 18);
            this.label20.TabIndex = 45;
            this.label20.Text = "Extraordinarias";
            // 
            // txtHorasExtraordinarias
            // 
            this.txtHorasExtraordinarias.Location = new System.Drawing.Point(416, 546);
            this.txtHorasExtraordinarias.Name = "txtHorasExtraordinarias";
            this.txtHorasExtraordinarias.Size = new System.Drawing.Size(107, 20);
            this.txtHorasExtraordinarias.TabIndex = 44;
            this.txtHorasExtraordinarias.TextChanged += new System.EventHandler(this.txtHorasExtraordinarias_TextChanged);
            this.txtHorasExtraordinarias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasExtraordinarias_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(599, 501);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 18);
            this.label21.TabIndex = 46;
            this.label21.Text = "Salario Devengado";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(678, 526);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 18);
            this.label22.TabIndex = 50;
            this.label22.Text = "Extraordinario";
            // 
            // txtSalarioExtraordinario
            // 
            this.txtSalarioExtraordinario.Location = new System.Drawing.Point(678, 547);
            this.txtSalarioExtraordinario.Name = "txtSalarioExtraordinario";
            this.txtSalarioExtraordinario.ReadOnly = true;
            this.txtSalarioExtraordinario.Size = new System.Drawing.Size(107, 20);
            this.txtSalarioExtraordinario.TabIndex = 49;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(554, 526);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 18);
            this.label23.TabIndex = 48;
            this.label23.Text = "Ordinario";
            // 
            // txtSalarioOrdinario
            // 
            this.txtSalarioOrdinario.Location = new System.Drawing.Point(554, 547);
            this.txtSalarioOrdinario.Name = "txtSalarioOrdinario";
            this.txtSalarioOrdinario.ReadOnly = true;
            this.txtSalarioOrdinario.Size = new System.Drawing.Size(107, 20);
            this.txtSalarioOrdinario.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(972, 451);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 18);
            this.label24.TabIndex = 55;
            this.label24.Text = "ISR";
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(972, 472);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(107, 20);
            this.txtISR.TabIndex = 54;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(851, 451);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 18);
            this.label25.TabIndex = 53;
            this.label25.Text = "IGSS";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(881, 430);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(169, 18);
            this.label26.TabIndex = 52;
            this.label26.Text = "Deducciones Legales";
            // 
            // txtIGSS
            // 
            this.txtIGSS.Location = new System.Drawing.Point(851, 472);
            this.txtIGSS.Name = "txtIGSS";
            this.txtIGSS.ReadOnly = true;
            this.txtIGSS.Size = new System.Drawing.Size(107, 20);
            this.txtIGSS.TabIndex = 51;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(902, 506);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 18);
            this.label27.TabIndex = 57;
            this.label27.Text = "Deducciones Total";
            // 
            // txtDeduccionTotal
            // 
            this.txtDeduccionTotal.Location = new System.Drawing.Point(915, 530);
            this.txtDeduccionTotal.Name = "txtDeduccionTotal";
            this.txtDeduccionTotal.ReadOnly = true;
            this.txtDeduccionTotal.Size = new System.Drawing.Size(106, 20);
            this.txtDeduccionTotal.TabIndex = 56;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(916, 579);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 18);
            this.label28.TabIndex = 59;
            this.label28.Text = "Salario Líquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(916, 603);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(106, 20);
            this.txtSalarioLiquido.TabIndex = 58;
            // 
            // dgvNominaEmpleados
            // 
            this.dgvNominaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominaEmpleados.Location = new System.Drawing.Point(321, 118);
            this.dgvNominaEmpleados.MultiSelect = false;
            this.dgvNominaEmpleados.Name = "dgvNominaEmpleados";
            this.dgvNominaEmpleados.ReadOnly = true;
            this.dgvNominaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNominaEmpleados.Size = new System.Drawing.Size(835, 297);
            this.dgvNominaEmpleados.TabIndex = 60;
            this.dgvNominaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNominaEmpleados_CellClick);
            // 
            // btnCalcularNomina
            // 
            this.btnCalcularNomina.Location = new System.Drawing.Point(118, 520);
            this.btnCalcularNomina.Name = "btnCalcularNomina";
            this.btnCalcularNomina.Size = new System.Drawing.Size(108, 23);
            this.btnCalcularNomina.TabIndex = 61;
            this.btnCalcularNomina.Text = "Guardar Nómina Individual";
            this.btnCalcularNomina.UseVisualStyleBackColor = true;
            this.btnCalcularNomina.Click += new System.EventHandler(this.btnCalcularNomina_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 67;
            this.label16.Text = "Sueldo";
            // 
            // txtSueldoNomina
            // 
            this.txtSueldoNomina.Location = new System.Drawing.Point(118, 361);
            this.txtSueldoNomina.Name = "txtSueldoNomina";
            this.txtSueldoNomina.ReadOnly = true;
            this.txtSueldoNomina.Size = new System.Drawing.Size(151, 20);
            this.txtSueldoNomina.TabIndex = 66;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(29, 335);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 18);
            this.label17.TabIndex = 65;
            this.label17.Text = "Empleado";
            // 
            // txtEmpleadoNomina
            // 
            this.txtEmpleadoNomina.Location = new System.Drawing.Point(118, 335);
            this.txtEmpleadoNomina.Name = "txtEmpleadoNomina";
            this.txtEmpleadoNomina.ReadOnly = true;
            this.txtEmpleadoNomina.Size = new System.Drawing.Size(151, 20);
            this.txtEmpleadoNomina.TabIndex = 64;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(37, 308);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 18);
            this.label29.TabIndex = 63;
            this.label29.Text = "Código";
            // 
            // txtCodigoEmpleadoNomina
            // 
            this.txtCodigoEmpleadoNomina.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodigoEmpleadoNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoEmpleadoNomina.Location = new System.Drawing.Point(118, 309);
            this.txtCodigoEmpleadoNomina.Name = "txtCodigoEmpleadoNomina";
            this.txtCodigoEmpleadoNomina.ReadOnly = true;
            this.txtCodigoEmpleadoNomina.Size = new System.Drawing.Size(47, 13);
            this.txtCodigoEmpleadoNomina.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Días Laborados";
            // 
            // cboMesCalcular
            // 
            this.cboMesCalcular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMesCalcular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMesCalcular.FormattingEnabled = true;
            this.cboMesCalcular.Location = new System.Drawing.Point(97, 163);
            this.cboMesCalcular.Name = "cboMesCalcular";
            this.cboMesCalcular.Size = new System.Drawing.Size(121, 21);
            this.cboMesCalcular.TabIndex = 71;
            this.cboMesCalcular.SelectedIndexChanged += new System.EventHandler(this.cboMesCalcular_SelectedIndexChanged);
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(97, 201);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.ReadOnly = true;
            this.txtDiasLaborados.Size = new System.Drawing.Size(121, 20);
            this.txtDiasLaborados.TabIndex = 72;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(97, 130);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.ReadOnly = true;
            this.txtAnio.Size = new System.Drawing.Size(121, 20);
            this.txtAnio.TabIndex = 73;
            // 
            // txtValidaciones
            // 
            this.txtValidaciones.AutoSize = true;
            this.txtValidaciones.BackColor = System.Drawing.Color.Transparent;
            this.txtValidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidaciones.ForeColor = System.Drawing.Color.IndianRed;
            this.txtValidaciones.Location = new System.Drawing.Point(88, 274);
            this.txtValidaciones.Name = "txtValidaciones";
            this.txtValidaciones.Size = new System.Drawing.Size(0, 15);
            this.txtValidaciones.TabIndex = 74;
            // 
            // btnGuardarMes
            // 
            this.btnGuardarMes.Location = new System.Drawing.Point(107, 460);
            this.btnGuardarMes.Name = "btnGuardarMes";
            this.btnGuardarMes.Size = new System.Drawing.Size(152, 23);
            this.btnGuardarMes.TabIndex = 75;
            this.btnGuardarMes.Text = "Guardar Nóminas del Mes";
            this.btnGuardarMes.UseVisualStyleBackColor = true;
            this.btnGuardarMes.Click += new System.EventHandler(this.btnGuardarMes_Click);
            // 
            // cboAnio
            // 
            this.cboAnio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboAnio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(97, 129);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 76;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Mes";
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1188, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.btnGuardarMes);
            this.Controls.Add(this.txtValidaciones);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.cboMesCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSueldoNomina);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEmpleadoNomina);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtCodigoEmpleadoNomina);
            this.Controls.Add(this.btnCalcularNomina);
            this.Controls.Add(this.dgvNominaEmpleados);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtDeduccionTotal);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtIGSS);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtSalarioExtraordinario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtSalarioOrdinario);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtHorasExtraordinarias);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtHorasOrdinarias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioTotal);
            this.Name = "frmNomina";
            this.Text = "5401 Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHorasOrdinarias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHorasExtraordinarias;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSalarioExtraordinario;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSalarioOrdinario;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtIGSS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDeduccionTotal;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.DataGridView dgvNominaEmpleados;
        private System.Windows.Forms.Button btnCalcularNomina;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSueldoNomina;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmpleadoNomina;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCodigoEmpleadoNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMesCalcular;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label txtValidaciones;
        private System.Windows.Forms.Button btnGuardarMes;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}