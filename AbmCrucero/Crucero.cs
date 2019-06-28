using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmCrucero
{
    class Crucero
    {
        public Int32 idCrucero;
        public String identificador;
        public Int32 idFabricante;
        public String modelo;
        public DateTime fechaAlta;
        public Int32 idTipoServicio;
        public Int32 cantidadCabinas;

        public Crucero()
        {
        }

        public Crucero(String ident, Int32 idFab, String model, DateTime fecha, Int32 cantCab)
        {
            this.identificador = ident;
            this.idFabricante = idFab;
            this.modelo = model;
            this.fechaAlta = fecha;
            this.cantidadCabinas = cantCab;
        }

        public Int32 getIdCrucero()
        {
            return this.idCrucero;
        }

        public String getIdentificador()
        {
            return this.identificador;
        }

        public Int32 getIdFabricante()
        {
            return this.idFabricante;
        }

        public String getModelo()
        {
            return this.modelo;
        }

        public DateTime getFechaAlta()
        {
            return this.fechaAlta;
        }

        public Int32 getCantidadCabinas()
        {
            return this.cantidadCabinas;
        }

    }
}
