namespace Uppgift_5._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(0, 9);
            }
            string distinctValue = "";
            int count = 0;
            foreach (int i in t.Distinct())
            {
                var currentCount = t.Count(x => x.Equals(i));
                if (currentCount > count)
                {
                    count = currentCount;
                    distinctValue = i.ToString();
                }

            }
            PrintArray(t, int.Parse(distinctValue));
            Console.WriteLine($"Det vanligaste värdet är {distinctValue} och det uppkommer {count} gånger.");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Tryck ESC för att avsluta");
            }
        }
        static void PrintArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i < array.Length - 1)
                {
                    Console.Write(array[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}