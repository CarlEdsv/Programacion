using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {

        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btAFP_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingresó el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingresó el DUI");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");


            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))

            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalario, "");



            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            Empleado.Afp = Empleado.AFP(Empleado.Salario);
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
            labelRegistro.Text = "¡Registro guardado!";
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
                conexion.Open();
                
                string cadena = "insert into [Empleados] (Nombre, DUI, Salario, AFP) values ('" + Empleado.Nombre + "','" + Empleado.Dui + "','" + Empleado.Salario + "','" + Empleado.Afp + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");

                conexion.Close();

            

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            Int32 cod;

            if (!Int32.TryParse(textBox1.Text, out cod))

            {
                errorProvider1.SetError(textBox1, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(textBox1, "");


            string cadena = "select id, nombre, dui, salario, afp from Empleados where Id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                dataGridView1.Rows[0].Cells[0].Value = registro.GetInt32(0);
                dataGridView1.Rows[0].Cells[1].Value = registro.GetString(1);
                dataGridView1.Rows[0].Cells[2].Value = registro.GetString(2);
                dataGridView1.Rows[0].Cells[3].Value = registro.GetDecimal(3);
                dataGridView1.Rows[0].Cells[4].Value = registro.GetDecimal(4);
            }
            else
                MessageBox.Show("No existe un Empleado con el código ingresado");
            conexion.Close();


        }

        private void lbDUI_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            
            try
            {
                string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string Dnombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ddui = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Dsalario = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string DAFP = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                string cadena = "update [Empleados] set nombre='" + Dnombre + "', dui='" + Ddui + "', salario='" + Dsalario + "', afp='" + DAFP + "' where Id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    MessageBox.Show("Se modificaron los datos del empleado");
                }
            }
            catch (Exception) { MessageBox.Show("Debe seleccionar un registro"); }
            conexion.Close();



        }

        private void Vertodo_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            string cadena = "select id, nombre, dui, salario, afp from Empleados";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = registro.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = registro.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = registro.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = registro.GetDecimal(3);
                    dataGridView1.Rows[n].Cells[4].Value = registro.GetDecimal(4);
                }
            }
            else
                MessageBox.Show("No existen un registros");
            conexion.Close();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Planilla.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            string cadena = "delete from [Empleados] where Id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                MessageBox.Show("Se borró el registro");
            }

            else
            {

                MessageBox.Show("No seleccionó un registro");
            }


            conexion.Close();

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
            txtSalario.Text = "";
            txtAFP.Text = "";
            labelRegistro.Text = "";
        }
    }

}
