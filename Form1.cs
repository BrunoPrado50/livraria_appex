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

namespace livraria_appex
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
                    if (tbx_name.Text == "admin" || tbx_password.Text == "12345")
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
                    this.Close();
                }
                finally
                {
                    //this.Close();
                }
            }
        }
    }
}
