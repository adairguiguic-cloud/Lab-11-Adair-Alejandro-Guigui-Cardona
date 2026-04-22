using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1 ===");
        Console.Write("Contraseña: ");
        string p = Console.ReadLine();
        validar(p);
        Console.WriteLine();

        Console.WriteLine("=== 2 ===");
        Console.Write("Texto: ");
        string t = Console.ReadLine();
        Console.WriteLine("Invertido: " + invertir(t));
        Console.WriteLine();

        Console.WriteLine("=== 3 ===");
        Console.Write("Cantidad: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Num " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }
        stats(a);
        Console.WriteLine();

        Console.WriteLine("=== 4 ===");
        int[] b = new int[8];
        for (int i = 0; i < 8; i++)
        {
            Console.Write("Num " + (i + 1) + ": ");
            b[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Buscar: ");
        int x = int.Parse(Console.ReadLine());
        buscar(b, x);
        Console.WriteLine();

        Console.WriteLine("=== 5 ===");
        string[] nom = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nom[i] = Console.ReadLine();
        }
        analizar(nom);
    }

    static void validar(string p)
    {
        string e = "";
        if (p.Length < 8) e += "corta, ";

        bool m = false, num = false, esp = false;

        for (int i = 0; i < p.Length; i++)
        {
            char c = p[i];
            if (c >= 'A' && c <= 'Z') m = true;
            if (c >= '0' && c <= '9') num = true;
            if (c == '@' || c == '#' || c == '$' || c == '%') esp = true;
        }

        if (!m) e += "sin mayúscula, ";
        if (!num) e += "sin número, ";
        if (!esp) e += "sin especial, ";

        if (e == "")
        {
            Console.WriteLine("OK");
        }
        else
        {
            e = e.Substring(0, e.Length - 2);
            Console.WriteLine("Error: " + e);
        }
    }

    static string invertir(string t)
    {
        string r = "";
        for (int i = t.Length - 1; i >= 0; i--)
        {
            r += t[i];
        }
        return r;
    }

    static void stats(int[] a)
    {
        int s = 0, max = a[0], min = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            s += a[i];
            if (a[i] > max) max = a[i];
            if (a[i] < min) min = a[i];
        }

        double prom = (double)s / a.Length;
        Console.WriteLine("Suma: " + s + " Prom: " + prom + " Max: " + max + " Min: " + min);
    }

    static void buscar(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
            {
                Console.WriteLine("Está en pos " + i);
                return;
            }
        }
        Console.WriteLine("No está");
    }

    static void analizar(string[] n)
    {
        int c = 0;
        string largo = n[0];

        Console.Write("Lista: ");
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i]);
            if (i < n.Length - 1) Console.Write(", ");

            if (n[i].Length > 5) c++;
            if (n[i].Length > largo.Length) largo = n[i];
        }

        Console.WriteLine();
        Console.WriteLine("Largos: " + c + " | Mayor: " + largo);
    }
}