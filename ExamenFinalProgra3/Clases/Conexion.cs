using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

           
        }
    }
}
