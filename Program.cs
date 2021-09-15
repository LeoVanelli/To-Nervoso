using System;

namespace To_Nervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Peça ao usuário que ele digite o que pensa sobre esse programa. Exiba uma resposta em versão meme.
            
            Console.WriteLine("{0}, o que você pensa sobre mim? Você é muito sem graça! ",Environment.UserName);

            Console.Write("Digite a seguir sua resposta: ");
            string frase = Console.ReadLine();

            Console.WriteLine("- E sabe o que eu penso de você ?");
            Console.WriteLine("-{0}... NÃO, PERA.\n-Tô nervoso",frase.Remove(10));
        }
    }
}
