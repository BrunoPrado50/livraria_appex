using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria_appex
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            employeeControl1.BringToFront();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            clientControl1.BringToFront();
        }

        private void clientControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
