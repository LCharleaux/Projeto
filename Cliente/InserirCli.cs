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
    public partial class InserirCli : Form {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strsql;


        public InserirCli()
        {
            InitializeComponent();

        }



        private void Inserir_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e) {

            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "INSERT INTO CLIENTES (Nome, Cod_Cli, Cpf, Telefone) values(@Nome, @Cod_Cli, @Cpf, @Telefone)";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@Cod_Cli", txt_codcli.Text);
                comando.Parameters.AddWithValue("@Cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@Telefone", txt_telefone.Text);

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

            txt_nome.Clear();
            txt_codcli.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();

            

        }
        
        private void listar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "SELECT * FROM CLIENTES ORDER BY Cod_Cli";

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

            txt_nome.Clear();
            txt_codcli.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();

        }

        private void selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "SELECT * FROM CLIENTES WHERE Cod_Cli = @Cod_Cli";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Cod_Cli", txt_codcli.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txt_nome.Text = (string)dr["nome"];
                    txt_cpf.Text = (string)dr["CPF"];
                    txt_telefone.Text = (string)dr["telefone"];
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

                strsql = "UPDATE CLIENTES SET Nome = @Nome, Cpf = @Cpf, Telefone = @Telefone WHERE Cod_Cli = @Cod_Cli";

                comando = new SqlCommand(strsql, conexao);

                comando.Parameters.AddWithValue("@Nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@Cod_Cli", txt_codcli.Text);
                comando.Parameters.AddWithValue("@Cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@Telefone", txt_telefone.Text);

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

            txt_nome.Clear();
            txt_codcli.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();

        }

        private void excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=RUSBE\SQLEXPRESS ;Database=LojaConv;Trusted_Connection=True;");

                strsql = "DELETE CLIENTES WHERE Cod_Cli = @Cod_Cli";

                comando = new SqlCommand(strsql, conexao);
                    
                comando.Parameters.AddWithValue("@Cod_Cli", txt_codcli.Text);


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

            txt_nome.Clear();
            txt_codcli.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();

        }
    }
}