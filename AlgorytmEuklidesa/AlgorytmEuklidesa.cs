internal class AlgorytmEuklidesa
{
    public static int euklides(int a, int b)
    {
        while(a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        return a;
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Wprowadź pierwszą liczbę: ");

        // sprawdza czy wprowadzona liczba jest liczbą całkowitą i dodatnią
        if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
        {
            Console.WriteLine("Niepoprawna wartość");
            return;
        }


        System.Console.WriteLine("Wprowadź drugą liczbę: ");

        // sprawdza czy wprowadzona liczba jest liczbą całkowitą i dodatnią
        if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0)
        {
            Console.WriteLine("Niepoprawna wartość");
            return;
        }


        Console.WriteLine($"NWD liczb {a} i {b} wynosi {euklides(a, b)}");
    }
}