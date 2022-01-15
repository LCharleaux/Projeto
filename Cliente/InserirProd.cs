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
    public partial class InserirProd : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strsql;

        public InserirProd()
        {
            InitializeComponent();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "INSERT INTO PRODUTOS (Cod_Prod, Nome_Prod, Quant_Prod, Valor_Unit) values(@Cod_Prod, @Nome_Prod, @Quant_Prod, @Valor_Unit)";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Cod_Prod", txt_codprod.Text);
                comando.Parameters.AddWithValue("@Nome_Prod", txt_produto.Text);
                comando.Parameters.AddWithValue("@Quant_Prod", txt_quantidade.Text);
                comando.Parameters.Add("@Valor_Unit", SqlDbType.Int).Value = decimal.Parse(txt_valor.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
            }

            txt_codprod.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();

        }

        private void listar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "SELECT * FROM PRODUTOS ORDER BY Cod_Prod";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strsql, conexao);

                conexao.Open();

                da.Fill(ds);

                DgvDados.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;

            }

            txt_codprod.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();

        }

        private void selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "SELECT * FROM PRODUTOS WHERE Cod_Prod = @Cod_Prod";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Cod_Prod", txt_codprod.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txt_produto.Text = (string)dr["nome_prod"];
                    txt_quantidade.Text = Convert.ToString(dr["quant_prod"]);
                    txt_valor.Text = Convert.ToString(dr["valor_unit"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "UPDATE PRODUTOS SET Nome_Prod = @Nome_Prod, Quant_Prod = @Quant_Prod, Valor_Unit = @Valor_Unit WHERE Cod_Prod = @Cod_Prod";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Cod_Prod", txt_codprod.Text);
                comando.Parameters.AddWithValue("@Nome_Prod", txt_produto.Text);
                comando.Parameters.AddWithValue("@Quant_Prod", txt_quantidade.Text);
                comando.Parameters.Add("@Valor_Unit", SqlDbType.Int).Value = decimal.Parse(txt_valor.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
            }

            txt_codprod.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "DELETE PRODUTOS WHERE Cod_Prod = @Cod_Prod";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Cod_Prod", txt_codprod.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
            }

            txt_codprod.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();

        }

    
    }
    
}
