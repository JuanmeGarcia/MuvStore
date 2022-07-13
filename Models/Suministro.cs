using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuvStore.enums;

namespace MuvStore.Models
{
    public class Suministro : ElementoBase
    {

        public Suministro(
        string nombreProducto,
        int pasillo,
        int estanteria,
        int piso,
        int cantidad,
        Depositos depositoClase)
        {
            Nombre = nombreProducto;
            Deposito = depositoClase;
            Pasillo = pasillo;
            Estanteria = estanteria;
            Nivel = piso;
            Cantidad = cantidad;
        }

        public Suministro()
        {

        }
    }
}



