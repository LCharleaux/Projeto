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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            carregamento.Increment(2);

            if(carregamento.Value == 100)
            {
                timer.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
