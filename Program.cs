using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //sem argumentos
            Produto fone = new Produto();

            //com 1 argumento
            Produto headset  = new Produto("Razer");
            System.Console.WriteLine(headset.Nome);


            //com varios argumentos
            Produto phone = new Produto("JBL","Headphone",256,"Preto");
            System.Console.WriteLine(phone.Nome);
            System.Console.WriteLine(phone.Tipo);
            System.Console.WriteLine(phone.Valor);
            System.Console.WriteLine(phone.Cor);

        }
    }
}

