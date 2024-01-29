namespace _02_Loops_DoWhile;

class Program
{
    static void Main(string[] args)
    {
        int counter = 10;
        
        // Цикл do-while выполняется до тех пор, пока условие является истиной
        do
        {
            counter++;
            Console.WriteLine($"Итерация {counter}");
        }
        while (counter < 10);

        Console.WriteLine($"Всего было {counter} итераций.");
        Console.ReadKey();
    }
}