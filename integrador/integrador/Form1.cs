using Microsoft.Data.Sqlite;
namespace integrador
{
    public partial class Form1 : Form
    {
        string strConexion = "data source= BDintegrador.db";
        public SqliteConnection conexion;
        
        public Form1()
        {
            InitializeComponent();
            conexion = new SqliteConnection(strConexion);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqliteCommand comando = new SqliteCommand("SELECT * FROM sabores", conexion);
            SqliteDataReader lector = comando.ExecuteReader();
            lector.Read();
            Lbltex.Text = lector["texto"].ToString();
            lector.Close();
            conexion.Close();
        }

    }
}
