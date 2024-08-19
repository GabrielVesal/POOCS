using System;

class Pessoa
    {
    //atributos
    public double peso, altura;

    //metodo
    public double calculo()
    {
        return peso / (altura*altura);
    }

    //calculo
    public string situacao(double imc){
        //variavel
        string retorno;

        //condicional
        if(imc<18.5)
        {
            retorno = "Abaixo do peso";
        }else if(imc<25)
        {
            retorno = "Peso normal";
        }else if(imc<30)
        {
            retorno = "Acima do peso";
        }else if(imc<35)
        {
            retorno = "Obesidade I";
        }else if(imc<40)
        {
            retorno = "Obesidade II";
        }else 
        {
            retorno = "Obesidade III";
        }

        //retorno
        return retorno;

        
    }

    // mensagem
    public void mensagem()
    {
        //obter o caclulo
        double obterCalculo = calculo();

        //obter situação
        string obterSituacao = situacao(obterCalculo);

        //exibir mensagem
        Console.WriteLine("Seu IMC é de "+obterCalculo);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }


}

