using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuvStore;
using uai_proyect;
using MuvStore.enums;

namespace MuvStore
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Program.app.CargarElementos(Depositos.lomas_de_zamora);
            Program.app.CargarElementos(Depositos.temperley);
            Program.app.CargarElementos(Depositos.adrogue);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            PBStart.Value++;
            if (PBStart.Value == 99)
            {
                timer1.Stop();
                MainForm mainFrm = new MainForm();
                mainFrm.Show();
                this.Hide();
            }
        }

        private void panelLoading_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


    }
}
