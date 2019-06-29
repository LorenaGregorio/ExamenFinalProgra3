using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra3.Clases
{
    public class ClaseMateriales
    {
        private string NombreMaterial;
        private string CategoriaMaterial;
        private string Proveedor;

        public ClaseMateriales(string NombreMaterial, string CategoriaMaterial, string Proveedor)
        {
            this.NombreMaterial = NombreMaterial;
            this.CategoriaMaterial = CategoriaMaterial;
            this.Proveedor = Proveedor;


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
        public string proveedor
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

    }

}