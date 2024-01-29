namespace _04_Loops_Foreach;

class Program
{
    static void Main(string[] args)
    {
        // Цикл foreach перебирает коллекции, например, массивы.
        int[] array = new int[5];
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

    }
}