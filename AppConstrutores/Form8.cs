using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConstrutores
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cimento = Convert.ToInt32(textCimento.Text);
            int cal = Convert.ToInt32(textCal.Text);
            int areia = Convert.ToInt32(textAreia.Text);
            int pedra = Convert.ToInt32(textPedra.Text);
            int cano = Convert.ToInt32(textCano.Text);
            int torneira = Convert.ToInt32(textTorneira.Text);
            int prego = Convert.ToInt32(textPrego.Text);
            int martelo = Convert.ToInt32(textMartelo.Text);
            int pa = Convert.ToInt32(textPa.Text);
            int carrinho = Convert.ToInt32(textCarrinho.Text);
            int op = Convert.ToInt32(textOp.Text);
        }
    }
}
