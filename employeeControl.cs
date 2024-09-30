using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace livraria_appex
{
    public partial class employeeControl : UserControl
    {
        public employeeControl()
        {
            InitializeComponent();

        }
        //Estabelecer conexao com banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;
Initial Catalog=db_livraria;Server=TAU0588426W10-1;Encrypt=False;");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void DesabitaCampos()
        {

            btn_novo.Enabled = true;
            tbx_nome_employe.Enabled = false;
            tbx_login_employe.Enabled = false;
            tbx_senha_employe.Enabled = false;
            //btn_gravar.Enabled = false;
            btn_alterar.Enabled = false;
            btn_remover.Enabled = false;
            btn_cancelar.Enabled = false;

        }

        private void HabilitaCampos()
        {
            tbx_nome_employe.Enabled = true;
            tbx_login_employe.Enabled = true;
            tbx_senha_employe.Enabled = true;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            //REVISAR/ CONCERTAT     AKI AKI AKI AKI
            tbx_nome_employe.Focus();
            tbx_pesquisaF.Text = "";
            //dgv_tabela.DataSource

        }

        private void limparCampos()
        {
            tbx_nome_employe.Text = " ";
            tbx_login_employe.Text = string.Empty;
            tbx_senha_employe.Clear();
            tbx_nome_employe.Focus();
            tbx_pesquisaF.Clear();
            dgv_tabela.DataSource = null;
            rbtn_ativo_employe.Checked = true;
            lbl_cod_zu.Visible = false;
        }
        private void manipularDados()
        {
            lbl_cod_zu.Visible = true;
            lbl_codigo.Visible = true;
            tbx_nome_employe.Enabled = true;
            tbx_login_employe.Enabled = true;
            tbx_senha_employe.Enabled = true;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_remover.Enabled = true;
            btn_alterar.Enabled = true;
            btn_novo.Enabled = false;
          
        }

        private void tbx_nome_employe_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeControl_Load(object sender, EventArgs e)
        {
            DesabitaCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabitaCampos();
            limparCampos();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tbx_nome_employe.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo Nome", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_login_employe.Focus();
            }
            else if (tbx_login_employe.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o campo 'Login'", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_login_employe.Focus();
            }
            else if (tbx_senha_employe.Text == " ")
            {
                MessageBox.Show("Obrigatorio informar o campo Senha","Senha" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if(tbx_senha_employe.Text.Length<8)//Length(conta caracteres) ,o computar começa a contar apartir do '0' então '<8' = '01234567'
            {
                MessageBox.Show("Obrigatorio ter no mínimo 8 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if (rbtn_inativo_employe.Checked)
            {
                MessageBox.Show("Impossivel gravar um funcionario se o STATUS estiver INATIVO", "erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    //MUITO IMPORTANTE
                    string nome = tbx_nome_employe.Text;
                    string login = tbx_login_employe.Text;
                    string senha = tbx_senha_employe.Text;

                    string strSql = "insert into tbl_atendente01(ds_Login,ds_Senha,mn_atendente,ds_status)vaules(@login,@senha,@atendente,1)"; //@nome

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                   // SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;// essa estrutura deve ser do mesmo tipo q esta na tabela/banco de dados
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                  //cm.Parameters.AddwithValue("@login",tbx_login_employe.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram gravados", "Inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbx_senha_employe.Focus();
                    limparCampos();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                    //Extremamente importante;
                }
            }


            /* (codigo_excluido)
            if (tbx_nome_employe.Text == "" || tbx_senha_employe.Text == "")
            {
                MessageBox.Show("Prencher nome e senha de usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }

        private void tbx_senha_employe_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_pesquisaF_TextChanged(object sender, EventArgs e)
        {
            if(tbx_pesquisaF.Text!= "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente01 where nm_atendente like ('%"+tbx_pesquisaF.Text+"%')";
                    cm.Connection = cn;

                    //Receber dados de uma tabela após uma execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //Objeto para representar uma ou mais tabela de dados
                    // quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    //metodo ou função responsavel como o ato dee abrir os DataTable
                    da.Fill(dt);//Prenechimento do DataTable
                    dgv_tabela.DataSource = dt;
                    cn.Close(); 
                }
                catch(Exception error) 
                {
                    MessageBox.Show(error.Message);
                }
               
            }
            else
            {
                dgv_tabela.DataSource = null;
   
            }
        }

        private void carregaAtendente()
        {
            lbl_cod_zu.Text = dgv_tabela.SelectedRows[0].Cells[0].ToString();
            tbx_nome_employe.Text = dgv_tabela.SelectedRows[0].Cells[1].ToString();
            tbx_login_employe.Text = dgv_tabela.SelectedRows[0].Cells[2].ToString();
            tbx_senha_employe.Text = dgv_tabela.SelectedRows[0].Cells[3].ToString();
            string valor = dgv_tabela.SelectedRows[0].Cells[4].Value.ToString();
            if(valor == "True")
            {
                rbtn_ativo_employe.Checked = true;

            }
            else
            {
                rbtn_inativo_employe.Checked = true;
            }

            manipularDados();
        }

        private void dgv_tabela_DoubleClick(object sender, EventArgs e)
        {
            carregaAtendente();
            if (rbtn_ativo_employe.Checked)
            {
                btn_remover.Enabled = true;
            }
            else
            {
                btn_remover.Enabled = false;
            }
        }

        private void lbl_emplyee_control_Click(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (tbx_nome_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_nome_employe.Focus();
            }
            else if (tbx_login_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Login'", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_login_employe.Focus();
            }
            else if (tbx_senha_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Senha'", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if (tbx_senha_employe.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório ter no mínimo 8 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if (rbtn_ativo_employe.Checked)
            {
                MessageBox.Show("Para remover o registro voce prescisa alterar o status para inativo", "erro ao tentar excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover o registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); // MessageBoxIcon. information -> exclamation
                if(exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lbl_cod_zu.Text);
                        cn.Open();
                        string strSQL = "update tbl_atendente01 set ds_status = 0 where cd_atendente=@cd";
                        cm.CommandText = strSQL;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        MessageBox.Show("A exclusão foi executada com sucesso!!!", "Exclusão de registro concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbx_nome_employe.Focus();
                        limparCampos();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (tbx_nome_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_nome_employe.Focus();
            }
            else if (tbx_login_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Login'", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_login_employe.Focus();
            }
            else if (tbx_senha_employe.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Senha'", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if (tbx_senha_employe.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório ter no mínimo 8 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_senha_employe.Focus();
            }
            else if (rbtn_inativo_employe.Checked)
            {
                MessageBox.Show("Para inativar um funcionario é presciso clicar no botão remover", "erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string nome = tbx_nome_employe.Text;
                    string login = tbx_login_employe.Text;
                    string senha = tbx_senha_employe.Text;
                    int cd = Convert.ToInt32(lbl_cod_zu.Text);

                    string strSql = "update tbl_atendente1 set ds_login=@login, ds_senha=@senha, nm_atendente=@nome , ds_status=1 where cd_atendente=@cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    //SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Clear();

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                    //cm.Parameters.AddWithValue("@Login",tbxLogin.Text);
                    //cm.Parameters.AddWithValue("@Login",login);

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram alterados com sucesso", "Alteração de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    tbx_nome_employe.Focus();
                    limparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }

            }
        }
    }
}
