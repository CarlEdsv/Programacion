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

namespace Semana11
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void btInsertar_Click(object sender, EventArgs e)
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
                txtDUI.Focus();
                return;
            }
            errorProvider1.SetError(txtDUI, "");

            double Salario;
            if(!double.TryParse(txtSalario.Text, out Salario))
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
            txtAFP.Text = Empleado.Afp.ToString();

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            string cadena = "insert into [Empleados] (Nombre, Dui, Salario, Afp) values ('"+Empleado.Nombre + "','"+ Empleado.Dui + "','" +Empleado.Salario + "','" + Empleado.Afp+"')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            conexion.Close();
        }
        
        private void btClean_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
            txtSalario.Text = "";
            txtAFP.Text = "";
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            Int32 cod;
            if (!Int32.TryParse(txtConsultar.Text, out cod))
            {
                errorProvider1.SetError(txtConsultar, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }

            errorProvider1.SetError(txtConsultar, "");
            string cadena = "select Nombre,Dui, Salario, Afp from Empleados where Id="+cod;
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
                MessageBox.Show("No existe un empleado con el código ingresado");
            conexion.Close();
        }//ERROR AL CONSULTAR. SEPA SI ELIMINAR Y MODIFICAR FUNCIONAN.

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
            try
            {
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
            }
            catch (Exception) { MessageBox.Show("Debe seleccionar un registro"); }
            conexion.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            conexion.Open();
        try
        {
            string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Dnombre = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string Ddui = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string Dsalario = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string Dafp = dataGridView1.Rows[0].Cells[4].Value.ToString();

            string cadena = "update [Empleados] set nombre='" + Dnombre + "', dui='" + Ddui + "', salario='" + Dsalario + "', afp='" + Dafp + "' where Id=" + cod;
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
        catch (Exception)
        {
            MessageBox.Show("No existe seleccionó el empleado");
            conexion.Close();
        }

        }

        private void btSeeAll_Click(object sender, EventArgs e)
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
    }
}
