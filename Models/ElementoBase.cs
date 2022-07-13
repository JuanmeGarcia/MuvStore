using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuvStore.enums;

namespace MuvStore.Models
{
    public class ElementoBase
    {
        public string Id { get; }
        public string Nombre { get; set; }

        public Depositos Deposito { get; set; }
        public int Cantidad { get; set; }
        public int Nivel { get; set; }
        public int Estanteria { get; set; }
        public int Pasillo { get; set; }

        public ElementoBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
