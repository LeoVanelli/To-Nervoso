using System;

namespace To_Nervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}, o que você pensa sobre mim? Você é muito sem graça! ",Environment.UserName);

            Console.Write("Digite a seguir sua resposta: ");
            string frase = Console.ReadLine();

            Console.WriteLine("- E sabe o que eu penso de você ?");
            Console.WriteLine("-{0}... NÃO, PERA.\n-Tô nervoso",frase.Remove(10));
        }
    }
}
