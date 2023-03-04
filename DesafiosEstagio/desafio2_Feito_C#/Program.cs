internal class Program
{
    private static void Main(string[] args)
    {
        fibonachi();
    }

    private static void fibonachi()
    {

        int recebe, result = 0, anterior = 0, atual = 1;
        Console.WriteLine("Digite o numero da sequencia: ");
        recebe = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < recebe; i++)
        {
            result = anterior + atual;
            anterior = atual;
            atual = result;
            if (atual == recebe)
            {
                Console.WriteLine("{0} Pertence", result);
                break;
            }
        }
        if (atual != recebe)
        {
            Console.WriteLine("{0} Não pertence", atual);
        }
    }
}