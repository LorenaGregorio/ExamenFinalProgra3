using ExamenFinalProgra3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalProgra3
{
    public partial class Form1 : Form
    {
        // Se crea el objeto conexion para que se obtegan los datos
        Conexion con = new Conexion();
        string cadena, car, numero;
        int z;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarRechazados();
            ActualizarAceptados();
            con.ComboProveedor(ComboPro);
        }
        // Metodo para actualizar datagridview
        public void ActualizarRechazados()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "select IdMaterial, NombreMaterial,CategoriaMaterial,Nombre, DefectosVisuales, Peso,Altura,Ancho,Largo,Dimensiones  from MaterialesTBL, ProveedorTBL  where ((dbo.MaterialesTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)  and(DefectosVisuales = 'SI' OR DefectosVisuales = 'NO') ) and((Dimensiones = 'NO') or(Dimensiones = 'Dim') )");
            //
        }

        // Metodo para actualizar datagridview
        public void ActualizarAceptados()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView2, " select IdMaterial, NombreMaterial,CategoriaMaterial,Nombre, DefectosVisuales, Peso,Altura,Ancho,Largo,Dimensiones  from MaterialesTBL, ProveedorTBL  where ((dbo.MaterialesTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)	and ((DefectosVisuales = 'NO') and (Dimensiones = 'SI') ))");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (combdefevisuales.SelectedItem.Equals("SI"))
            {
                MessageBox.Show("SE RECHAZA LA COMPRA DEL MATERIAL");
            }
            else if((combdefevisuales.SelectedItem.Equals("NO")) && (combdimensiones.SelectedItem.Equals("NO")))
            {
                MessageBox.Show("EL MATERIAL NO ES ACEPTABLE POR QUE NO CUMPLIO CON LAS DIMENSIONALES ");

            }
            if ((combdefevisuales.SelectedItem.Equals("NO")) && (combdimensiones.SelectedItem.Equals("SI")))
            {
                MessageBox.Show("CONTROL DE CALIDAD ACEPTADO  \nDAR INGRESO A INVENTARIO" );

            }


        }

        private void combdefevisuales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combdefevisuales.SelectedItem.Equals("NO"))
            {
                groupBox1.Visible = true;

            }
           else
            {
                groupBox1.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseMateriales m = new ClaseMateriales
            (
                txtnombre.Text,
                txtcategoria.Text,
                Convert.ToInt32(txtproveedor.Text),
                combdefevisuales.Text,
                Convert.ToInt32(txtaltura.Text),
                Convert.ToInt32(txtpeso.Text),
                Convert.ToInt32(txtancho.Text),
                Convert.ToInt32(txtlargo.Text),
                combdimensiones.Text
            );

            con.Conectar();

            //Se crea una consulta para insertar los datos (Guardar)
            string consulta = "insert into MaterialesTBL (NombreMaterial,CategoriaMaterial,Proveedor,DefectosVisuales,Peso,Altura,Ancho,Largo,Dimensiones) " +
                "values ('" + m.nombrematerial + "', '" + m.categoriamaterial + "'," + m.proveedor + ",'" + m.defectosvisuales + "'," + m.peso + "," + m.altura + "," + m.ancho + ","+m.largo+", '"+m.dimensiones+"' );";

           

            //con esta funcion ejecuto la consulta de arriba en codigo sql
            con.EjecutarSql(consulta);
            this.ActualizarRechazados();
            this.ActualizarAceptados();
            con.Desconectar();
            // Uso de la Interfaz
            MessageBox.Show(m.busqueda(" Agrego el Material: " + m.nombrematerial + "\n A Inventario"));
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void ComboPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadena = ComboPro.SelectedItem.ToString().Trim();

            for (int i = 0; i < cadena.Length; i++)
            {
                car = cadena.Substring(i, 1);
                switch (car)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        numero = numero + car;
                        break;
                    default:
                        break;
                }

            }
            txtproveedor.Clear();
            txtproveedor.Text = numero;
            numero = "";
        }
    }
}
