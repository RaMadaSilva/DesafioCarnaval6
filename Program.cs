using System.Text;
namespace DesafioCarnaval6;
class Program
{
    private static readonly Dictionary<char, char> codigos = new(){{'a', 'K'}, {'b', 'R'}, {'c', 'V'}, {'d', 'A'}, {'e', 'L'}, {'f', 'U'},
    {'g', 'I'}, {'h', 'R'}, {'i', 'M'}, {'j', 'S'}, {'k', 'P'}, {'l', 'B'}, {'m', 'Y'}, {'n', 'J'}, {'o', 'D'}, {'p', 'C'}, {'q', 'E'},
    {'r', 'T'}, {'s', 'F'}, {'t', 'W'}, {'u', 'Z'}, {'v', 'G'}, {'w', 'N'}, {'y', 'H'}, {'z', 'O'}, {'0', '#'}, {'1', '!'}, {'2', '$'},
    {'3', '%'}, {'4', '&'}, {'5', '|'}, {'6', '='}, {'7', '*'}, {'8', '/'}, {'9', '<'}};
    static void Main(string[] args)
    {
        Console.Write("Escreva um testo: ");
        var testo = Console.ReadLine();
        if (testo.Trim() == string.Empty)
        {
            Console.WriteLine("Não escreveste nada!");
        }
        else
        {
            char[] letras = testo.ToCharArray();
            string testoEncriptado = Encriptar(letras);
            Console.WriteLine(testoEncriptado.ToUpper());
        }

    }

    private static string Encriptar(char[] letras)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in letras)
        {
            foreach (var codigo in codigos)
            {
                if (item == codigo.Key)
                {
                    sb.Append(codigo.Value);
                }
            }
        }
        return sb.ToString();
    }
}