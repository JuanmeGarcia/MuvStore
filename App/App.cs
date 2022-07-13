using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuvStore.enums;
using MuvStore.Models;
using System.Windows.Forms;
using System.IO;

namespace MuvStore.App
{
    public class AppEngine
    {

        public Empresa empresa { get; set; }

        public AppEngine()
        {
            empresa = new Empresa();
        }

        public void agregarProducto(
             string nombreProducto,
             Depositos deposito,
             int pasillo,
             int estanteria,
             int nivel,
             int cantidad
        )
        {
            var producto = new Producto
            {
                Nombre = nombreProducto,
                Deposito = deposito,
                Pasillo = pasillo,
                Estanteria = estanteria,
                Nivel = nivel,
                Cantidad = cantidad
            };
            empresa.productos.Add(producto);
        }

        public void agregarMaterial(
            string nombreProducto,
            Depositos deposito,
            int pasillo,
            int estanteria,
            int nivel,
            int cantidad
            )
        {

            var material = new Material
            {
                Nombre = nombreProducto,
                Deposito = deposito,
                Pasillo = pasillo,
                Estanteria = estanteria,
                Nivel = nivel,
                Cantidad = cantidad
            };
            empresa.materiales.Add(material);
        }


        public void agregarSuministro(
            string nombreProducto,
            Depositos deposito,
            int pasillo,
            int estanteria,
            int nivel,
            int cantidad
        )
        {

            var suministro = new Suministro
            {
                Nombre = nombreProducto,
                Deposito = deposito,
                Pasillo = pasillo,
                Estanteria = estanteria,
                Nivel = nivel,
                Cantidad = cantidad
            };



            empresa.suministros.Add(suministro);
        }

        public void modificarCantidadPorId(string id, string tipoProducto, int nuevoValor)
        {
            if(tipoProducto == "producto")
            {     
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Cantidad = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Cantidad = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Cantidad = nuevoValor;
                        }
                        return item;
                    });
            }
        }

        public void modificarPasilloPorId(string id, string tipoProducto, int nuevoValor)
        {
            if (tipoProducto == "producto")
            {
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Pasillo = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Pasillo = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Pasillo = nuevoValor;
                        }
                        return item;
                    });
            }
        }
        
        public void modificarNivelPorId(string id, string tipoProducto, int nuevoValor)
        {
            if (tipoProducto == "producto")
            {
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Nivel = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Nivel = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Nivel = nuevoValor;
                        }
                        return item;
                    });
            }
        }

        public void modificarDepositoPorId(string id, string tipoProducto, Depositos nuevoValor)
        {
            if (tipoProducto == "producto")
            {
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Deposito = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Deposito = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Deposito = nuevoValor;
                        }
                        return item;
                    });
            }
        }

        public void modificarEstanteriaPorId(string id, string tipoProducto, int nuevoValor)
        {
            if (tipoProducto == "producto")
            {
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Estanteria = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Estanteria = nuevoValor;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            item.Estanteria = nuevoValor;
                        }
                        return item;
                    });
            }
        }

        public void venderElemento(string id, string tipoProducto, int cantidadVendida)
        {
            if (tipoProducto == "producto")
            {
                empresa.productos
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            if(cantidadVendida > item.Cantidad)
                            {
                                MessageBox.Show("No hay suficiente cantidad en el almacen");
                                return item;
                            }
                            item.Cantidad -= cantidadVendida;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "material")
            {
                empresa.materiales
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            if (cantidadVendida > item.Cantidad)
                            {
                                MessageBox.Show("No hay suficiente cantidad en el almacen");
                                return item;
                            }
                            item.Cantidad -= cantidadVendida;
                        }
                        return item;
                    });
            }
            if (tipoProducto == "suministro")
            {
                empresa.suministros
                    .Select(item =>
                    {
                        if (item.Id == id)
                        {
                            if (cantidadVendida > item.Cantidad)
                            {
                                MessageBox.Show("No hay suficiente cantidad en el almacen");
                                return item;
                            }
                            item.Cantidad -= cantidadVendida;
                        }
                        return item;
                    });
            }
        }

        public void CargarElementos(Depositos deposito)
        {
            try
            {
                string fileName = $@"D:/{deposito}.txt";
                string directory = Path.GetDirectoryName(fileName);
                var materiales = new List<Material>();
                var productos = new List<Producto>();
                var suministros = new List<Suministro>();

                if (!Directory.Exists(directory))
                {
                    return;
                }

                FileStream FS = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);
                string line = "";
                while ((line = SR.ReadLine()) != null)
                {
                    string[] campos = line.Split(',');
                    string tipoProducto = campos[1];
                    string nombreProducto = campos[2];
                    string pasillo = campos[3];
                    string estanteria = campos[4];
                    string piso = campos[5];
                    string cantidad = campos[6];

                    if (tipoProducto == "Producto")
                    {
                        productos.Add(new Producto(nombreProducto, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad), deposito));
                    }
                    if (tipoProducto == "Material")
                    {
                        materiales.Add(new Material(nombreProducto, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad), deposito));
                    }
                    if (tipoProducto == "Suministro")
                    {
                        suministros.Add(new Suministro(nombreProducto, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad), deposito));
                    }
                }

                empresa.productos.AddRange(productos);
                empresa.materiales.AddRange(materiales);
                empresa.suministros.AddRange(suministros);

                SR.Close();
                FS.Close();
            }
            catch (Exception)
            {
                
            }
        }

        
    }
}
