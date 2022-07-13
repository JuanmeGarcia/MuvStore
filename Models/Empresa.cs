using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuvStore.Models
{
    public class Empresa
    {
        public string id { get; }

        public List<Material> materiales { get; set; } = new List<Material>();
        public List<Producto> productos { get; set; } = new List<Producto>();
        public List<Suministro> suministros { get; set; } = new List<Suministro>();

        public Empresa() => id = Guid.NewGuid().ToString();

    }
}
