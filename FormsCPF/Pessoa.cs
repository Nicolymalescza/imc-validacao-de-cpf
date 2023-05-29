using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class Pessoa
{
    private string nome;//variaveis globais
    private string cpf;
    private int idade;
    private string sexo;
    private double altura;
    private double peso;
     
  
    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }


    public string GetCpf()
    {
        return this.cpf;
    }
    public void SetCpf(string cpf)
    {
        this.nome = cpf;
    }


    public int GetIdade()
    {
        return this.idade;
    }
    public void SetIdade(int idade)
    {
        this.idade = idade;
    }


    public string GetSexo()
    {
        return this.sexo;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }


    public double GetAltura()
    {
        return this.altura;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

    public double GetPeso()
    {
        return this.peso;
    }
    public void SetPeso(double peso)
    {
        this.peso = peso;
    }

    public Pessoa(string nome, string cpf, int idade, string sexo, double altura, double peso)//variaveis locais
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.altura = altura;
        this.peso = peso;
    }

    public (double,string,string) CalcularIMC()
    {
       double conta = peso / Math.Pow(altura,2);
        
        if (conta < 18.5)
        {
            return (conta, "MAGREZA", "0");
        }
        else if(conta >= 18.5 && conta <= 24.9)
        {
            return (conta, "NORMAL", "0");
        }
        else if(conta >= 25.0 && conta <= 29.9)
        {
            return (conta, "SOBREPESO", "I");
        }
        else if(conta >= 30.0 && conta <= 39.9)
        {
            return (conta, "OBESIDADE", "II");
        }
        else
        { 
            return (conta, "OBESIDADE GRAVE", "II");
        }
    }      
}