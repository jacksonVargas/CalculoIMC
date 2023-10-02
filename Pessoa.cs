using System;

class Pessoa
{
    public double peso, altura;

    public double Calculo()
    {
        return peso / (altura * altura);
    }

    public string Imc(double imc)
    {
        string resultado;

        if(imc < 18.5) 
        {
            resultado = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            resultado = "Peso normal";
        }
        else if(imc < 30)
        {
            resultado = "Acima do peso";
        }
        else if(imc < 35)
        {
            resultado = "Obesidade I";
        }
        else if(imc < 40)
        {
            resultado = "Obesidade II";
        }
        else
        {
            resultado = "Obesidade III";
        }

        return resultado;
    }

    public void Message()
    {
        double calculoFinal = Calculo();
        string imc = Imc(calculoFinal);

        Console.WriteLine("Seu IMC é: " + calculoFinal);
        Console.WriteLine("Sua situação atual: " + imc);
    }
}