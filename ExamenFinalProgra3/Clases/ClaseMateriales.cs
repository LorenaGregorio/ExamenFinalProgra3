using ExamenFinalProgra3.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra3.Clases
{
    public class ClaseMateriales : IOperaciones
    {
        private string NombreMaterial;
        private string CategoriaMaterial;
        private int Proveedor;
        private string DefectosVisuales;
        private int Peso;
        private int Altura;
        private int Ancho;
        private int Largo;
        private string Dimensiones;

        public ClaseMateriales(string NombreMaterial, string CategoriaMaterial, int Proveedor, string DefectosVisuales, int Peso, int Altura, int Ancho, int Largo, string Dimensiones)
        {
            this.NombreMaterial = NombreMaterial;
            this.CategoriaMaterial = CategoriaMaterial;
            this.Proveedor = Proveedor;
            this.DefectosVisuales = DefectosVisuales;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Ancho = Ancho;
            this.Largo = Largo;
            this.Dimensiones = Dimensiones;
        }

      

        public string nombrematerial
        {
            get
            {
                return NombreMaterial;
            }
            set
            {
                NombreMaterial = value;
            }
        }

        public string categoriamaterial
        {
            get
            {
                return CategoriaMaterial;
            }
            set
            {
                CategoriaMaterial = value;
            }

        }
        public int proveedor
        {
            get
            {
                return Proveedor;
            }
            set
            {
                Proveedor = value;
            }
        }

        public string defectosvisuales
        {
            get
            {
                return DefectosVisuales;
            }
            set
            {
                DefectosVisuales = value;
            }


        }

        public int peso
        {
            get
            {
                return Peso;
            }
            set
            {
                Peso = value;
            }
        }

        public int largo 
        {
            get
            {
                return Largo;
            }
            set
            {
                Largo = value;
            }
        }

        public int altura
        {
            get
            {
                return Altura;
            }
            set
            {
              Altura = value;
            }
        }

        public int ancho
        {
            get
            {
                return Ancho;
            }
            set
            {
                Ancho = value;
            }
        }

        public string dimensiones
        {
            get
            {
                return Dimensiones;
            }
            set
            {
                Dimensiones = value;
            }
        }

        public string busqueda(string consulta)
        {
            return consulta;
        }
    }

}