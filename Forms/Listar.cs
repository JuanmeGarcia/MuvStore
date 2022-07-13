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

namespace MuvStore.Forms
{
    public partial class Listar : Form
    {
        public Listar()
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

        private void lstTemperley_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

