using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class FrmCalculadora : Form
    {

        private Conversao conversao { get; set; }
        public FrmCalculadora()
        {

            conversao = new Conversao();
            InitializeComponent();
        }

        private void txtNumeroArabico_KeyPress(object sender, KeyPressEventArgs e)
        {

            //MessageBox.Show(Convert.ToInt32(e.KeyChar).ToString());

            // Efetua o teste para não deixar entrar com uma informação que não seja númerica
            // 0 a 9
            if (!char.IsDigit(e.KeyChar))
            {
                if (Convert.ToInt32(e.KeyChar) != 8)
                   e.Handled = true;
            }

        }

        private void txtNumeroRomano_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Teste para deixar entrar somente letras que são referencia nos número romanos
            string caracter = e.KeyChar.ToString().ToUpper();

            var totalLinhas = conversao.ListaDePara.Find (x => x.NumeroRomano == caracter.ToUpper());
            if (totalLinhas == null)
            {
                e.Handled = true;
            }
             
        }

        private void txtNumeroRomano_TextChanged(object sender, EventArgs e)
        {
            // Converte os dados digitados para maiusculo e posiciona o cursor no final do campo
            txtNumeroRomano.Text = txtNumeroRomano.Text.ToUpper();
            txtNumeroRomano.SelectionStart = txtNumeroRomano.Text.Length;
        }

        private void btnConverterParaRomano_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumeroArabico.Text);
            if (numero > 3999)
            {
                MessageBox.Show("O maior número a ser trabalhdo é 3999");
                txtNumeroArabico.Focus();
                return;
            }
            txtNumeroRomano.Text = conversao.ConverterParaRomano(numero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 4000; i++)
            {
                txtResultado.AppendText("Número : " + i.ToString() + " - " + conversao.ConverterParaRomano(i) + "\r\n");
            }
        }
    }
}
