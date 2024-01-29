namespace _03_Loops_For;

class Program
{
    static void Main(string[] args)
    {
        // Цикл FOR выполняется, пока условие является истиной.
        // for ( Инициализация счетчика; Условие; Изменение счетчика ) { действия }
        // Счётчик доступен только внутри цикла.

        //for (int counter = 0; counter < 9; counter++)
        //{
        //    Console.WriteLine($"Counter = {counter}");
        //}


        // Нам необязательно указывать все условия при объявлении цикла:
        //int i = 0;
        //for (; ; )
        //{
        //    i++;
        //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        //}

        #region Вложенные циклы

        // Циклы могут находится внутри других циклов
        //for (int i = 0; i < 10; i = i+ 2)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        Console.Write($"{j} ");
        //    }

        //    Console.WriteLine();
        //}

        //int i = 0;
        //for (; ; )
        //{
        //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        //    i = i + 2;

        //    if(i > 10)
        //    {
        //        break;
        //    }
        //}

        //for(var j = 0; j<=10; j += 2)
        //{
        //    Console.WriteLine($"Квадрат числа {j} равен {j * j}");
        //}


        //while (true)
        //{
        //    while (true)
        //    {

        //    }
        //}

        #endregion
    }
}