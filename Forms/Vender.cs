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

namespace MuvStore.Forms
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
            
        }
        
        private void listar(Depositos depositos)
        {
            try
            {
                FileStream Fs = new FileStream($@"D:\{depositos}.txt", FileMode.OpenOrCreate);
                StreamReader SR = new StreamReader(Fs);

                string[] vectorRegristro;
                string registro;
                string _id, producto, estanteria, nivel, cantidad, pasillo, tipoProducto;
                lstProductos.Items.Clear();
                while (!(SR.Peek() == -1))
                {
                    registro = SR.ReadLine();
                    vectorRegristro = registro.Split(';');
                    _id = vectorRegristro[0];
                    tipoProducto = vectorRegristro[1];
                    producto = vectorRegristro[2];
                    pasillo = vectorRegristro[3];
                    estanteria = vectorRegristro[4];
                    nivel = vectorRegristro[5];
                    cantidad = vectorRegristro[6];

                    ListViewItem ls = new ListViewItem(_id);
                    ls.SubItems.Add(tipoProducto);
                    ls.SubItems.Add(producto);
                    ls.SubItems.Add(pasillo);
                    ls.SubItems.Add(estanteria);
                    ls.SubItems.Add(nivel);
                    ls.SubItems.Add(cantidad);
                    lstProductos.Items.Add(ls);
                }
                SR.Close();
                Fs.Close();
            }
            catch
            {
                MessageBox.Show("Todavia no se ha inscripto ningun alumno en esta sala", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        public void ModificarProducto(Depositos depositos)
        {
            string fileName = $@"D:\{depositos}.txt";
            string fileNameCopy = $@"D:\{depositos}_copy.txt";

            FileStream FS = new FileStream(fileName, FileMode.Open);
            FileStream FSCopy = new FileStream(fileNameCopy, FileMode.Create);
            StreamReader SR = new StreamReader(FS);
            StreamWriter SW = new StreamWriter(FSCopy);

            string[] vectorRegistro;
            string id;
            string registro;

            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorRegistro = registro.Split(';');
                id = vectorRegistro[0];
                
                string venta = (Convert.ToInt32(vectorRegistro[6]) - Convert.ToInt32(txtCantidad.Text)).ToString();
                if (id == labelId.Text)
                {
                    if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(registro[6]))
                    {
                        MessageBox.Show("No hay suficiente stock");
                        SR.Close();
                        SW.Close();
                        FS.Close();
                        FSCopy.Close();
                        File.Delete(fileName);
                        File.Move(fileNameCopy, fileName);
                        listar(depositos);
                        return;
                    }
                        registro = $"{id};{vectorRegistro[1]};{vectorRegistro[2]};{vectorRegistro[3]};{vectorRegistro[4]};{vectorRegistro[5]};{venta};{vectorRegistro[7]}";
                }

                SW.WriteLine(registro);
            }

            SR.Close();
            SW.Close();
            FS.Close();
            FSCopy.Close();
            File.Delete(fileName);
            File.Move(fileNameCopy, fileName);
            listar(depositos);
        }

        private void btnVenderLomas_Click(object sender, EventArgs e)
        {
            if (cmbDeposito.SelectedIndex == 0)
            {
                ModificarProducto(Depositos.lomas_de_zamora);
            }

            if (cmbDeposito.SelectedIndex == 1)
            {
                ModificarProducto(Depositos.temperley);
            }

            if (cmbDeposito.SelectedIndex == 2)
            {
                ModificarProducto(Depositos.adrogue);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItems.Count > 0)
            {
                ListViewItem ls = lstProductos.SelectedItems[0];
                labelId.Text = ls.Text;
                txtProducto.Text = ls.SubItems[2].Text;
                txtCantidad.Text = ls.SubItems[6].Text;
            }
        }

        private void cmbDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeposito.SelectedIndex == 0)
            {
                listar(Depositos.lomas_de_zamora);
            }
            if (cmbDeposito.SelectedIndex == 1)
            {
                listar(Depositos.temperley);
            }
            if (cmbDeposito.SelectedIndex == 2)
            {
                listar(Depositos.adrogue);
            }
        }
    }
}
