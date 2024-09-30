using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace livraria_appex
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Estabelecer conexao com banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Persist Security Info=True;User ID=senac;Password=senac;
Initial Catalog=db_livraria;Server=TAU0588426W10-1;Encrypt=False;");

        



//(autenticção windows) @"Data Source=TAU0588426W10-1;intergrated security=SSPI;initial Catalog=db_livraria"); // servidor = TAU0588426W10-1

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_saldar3_Click(object sender, EventArgs e)
        {
            
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbx_password_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_password.UseSystemPasswordChar = false;
        }

        private void pbx_password_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_password.UseSystemPasswordChar = true;
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if(tbx_name.Text == ""|| tbx_password.Text =="")
            {
                MessageBox.Show("Prencher nome e senha de usuario" , "Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try//Tentar
                {
                    cn.Open();
                    cm.CommandText= "select * from tbl_Atendente01 where ds_Login= ('"+tbx_name.Text+"') and ds_Senha= ('"+tbx_password.Text+"') and ds_status = 1";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();


                    if (dt.HasRows)
                    {
                     Formmenu menu = new Formmenu();
                     menu.Show();
                     this.Hide();
                    }
                    else
                    {
                     MessageBox.Show("Usuario ou senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbx_name.Clear();
                        tbx_password.Clear();
                        tbx_name.Focus();
                    }


                }
                catch(Exception erro)//Pegar
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                   cn.Close();

                   //old->this.Close();
                }
            }
        }
    }
}
