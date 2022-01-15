using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inderirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirCli ins = new InserirCli();
            ins.ShowDialog();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirProd add = new InserirProd();
            add.ShowDialog();

        }
    }
}
