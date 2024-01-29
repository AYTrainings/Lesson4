namespace _05_Loops_Break;

class Program
{
    static void Main(string[] args)
    {
        #region break

        // break - завершает текущую операцию и выходит из цикла
        //int counter = 0;
        //while (counter < 7)
        //{
        //    counter++;

        //    if (counter == 5)
        //    {
        //        break;
        //    }

        //    Console.WriteLine($"Итерация {counter}");
        //}

        //Console.WriteLine($"Всего было {counter} итераций.");

        #endregion

        #region continue

        // continue - завершает текущую итерацию и переходит на следующую
        //int counter = 0;
        //while (counter < 7)
        //{
        //    counter++;

        //    if (counter == 5)
        //    {
        //        continue;
        //    }

        //    Console.WriteLine($"Итерация {counter}");
        //}

        //Console.WriteLine($"Всего было {counter} итераций.");

        #endregion

        #region return

        // return - завершает метод, тем самым завершая итерацию и цикл
        int counter = 0;
        while (counter < 7)
        {
            counter++;

            if (counter == 5)
            {
                return;
            }

            Console.WriteLine($"Итерация {counter}");
        }

        Console.WriteLine($"Всего было {counter} итераций.");

        #endregion
    }
}