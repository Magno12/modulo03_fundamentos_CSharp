//Value Types na prática

using static System.Console;
public class Program
{

    static int Adicionar20(int x)
    {
        return x = x + 20;
    }
    public static void Main()
    {
        int a = 2;
        Adicionar20(a);
        a = Adicionar20(a);

        WriteLine($" O valor da variável A e : {a} "); // ao importa o System.Console podemos chamar direto o WriteLine
    }

}