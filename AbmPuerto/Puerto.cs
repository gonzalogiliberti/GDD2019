using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    class Puerto
    {
        public Int32 idPuerto;
        public String puerto;

        public Puerto(DataRow row)
        {
            this.idPuerto = Convert.ToInt32(row["idPuerto"]);
            this.puerto = Convert.ToString(row["puerto"]);
        }

        public Puerto(DataGridViewRow unPuerto)
        {
            this.idPuerto = (int)unPuerto.Cells["idPuerto"].Value;
            this.puerto = (string)unPuerto.Cells["puerto"].Value;
        }

        public Puerto(Puerto unPuerto)
        {
            this.idPuerto = unPuerto.idPuerto;
            this.puerto = unPuerto.puerto;
        }

        public Puerto(String nombre)
        {
            this.puerto = nombre;
        }

        public override string ToString()
        {
            return this.puerto;
        }
        
        public Int32 getId()
        {
            return idPuerto;
        }

        public String getPuerto()
        {
            return puerto;
        }
    }
}
