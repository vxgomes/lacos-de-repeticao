using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listafor.Items.Add(1);
            //listafor.Items.Add(2);
            //listafor.Items.Add(3);
            //listafor.Items.Add(4);
            //listafor.Items.Add(5);
            //listafor.Items.Add(6);
            //listafor.Items.Add(7);
            //listafor.Items.Add(8);
            //listafor.Items.Add(9);
            //listafor.Items.Add(10);

            for(int valor = 0; valor <= 10; valor++)
        {
           listafor.Items.Add(valor); 
        }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //for (int valor = 0; valor <= 10; valor++)
            //{
            //    listafor.Items.Add(valor);
            //}
            for(int valor =0; valor <= 10;valor+=2)
            {
                listafor.Items.Add(valor);
            }
        }
    }
}
