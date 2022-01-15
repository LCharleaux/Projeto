using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

        public Login()
        {
            InitializeComponent();
            txt_usuario.Select();  
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string strsql = "SELECT * FROM USUARIO WHERE Usuario = '" + txt_usuario.Text + "' AND Senha = '" + txt_senha.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(strsql, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                Principal form1 = new Principal();
                this.Hide();
                form1.Show();
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta","ERRO", MessageBoxButtons.OK);
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_usuario.Select();
                conexao.Close();
            }
             
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
