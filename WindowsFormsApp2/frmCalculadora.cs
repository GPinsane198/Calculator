using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        int iNumeroUm;
        int iNumeroDois;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txtNumeroUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true; 
        }
        
        private void txtNumeroDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!= (char)8)
                e.Handled = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                Operacoes Operacao = new Operacoes();

                iNumeroUm = int.Parse(txtNumeroUm.Text);
                iNumeroDois = int.Parse(txtNumeroDois.Text);

                txtResultado.Text = (Operacao.Soma(iNumeroUm, iNumeroDois)).ToString();
            } catch (Exception ex)
            {
                txtNumeroUm.Clear();
                txtNumeroDois.Clear();
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                Operacoes Operacao = new Operacoes();

                iNumeroUm = int.Parse(txtNumeroUm.Text);
                iNumeroDois = int.Parse(txtNumeroDois.Text);

                txtResultado.Text = (Operacao.Subtracao(iNumeroUm, iNumeroDois)).ToString();
            } catch (Exception ex)
            {
                txtNumeroUm.Clear();
                txtNumeroDois.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                Operacoes Operacao = new Operacoes();

                iNumeroUm = int.Parse(txtNumeroUm.Text);
                iNumeroDois = int.Parse(txtNumeroDois.Text);

                txtResultado.Text = (Operacao.Divisao(iNumeroUm, iNumeroDois)).ToString();
            } catch (Exception ex)
            {
                txtNumeroUm.Clear();
                txtNumeroDois.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                Operacoes Operacao = new Operacoes();

                iNumeroUm = int.Parse(txtNumeroUm.Text);
                iNumeroDois = int.Parse(txtNumeroDois.Text);

                txtResultado.Text = (Operacao.Multiplicacao(iNumeroUm, iNumeroDois)).ToString();
            } catch (Exception ex)
            {
                txtNumeroUm.Clear();
                txtNumeroDois.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroUm.Clear();
            txtNumeroDois.Clear();
            txtResultado.Clear();
        }
    }
}
