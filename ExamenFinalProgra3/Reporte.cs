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
    public partial class Reporte : Form
    {
        Conexion con = new Conexion();
        public Reporte()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Nombre Material"))
            {
                con.ActualizarGrid(this.dataGridView1, " select IdMaterial, NombreMaterial,CategoriaMaterial,Nombre, DefectosVisuales, Peso,Altura,Ancho,Largo,Dimensiones  from MaterialesTBL, ProveedorTBL  where ((dbo.MaterialesTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)	and ((DefectosVisuales = 'NO') and (Dimensiones = 'SI')) and (NombreMaterial like '" + textBox1.Text + "%') )");
            }

            if (comboBox1.SelectedItem.Equals("Categoria Material"))
            {
                con.ActualizarGrid(this.dataGridView1, " select IdMaterial, NombreMaterial,CategoriaMaterial,Nombre, DefectosVisuales, Peso,Altura,Ancho,Largo,Dimensiones  from MaterialesTBL, ProveedorTBL  where ((dbo.MaterialesTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)	and ((DefectosVisuales = 'NO') and (Dimensiones = 'SI')) and (CategoriaMaterial like '" + textBox1.Text + "%') )");
            }

            if (comboBox1.SelectedItem.Equals("Proveedor"))
            {
                con.ActualizarGrid(this.dataGridView1, " select IdMaterial, NombreMaterial,CategoriaMaterial,Nombre, DefectosVisuales, Peso,Altura,Ancho,Largo,Dimensiones  from MaterialesTBL, ProveedorTBL  where ((dbo.MaterialesTBL.Proveedor = dbo.ProveedorTBL.IdProveedor)	and ((DefectosVisuales = 'NO') and (Dimensiones = 'SI')) and (Nombre like '" + textBox1.Text + "%') )");  
            }


        }


    }
}
