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

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
            txtCodigo.Text = "";
            txtSalario.Text = "";
            txtAFP.Text = "";
            txtIsss.Text = "";
            txtDescuento.Text = "";
            txtSliquido.Text = "";
            labelRegistro.Text = "";
            
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

            if (txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo, "No ingresó el Código");
                txtCodigo.Focus();
                return;
            }

            errorProvider1.SetError(txtCodigo, "");

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
            Empleado.Codigo = txtCodigo.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);

            Empleado.Afp = Empleado.AFP(Empleado.Salario);
            txtAFP.Text = Empleado.Afp.ToString();

            Empleado.Isss = Empleado.ISSS(Empleado.Salario);
            txtIsss.Text = Empleado.Isss.ToString();

            Empleado.Descuento = Empleado.DESCUENTO(Empleado.Isss, Empleado.Afp);
            txtDescuento.Text = Empleado.Descuento.ToString();

            Empleado.Sliquido = Empleado.SLIQUIDO(Empleado.Salario, Empleado.Descuento);
            txtSliquido.Text = Empleado.Sliquido.ToString();

            //MessageBox.Show("¡Registro guardado!");
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            string cadena = "insert into [Empleados] (Nombre, DUI, Codigo, Salario, AFP, ISSS, DESCUENTO, SALARIOLIQUIDO) values ('" + Empleado.Nombre + "','" + Empleado.Dui + "','"+ Empleado.Codigo + "','" + Empleado.Salario + "','" + Empleado.Afp + "','" + Empleado.Isss + "','" + Empleado.Descuento + "','" + Empleado.Sliquido + "')";
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
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            Int32 cod;

            if (!Int32.TryParse(textBox1.Text, out cod))

            {
                errorProvider1.SetError(textBox1, "No ingresó el id de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(textBox1, "");

            string cadena = "select id, nombre, dui, codigo, salario, afp, isss, descuento, salarioliquido from Empleados where Id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                dataGridView1.Rows[0].Cells[0].Value = registro.GetInt32(0);
                dataGridView1.Rows[0].Cells[1].Value = registro.GetString(1);
                dataGridView1.Rows[0].Cells[2].Value = registro.GetString(2);
                dataGridView1.Rows[0].Cells[3].Value = registro.GetString(3);
                dataGridView1.Rows[0].Cells[4].Value = registro.GetDecimal(4);
                dataGridView1.Rows[0].Cells[5].Value = registro.GetDecimal(5);
                dataGridView1.Rows[0].Cells[6].Value = registro.GetDecimal(6);
                dataGridView1.Rows[0].Cells[7].Value = registro.GetDecimal(7);
                dataGridView1.Rows[0].Cells[8].Value = registro.GetDecimal(8);
            }
            else
                MessageBox.Show("No existe un Empleado con el id ingresado");
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
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            try
            {
                string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Dnombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Ddui = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Dcodigo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                double Dsalario = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);

                double DAFP = Empleado.AFP(Dsalario);
                double Disss = Empleado.ISSS(Dsalario);
                double Ddescuento = DAFP + Disss;
                double Dsliquido = Dsalario - Ddescuento;

                string cadena = "update [Empleados] set nombre='" + Dnombre + "', dui='" + Ddui +"', codigo='"+ Dcodigo + "', salario='" + Dsalario + "', afp='" + DAFP + "', ISSS='" + Disss + "', DESCUENTO='" + Ddescuento + "', SALARIOLIQUIDO='" + Dsliquido + "' where Id=" + cod;
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
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            string cadena = "select id, nombre, dui, codigo, salario, afp, ISSS, DESCUENTO, SALARIOLIQUIDO from Empleados";
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
                    dataGridView1.Rows[n].Cells[3].Value = registro.GetString(3);
                    dataGridView1.Rows[n].Cells[4].Value = registro.GetDecimal(4);
                    dataGridView1.Rows[n].Cells[5].Value = registro.GetDecimal(5);
                    dataGridView1.Rows[n].Cells[6].Value = registro.GetDecimal(6);
                    dataGridView1.Rows[n].Cells[7].Value = registro.GetDecimal(7);
                    dataGridView1.Rows[n].Cells[8].Value = registro.GetDecimal(8);
                }
            }
            else
                MessageBox.Show("No existen registros");
            conexion.Close();

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonLimpiarLaTabla_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\equipo1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();

            
            string codigo = textBox1.Text;

            string cadena = "select id, nombre, dui, codigo, salario, afp, isss, descuento, salarioliquido from Empleados where codigo = '" + textBox1.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                dataGridView1.Rows[0].Cells[0].Value = registro.GetInt32(0);
                dataGridView1.Rows[0].Cells[1].Value = registro.GetString(1);
                dataGridView1.Rows[0].Cells[2].Value = registro.GetString(2);
                dataGridView1.Rows[0].Cells[3].Value = registro.GetString(3);
                dataGridView1.Rows[0].Cells[4].Value = registro.GetDecimal(4);
                dataGridView1.Rows[0].Cells[5].Value = registro.GetDecimal(5);
                dataGridView1.Rows[0].Cells[6].Value = registro.GetDecimal(6);
                dataGridView1.Rows[0].Cells[7].Value = registro.GetDecimal(7);
                dataGridView1.Rows[0].Cells[8].Value = registro.GetDecimal(8);
            }
            else
                MessageBox.Show("No existe un Empleado con el id ingresado");
            conexion.Close();
        }
    }

}
