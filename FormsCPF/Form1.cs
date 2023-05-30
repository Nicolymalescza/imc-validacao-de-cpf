using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FormsCPF
{
    //alteração pra ver git e github
    //segunda alteração pra verificar
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lb_resultado1.Text = " ";
            lb_resultado2.Text = " ";
            lb_resultado3.Text = " ";
            lb_veriCpf.Text = " ";
            //MessageBox.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            int idade = Convert.ToInt32(tx_idade.Text);
            string sexo = comboB_sexo.Text;
            double altura = Convert.ToDouble(tx_altura.Text);
            double peso = Convert.ToDouble(tx_peso.Text);
        
            Pessoa imc = new Pessoa(nome, cpf, idade, sexo , altura , peso);
            (double a, string b, string c) = imc.CalcularIMC();
            bool resultadocpf = Validacoes.ValidaCPF(cpf);
            lb_resultado1.Text = $"Seu IMC é: {a.ToString("0.00")}";
            lb_resultado2.Text = $"Sua classificação é: {b}";
            lb_resultado3.Text = $"Seu grau é: {c}";


            MessageBox.Show(resultadocpf.ToString());
            if (resultadocpf == true)
            {
               lb_veriCpf.Text = $"Seu cpf é valido!";
            }
            else 
            {
                lb_veriCpf.Text = $"Seu cpf é inválido!";
            }  
        }
        
        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            mask_cpf.Clear();
            tx_idade.Clear();
            tx_altura.Clear();
            tx_peso.Clear();
            /*lb_resultado1.Clear();   Não consegui limpar, fica acusando que lb não recebe Clear
            lb_resultado2.Clear();
            lb_resultado3.Clear();*/
        }
    }
}
