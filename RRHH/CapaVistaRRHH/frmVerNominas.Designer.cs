
namespace CapaVista
{
    partial class frmVerNominas
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
            this.dgvNominas = new System.Windows.Forms.DataGridView();
            this.cboAnios = new System.Windows.Forms.ComboBox();
            this.cboMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCierreDeNominas = new System.Windows.Forms.Button();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.txtValidaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNominas
            // 
            this.dgvNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominas.Location = new System.Drawing.Point(24, 254);
            this.dgvNominas.Name = "dgvNominas";
            this.dgvNominas.Size = new System.Drawing.Size(1152, 397);
            this.dgvNominas.TabIndex = 1;
            // 
            // cboAnios
            // 
            this.cboAnios.FormattingEnabled = true;
            this.cboAnios.Location = new System.Drawing.Point(526, 152);
            this.cboAnios.Name = "cboAnios";
            this.cboAnios.Size = new System.Drawing.Size(121, 21);
            this.cboAnios.TabIndex = 2;
            this.cboAnios.SelectedIndexChanged += new System.EventHandler(this.cboAnios_SelectedIndexChanged);
            // 
            // cboMeses
            // 
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Location = new System.Drawing.Point(526, 204);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Size = new System.Drawing.Size(121, 21);
            this.cboMeses.TabIndex = 3;
            this.cboMeses.SelectedIndexChanged += new System.EventHandler(this.cboMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nóminas";
            // 
            // btnCierreDeNominas
            // 
            this.btnCierreDeNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreDeNominas.Location = new System.Drawing.Point(144, 168);
            this.btnCierreDeNominas.Name = "btnCierreDeNominas";
            this.btnCierreDeNominas.Size = new System.Drawing.Size(138, 33);
            this.btnCierreDeNominas.TabIndex = 7;
            this.btnCierreDeNominas.Text = "Cierre de Nóminas";
            this.btnCierreDeNominas.UseVisualStyleBackColor = true;
            this.btnCierreDeNominas.Click += new System.EventHandler(this.btnCierreDeNominas_Click);
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(157, 132);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAPagar.TabIndex = 8;
            // 
            // txtValidaciones
            // 
            this.txtValidaciones.AutoSize = true;
            this.txtValidaciones.BackColor = System.Drawing.Color.Transparent;
            this.txtValidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidaciones.ForeColor = System.Drawing.Color.IndianRed;
            this.txtValidaciones.Location = new System.Drawing.Point(140, 110);
            this.txtValidaciones.Name = "txtValidaciones";
            this.txtValidaciones.Size = new System.Drawing.Size(0, 15);
            this.txtValidaciones.TabIndex = 75;
            // 
            // frmVerNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaRRHH.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1188, 663);
            this.Controls.Add(this.txtValidaciones);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.btnCierreDeNominas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMeses);
            this.Controls.Add(this.cboAnios);
            this.Controls.Add(this.dgvNominas);
            this.Name = "frmVerNominas";
            this.Text = "frmVerNominas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNominas;
        private System.Windows.Forms.ComboBox cboAnios;
        private System.Windows.Forms.ComboBox cboMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCierreDeNominas;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label txtValidaciones;
    }
}