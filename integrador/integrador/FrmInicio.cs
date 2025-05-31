using Microsoft.Data.Sqlite;
namespace integrador
{
    public partial class FrmMain_Mostrar : Form
    {
        public List<Helado> listaHelado = new List<Helado>();
        Agregar_Sabores Agregar;
        string strConexion = "data source= BDintegrador.db";
        public SqliteConnection conexion;

        public FrmMain_Mostrar()
        {
            InitializeComponent();
            Agregar = new Agregar_Sabores(this);
            conexion = new SqliteConnection(strConexion);
        }

        private void Btn_Siguente_Click(object sender, EventArgs e)
        {
            Agregar.MostrarAgregar();
            this.Hide();
        }

        public void ActualizarDataGrid()
        {
            DgvSabores.Rows.Clear();

            foreach (Helado h in listaHelado)
            {
                DgvSabores.Rows.Add(h.Id, h.Nombre, h.Descripcion, h.Precio);
            }

        }
        public void ActualizarListaHelado()
        {
            conexion.Open();
            SqliteCommand comando = new SqliteCommand("SELECT * FROM sabores", conexion);
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector == null)
                return;
            listaHelado.Clear();
            while (lector.Read())
            {
                Helado helado = new Helado(int.Parse(lector["id_sabores"].ToString()), lector["nombre"].ToString(), lector["descripcion"].ToString(), int.Parse(lector["precio"].ToString()));
                listaHelado.Add(helado);
            }
            lector.Close();
            conexion.Close();
            ActualizarDataGrid();
        }


        private void FrmMain_Mostrar_Load(object sender, EventArgs e)
        {
            ActualizarListaHelado();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            if (DgvSabores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe haber sabores.");
            }
            else
            {
                int idAModificar = int.Parse(DgvSabores.SelectedRows[0].Cells["id"].Value.ToString());

                Helado helado;
                foreach (Helado h in listaHelado)
                {
                    if (idAModificar == h.Id)
                    {
                        helado = h;
                        Agregar.MostrarModificar(helado);
                        this.Hide();
                        break;
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(DgvSabores.SelectedRows.Count<=0)
            {
                MessageBox.Show("Debe haber sabores.");
            }else { 
                int idAEliminar = int.Parse(DgvSabores.SelectedRows[0].Cells["id"].Value.ToString());
                conexion.Open();
                string consulta = $" DELETE FROM sabores where id_sabores='{idAEliminar}'";
                SqliteCommand comando = new SqliteCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                ActualizarListaHelado();
                ActualizarDataGrid();
            }
        }
    }
}