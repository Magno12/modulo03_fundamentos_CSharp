//Value Types na prática

using static System.Console;
public class Program
{


    //aula 04 values types
    /*  static int Adicionar20(int x)
     {
         return x = x + 20;
     }
     public static void Main()
     {
         int a = 2;
         Adicionar20(a);
         a = Adicionar20(a);

         WriteLine($" O valor da variável A e : {a} "); // ao importa o System.Console podemos chamar direto o WriteLine
     } */

    //Aula 05 reference types na pratica

    public static void _AlterarNome(Pessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
    }

    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Magno";
        p1.Idade = 27;
        p1.Documento = "1234";

        WriteLine("Dados Iniciais");
        WriteLine("Nome: " + p1.Nome + " Idade: " + p1.Idade + " Documento: " + p1.Documento);
        WriteLine("-----");

        _AlterarNome(p1, "Magno Batista Rocha");
        WriteLine("Alterando Nome");
        WriteLine($"Nome: {p1.Nome}, Idade: {p1.Idade}, Documento ${p1.Documento} ");

    }

}   