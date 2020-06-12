using System;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa marcelo = new Pessoa(48551215);
            Console.WriteLine(marcelo.Rg);
            System.Console.WriteLine( );
            Pessoa murilo = new Pessoa("Murilo");
            System.Console.WriteLine(murilo.Nome);
            System.Console.WriteLine( );
            Pessoa Breno = new Pessoa(456123564, "Breno", "Russo", 456648631);
            System.Console.WriteLine( );
            System.Console.WriteLine(Breno.Nome + " " + Breno.SobreNome + " " + Breno.Cpf + " " + Breno.Rg );
            

        }
    }
}
