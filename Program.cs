namespace full_stoke;


class Program
{

    public static void Main(string[] args)
    {

        int n1 = 0, n2 = 0, n3 = 0, media = 0;
        char parabens = (char)0;


        Console.WriteLine("exame nacional do dani, prova final");
        Console.Write("Digite a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        media = (n1 + n2) / 2;

        if (media > 60)
        {
            Console.WriteLine(" voce Passou!");
        }
        else if (media == 60)
        {
            Console.WriteLine("Na média!");


        }
        if (media >= 80)

            Console.WriteLine(" muito bem ");

        else
        {
            Console.WriteLine("Rodou!");
        }

    }

    private static void readline(string v)
    {
        throw new NotImplementedException();
    }



}
