using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    class Fabricante
    {
        private Int32 idFabricante;
        private String Nombre;

        public Fabricante(DataRow row)
        {
            this.idFabricante = Convert.ToInt32(row["idFabricante"]);
            this.Nombre = Convert.ToString(row["Fabricante"]);
        }

        public Fabricante(DataGridViewRow unFabricante)
        {
            this.idFabricante = (int)unFabricante.Cells["idFabricante"].Value;
            this.Nombre = (string)unFabricante.Cells["Fabricante"].Value;
        }

        public Fabricante(Fabricante unFabricante)
        {
            this.idFabricante = unFabricante.idFabricante;
            this.Nombre = unFabricante.Nombre;
        }

        public Fabricante(String nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
        
        public Int32 getId()
        {
            return idFabricante;
        }

        public String getFabricante()
        {
            return Nombre;
        }
    }
}
