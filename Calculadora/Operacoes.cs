using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Operacoes
    {
        public int iResultado { get; set; }

        public int Soma(int iNumeroUmOperacao, int iNumeroDoisOperacao)
        {
            if (iNumeroUmOperacao == 0 || iNumeroDoisOperacao == 0)
            {
                throw new Exception("Insira apenas números maiores que ZERO.");
            }
            return iNumeroUmOperacao + iNumeroDoisOperacao;
        }

        public int Subtracao(int iNumeroUmOperacao, int iNumeroDoisOperacao)
        {
            if (iNumeroUmOperacao == 0 || iNumeroDoisOperacao == 0)
            {
                throw new Exception("Insira apenas números maiores que ZERO.");
            }
            if (iNumeroUmOperacao < iNumeroDoisOperacao)
            {
                throw new Exception("Primeiro número é menor que o segundo.");
            }
            return iNumeroUmOperacao - iNumeroDoisOperacao;
        }

        public int Divisao(int iNumeroUmOperacao, int iNumeroDoisOperacao)
        {
            if (iNumeroUmOperacao == 0 || iNumeroDoisOperacao == 0)
            {
                throw new Exception("Insira apenas números maiores que ZERO.");
            }
            return iNumeroUmOperacao / iNumeroDoisOperacao;
        }

        public int Multiplicacao(int iNumeroUmOperacao, int iNumeroDoisOperacao)
        {
            if (iNumeroUmOperacao == 0 || iNumeroDoisOperacao == 0)
            {
                throw new Exception("Insira apenas números maiores que ZERO.");
            }
            return iNumeroUmOperacao * iNumeroDoisOperacao;
        }
    }
}
