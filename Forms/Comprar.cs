using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MuvStore.enums;
using MuvStore.App;
using MuvStore.Models;

namespace MuvStore.Forms
{
    public partial class Comprar : Form
    {
        
        public Comprar()
        {
            InitializeComponent();
        }

        public void guardarDatosEnTXT()
        {
            
        }        
        

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Listar listarFrm = new Listar();
            ValidarCampos();

            if(cmbDeposito.SelectedIndex == 0)
            {
                CrearProducto(Depositos.lomas_de_zamora);
            }
            if (cmbDeposito.SelectedIndex == 1)
            {
                CrearProducto(Depositos.temperley);
            }
            if(cmbDeposito.SelectedIndex == 2)
            {
                CrearProducto(Depositos.adrogue);
            }

            messageBoxGuna.Show();

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #region Validaciones

        public void ValidarCampos()
        {
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Debe ingresar un producto");
                return;
            }
            
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            
            if (cmbTP.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de producto");
                return;
            }
            
            if (cmbDeposito.Text == "")
            {
                MessageBox.Show("Debe seleccionar un deposito");
                return;
            }
            
            if (txtPiso.Text == "")
            {
                MessageBox.Show("Debe ingresar un piso");
                return;
            }
            
            if (txtPasillo.Text == "")
            {
                MessageBox.Show("Debe ingresar un pasillo");
                return;
            }
            
            if (txtEstanteria.Text == "")
            {
                MessageBox.Show("Debe ingresar una estanteria");
                return;
            }
        }


        #endregion

        #region Crear Producto
        private void CrearProducto(Depositos deposito)
        {
            try
            {
                FileStream FS;
                StreamWriter SW;
                string elementoId = "";
                
                string nombreProducto = txtProducto.Text;
                string cantidad = txtCantidad.Text;
                string tipoProducto = cmbTP.Text;
                string piso = txtPiso.Text;
                string pasillo = txtPasillo.Text;
                string estanteria = txtEstanteria.Text;



                if (cmbDeposito.SelectedIndex == 0)
                {
                    Program.app.agregarSuministro(nombreProducto, Depositos.lomas_de_zamora, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad));
                    int tamanioSuministro = Program.app.empresa.suministros.Count;
                    elementoId = Program.app.empresa.suministros[tamanioSuministro - 1].Id;
                }

                if (cmbDeposito.SelectedIndex == 1)
                {
                    Program.app.agregarMaterial(nombreProducto, Depositos.temperley, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad));
                    int tamanioMateriales = Program.app.empresa.materiales.Count;
                    elementoId = Program.app.empresa.suministros[tamanioMateriales - 1].Id;
                }
                if (cmbDeposito.SelectedIndex == 2)
                {
                    Program.app.agregarProducto(nombreProducto, Depositos.adrogue, Convert.ToInt32(pasillo), Convert.ToInt32(estanteria), Convert.ToInt32(piso), Convert.ToInt32(cantidad));
                    int tamanioProductos = Program.app.empresa.productos.Count;
                    elementoId = Program.app.empresa.suministros[tamanioProductos - 1].Id;
                }


                string fileName = $@"D:/{deposito}.txt";
                string directory = Path.GetDirectoryName(fileName);
                
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                FS = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                SW = new StreamWriter(FS);
                string registro;
                registro = $"{elementoId};{tipoProducto};{nombreProducto};{pasillo};{estanteria};{piso};{cantidad};{deposito}";
                SW.WriteLine(registro);
                SW.Close();
                FS.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en el proceso de guardado" + error);
            }
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
