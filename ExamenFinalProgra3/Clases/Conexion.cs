using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalProgra3.Clases
{
    class Conexion
    {
        //se creo la variable para la conexion con la base de datos
        SqlConnection conn;
        SqlCommand cmd2;
        SqlDataReader dr2;

        //metodo para la conexion

        public void Conectar()
        {
            conn = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=ExamenFinalProgra3DB;Integrated Security=True");
            conn.Open();
        }

        //metodo para desconectar
        public void Desconectar()
        {
            conn.Close();
        }
        //Metodo para realizar consultar a la base de datos
        public void EjecutarSql(String consulta)
        {
            // se crea una variable llama con que es de comando y aparte el conn que es la conexion a la base de datos

            SqlCommand con = new SqlCommand(consulta, conn);

            //funcion para saber si el dato fue agregado correctamente
            int filasAfectadas = con.ExecuteNonQuery();




            if (filasAfectadas > 0)
            {
                MessageBox.Show("Usuario agregado correctamente", "La Base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Usuario no fue agregado", "La Base de Datos no ha sido Modificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            //se crea el metodo para actulizar el datagridview
            public void ActualizarGrid(DataGridView dg, string consulta)
            {
                //llamo al metodo conectar que me da la conexion con la base de datos
                this.Conectar();

                //se Crea una referencia para los datos 
                //Para que se tome los datos de la base de datos y los jale en datagridview
                System.Data.DataSet ds = new System.Data.DataSet();

                //se crea un adaptador para los datos de la base de datos
                SqlDataAdapter da = new SqlDataAdapter(consulta, conn);

                //Se realiza una funcion de llenado para la tabla del datagridview
                da.Fill(ds, "MaterialesTBL");

                //se agregan las propiedades al datagridview
                dg.DataSource = ds;

                //esta fucnion va a traer todo el contenido de la tabla que mecionamos arriba
                dg.DataMember = "MaterialesTBL";

                this.Desconectar();
            }

        public void ComboProveedor(ComboBox cb)
        {
            //llama al metodo para conectar con la base de datos
            this.Conectar();
            cmd2 = new SqlCommand("Select * from  ProveedorTBL", conn);
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cb.Items.Add(dr2["IdProveedor"].ToString() + "  " + dr2["Nombre"].ToString());
            }
            dr2.Close();
            this.Desconectar();
        }
    }
}
