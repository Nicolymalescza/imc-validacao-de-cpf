using System;
using System.Drawing;
using System.Windows.Forms;
public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        double numero = 10;
        double soma = 0;

        if (cpf.Length == 11)
        {
            for (int i = 0; i < 9; i++)
            {            
                soma += Convert.ToInt32(cpf[i].ToString()) * numero;
                numero--;
            }

            if (soma % 11 < 2 && Convert.ToInt32(cpf[9].ToString()) != 0)
            {
                return false;
            }
            else if (soma >= 2)
            {
                double divisao = soma % 11;
                double resto = 11 - divisao;
                return true;
              
            }
            return true;
        }
        else
        {
            return false;
            
        }

        if (cpf.Length == 11)
        {
            numero = 11;
            double soma2 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma2 += Convert.ToInt32(cpf[i].ToString()) * numero;
                numero--;
            }

            if (soma2 % 11 < 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 0)
                {
                    return false;
                }
            }
            else if (soma2 >= 2)
            {
                double divisao = soma2 % 11;
                double resto = 11 - divisao;
                return true;

            }
            return true;
        }
        else
        {
            return false;

        }
    }
}