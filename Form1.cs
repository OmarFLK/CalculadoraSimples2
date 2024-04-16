using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        //método construtor da classe
        public Form1()
        {
            InitializeComponent();
        }
        //Enum = lista de coisas
        enum operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static operacoes ultimaOperacao = operacoes.Nenhuma;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != operacoes.Nenhuma)
            {
                Fzercalculo(ultimaOperacao);
            }
            ultimaOperacao = operacoes.Nenhuma;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                //textBoxDisplay.Text += "+";
                // == } Comparacao e = } Atribuição

                if (ultimaOperacao == operacoes.Nenhuma)
                {
                    ultimaOperacao = operacoes.Multiplica;
                }
                else
                {
                    Fzercalculo(ultimaOperacao);
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }


        }

        private void Fzercalculo(operacoes ultimaOperacao)
        {
            //double = numero real (1.2 , 1/3 etc...)
            List<double> listadenumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case operacoes.Soma:
                    listadenumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenumeros[0] + listadenumeros[1]).ToString();
                    break;
                case operacoes.Subtrai:
                    listadenumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenumeros[0] - listadenumeros[1]).ToString();
                    break;
                case operacoes.Multiplica:
                    listadenumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadenumeros[0] * listadenumeros[1]).ToString();
                    break;
                case operacoes.Divide:
                    try
                    {
                        listadenumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listadenumeros[0] / listadenumeros[1]).ToString();
                 
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case operacoes.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
     
        {
            textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
        }
        private int qtdVirgula = 0; 
        private void button2_Click(object sender, EventArgs e)
        {
            if (qtdVirgula > 0)
            {
                return;
            }
            else 
            {
                textBoxDisplay.Text += ",";
                qtdVirgula = 1;
            }
            
        }

        private void buttonapagar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = operacoes.Nenhuma;
        }

        private void buttonSubtrai_Click(object sender, EventArgs e)
        {
            {
                //textBoxDisplay.Text += "+";
                // == } Comparacao e = } Atribuição

                if (ultimaOperacao == operacoes.Nenhuma)
                {
                    ultimaOperacao = operacoes.Subtrai;
                }
                else
                {
                    Fzercalculo(ultimaOperacao);
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }

            
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text += "+";
            // == } Comparacao e = } Atribuição

            if (ultimaOperacao == operacoes.Nenhuma)
            {
                ultimaOperacao = operacoes.Soma;
            }
            else
            {
                Fzercalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
 
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            {
                //textBoxDisplay.Text += "+";
                // == } Comparacao e = } Atribuição

                if (ultimaOperacao == operacoes.Nenhuma)
                {
                    ultimaOperacao = operacoes.Divide;
                }
                else
                {
                    Fzercalculo(ultimaOperacao);
  
                }
                textBoxDisplay.Text += (sender as Button).Text;
            }
        }


        private void buttonNum_Click(object sender, EventArgs e)
        {
            //textBoxDisplay.Text += "0";
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void e3(object sender, EventArgs e)
        {

        }
    }
}
