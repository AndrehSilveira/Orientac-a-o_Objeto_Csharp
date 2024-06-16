using System;

class Pessoa{
    // Atributos
    public double peso, altura;

    //Métodos
    public double IMC()
    {
        return peso / (altura * altura);
    }

    public string situacao(double IMC)
    {
        string retorno = "";
        if(IMC < 18.5)
            retorno = "Abaixo do peso";
        
        else if(IMC < 25)
            retorno = "Peso normal";

        else if(IMC < 30)
            retorno = "Acima do peso";

        else if(IMC < 35)
            retorno = "Obesidade I";

        else if(IMC < 40)
            retorno = "Obesidade II";

        else 
            retorno = "Obesidade III";

    return retorno;

    }

    public void mensagem()
    {
        // obtendo valor do IMC
        double obterIMC = IMC();

        //Obtendo a descrição do IMC
        string obterSituacao = situacao(obterIMC);

        // Montando a mensagem
        Console.WriteLine("O seu IMC é de " + obterIMC + " e sua situação é de " + obterSituacao);

    }
}