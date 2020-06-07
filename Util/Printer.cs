using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DrawLine(tamaño);
            WriteLine($"| {titulo.ToUpper()} |");
            DrawLine(tamaño);
        }
    }
}