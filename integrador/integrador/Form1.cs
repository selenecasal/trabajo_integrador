using Microsoft.Data.Sqlite;
namespace integrador
{
    public partial class FrmMain_Mostrar : Form
    {
        Agregar_Sabores Agregar;
        string strConexion = "data source= BDintegrador.db";
        public SqliteConnection conexion;

        public FrmMain_Mostrar()
        {
            InitializeComponent();
            Agregar = new Agregar_Sabores(this);
            conexion = new SqliteConnection(strConexion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqliteCommand comando = new SqliteCommand("SELECT * FROM sabores", conexion);
            SqliteDataReader lector = comando.ExecuteReader();
            lector.Read();
            DgvSabores.Rows.Add(lector["id"].ToString(), lector["texto"].ToString());
            lector.Close();
            conexion.Close();
        }

        private void Btn_Siguente_Click(object sender, EventArgs e)
        {
            Agregar.Show();
            this.Hide();
        }
        /*private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/
        private void FrmMain_Mostrar_Activated(object sender, EventArgs e)
        {
            conexion.Open();
            SqliteCommand comando = new SqliteCommand("SELECT * FROM sabores", conexion);
            SqliteDataReader lector = comando.ExecuteReader();
            DgvSabores.Rows.Clear();
            while (lector.Read())
            {
                DgvSabores.Rows.Add(lector["id"].ToString(), lector["texto"].ToString());
            }
            lector.Close();
            conexion.Close();
        }
    }
}
