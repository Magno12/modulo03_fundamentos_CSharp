//Value Types na prática

using static System.Console;
public class Program
{

    public static void Demo04()
    {
        string nome = "Magno";

        TrocarNome(nome, "Magno Batista");

        WriteLine($@"O novo nome é {nome}");
        //a string e um referene type porem tem um comportamento diferente, como de value types
    }


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

    public static void Demo03()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 03,
            Nome = "Magno"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "Luiz Felipe");

        WriteLine($@"
            Nome do p1: {p1.Nome}

            Nome do p2: {p2.Nome}
        ");

    }

    public static void Demo02()
    {
        //
        Pessoa p1 = new Pessoa();
        p1.Nome = "Magno";
        p1.Idade = 27;
        p1.Documento = "1234";

        WriteLine("Dados Iniciais");
        WriteLine("Nome: " + p1.Nome + " Idade: " + p1.Idade + " Documento: " + p1.Documento);
        WriteLine("-----");

        /* 
        //recebeu uma referencia de p1 , se alterar valor de p1 a vera alteracao na p2
        Pessoa p2 = p1; 
         */

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "Magno Batista Rocha");

        WriteLine("Alterando Nome");

        WriteLine($@"
        Nome p1: {p1.Nome} 
        Nome p2: {p2.Nome}
        ");

    }
    public static void TrocarNome(Pessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        StructPessoa p = new StructPessoa();
        p.Nome = nomeNovo;
        p.Documento = p1.Documento;
        p.Idade = p1.Idade;
        return p;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    public static void Main()
    {
        //exemplo de referene type
        int[] pares = new int[] { 0, 2, 4, 6, 8 };

        MudarParaImpar(pares);

        WriteLine($"Os Impares : {string.Join(" , ", pares)} ");
    }

}