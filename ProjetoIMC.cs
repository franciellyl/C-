/*
Project: Sistema básico de cálculo de IMC
Author: Francielly Lima
Date: 11/05/2019
Description: Classe que calcula o imc (indíce de massa corporal) de uma pessoa e apresenta se está acima, abaixo ou no peso ideal.
*/

using System;
using System.Windows.Forms;

namespace ProjetoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_resultado_imc_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = Convert.ToDouble(textAltura.Text);
            peso = double.Parse(textPeso.Text);

            //imc = peso / altura * altura
            imc = peso / Math.Pow(altura,2);
            label_resultado_imc.Text = imc.ToString();
            if (imc < 19)
                label_situacao.Text = "Abaixo do Peso.";
            else if (imc < 25)
                label_situacao.Text = "Peso Ideal.";
            else
                label_situacao.Text = "Acima do Peso.";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
