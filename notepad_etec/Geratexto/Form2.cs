using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geratexto
{
    public partial class Form2 : Form
    {
        String endereco;
        public Form2(String end)
        {
            InitializeComponent();
            endereco = end;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(endereco);
            this.Text = "Navegação";
        }
    }
}
