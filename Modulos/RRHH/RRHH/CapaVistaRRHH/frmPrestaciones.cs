using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVistaRRHH
{  //Ivania Gatica 0901-18-19528
    public partial class frmPrestaciones : Form
    {
        controladorPrestaciones cp = new controladorPrestaciones();
        public frmPrestaciones()
        {
            InitializeComponent();
            llenarcbxPrestacion();
            llenarcbxEmpleado();
            actualizardatagriew();
            CenterToScreen();
        }
        private string tabla = "totalprestacion";
        public void actualizardatagriew()
        {
            DataTable dt = cp.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
        }
        //Ivania Gatica 0901-18-19528

        public void llenarcbxPrestacion()
        {
            try
            {
                comboBox1.Items.Clear();
                OdbcDataReader datareader = cp.llenarcbxPrestacion();
                comboBox1.Items.Add("seleccione una prestacion");
                while (datareader.Read())
                {
                    comboBox1.Items.Add(datareader[0].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //Ivania Gatica 0901-18-19528

        public void llenarcbxEmpleado()
        {
            try
            {
                comboBox2.Items.Clear();
                OdbcDataReader datareader = cp.llenarcbxEmpleado();
                comboBox2.Items.Add("Selecione un Empleado");
                while (datareader.Read())
                {
                    comboBox2.Items.Add(datareader[0].ToString());

                }
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }



        //Ivania Gatica 0901-18-19528

        public string consultaPrestacion(string nombre)
        {
            string id_modulo = cp.consultaPrestacion(nombre);

            return id_modulo;
        }

       
        
        //Ivania Gatica 0901-18-19528
        public string consultaEmpleado(string nombre)
        {
            string id_modulo = cp.consultaEmpleado(nombre);

            return id_modulo;

        }

        public void metodoLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        

        
        //Ivania Gatica 0901-18-19528
   

        



        //Ivania Gatica 0901-18-19528

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";

            try
            {
                string datei = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string datef = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                //Jorge González 0901-18-3920
                //Bitacora loggear = new Bitacora();
                //loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Insertar");
                //
                if (textBox1.Text.Trim() != "")
                {
                    //Jorge González 0901-18-3920
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Inserción realizada");
                    //

                    cp.insertarPrestacion(textBox1.Text, textBox5.Text, textBox4.Text, datei, datef, int.Parse(textBox2.Text), decimal.Parse(textBox3.Text));
                    MessageBox.Show("Insercion realizada");
                    metodoLimpiar();
                    actualizardatagriew();

                }
                else
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Error al realizar Inserción");
                    MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Ivania Gatica 0901-18-19528
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            cp.eliminarPrestacion(textBox1.Text);
            MessageBox.Show("Eliminacion realizada");
            metodoLimpiar();
            actualizardatagriew();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["totalPrestacion"].Value);

            }
            textBox6.Text = Convert.ToString(total);
        }

        private void reporteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reporteLiqui form1 = new reporteLiqui();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                textBox4.Text = consultaPrestacion(comboBox1.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                textBox5.Text = consultaEmpleado(comboBox2.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        //Ivania Gatica 0901-18-19528
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {
            }
        }

        private void manualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/RM/Desktop/pruebaaaa/RecursosHumanos/RRHH/Ayudas/Ayuda5100.chm", "C:/Users/RM/Desktop/pruebaaaa/RecursosHumanos/RRHH/Ayudas/Manual-de-Usuario-liquidacion.html");
        }
    }



}



