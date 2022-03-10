using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Encrypt;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bEncryptar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtEncryptado.Text = CEncriptador.Encriptar(txtOrigen.Text);
        }

        private void Limpiar()
        {
            foreach(Control c in this.Controls)
                if ((c is TextBox )&&(c.Name!="txtOrigen"))
                   c.Text = "";
        }

        private void bDesencryptar_Click(object sender, EventArgs e)
        {
            txtDesencrytado.Text = CEncriptador.Desencriptar(txtEncryptado.Text);
        }
    }
}
