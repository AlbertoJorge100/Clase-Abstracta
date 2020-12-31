using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImagenBytes.CLS;

namespace ImagenBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Automovil auto = new Automovil();            
            MostrarTransporte(new Motocicleta());
        }
        private void MostrarTransporte(MedioTransporte md)
        {
            switch (md.getOpcion())
            {
                case MedioTransporte.Opcion.AUTOMOVIL:
                    Automovil auto = (Automovil)md;
                    MessageBox.Show($"Marca de auto {auto.getMarca()}");
                    break;
                case MedioTransporte.Opcion.MOTOCICLETA:
                    Motocicleta moto = (Motocicleta)md;
                    MessageBox.Show($"Marca de moto {moto.getMarca()}");
                    break;
            }
        }
    }
}
