namespace _01_Loops_While;

class Program
{
    //1. YAGNI
    //   You Aren’t Gonna Need It / Вам это не понадобится

    //2. DRY
    //   Don’t Repeat Yourself / Не повторяйтесь

    //3. KISS
    //   Keep It Simple, Stupid / Будь проще


    static void Main(string[] args)
    {
        int counter = 10;
        
        // Цикл while выполняется до тех пор, пока условие является истиной
        while (counter < 10)
        {
            counter++; 
            Console.WriteLine($"Итерация {counter}");
        }
        //

        Console.WriteLine($"Всего было {counter} итераций.");
        Console.ReadKey();
    }
}