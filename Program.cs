using System;

namespace sistemaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.peso = 75;
            pessoa.altura = 1.75;
            pessoa.Message();
        }
    }
}
