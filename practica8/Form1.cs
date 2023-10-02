using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace practica8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection conexion = new SqlConnection("Data Source=SP-PC11;Initial Catalog=Empresa;Integrated Security=True; TrueServerCertificate=True");

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ADDbutton_Click(object sender, EventArgs e)
		{
			conexion.Open();

			string consulta = "INSERT INTO Empleados VALUES " + "(" + IDtextbox.Text + ", '" + NametextBox.Text + "','" + ApellidotextBox.Text + "','" + DirecciontextBox.Text + "')";

			SqlCommand comando = new SqlCommand(consulta, conexion);

			comando.ExecuteNonQuery();

			MessageBox.Show("Registro agregado");


			conexion.Close();
		}
	}
}