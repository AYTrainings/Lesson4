using System;
using System.Drawing;
using System.Globalization;

namespace _07_Bits;

class Program
{

    enum SortDirection : ushort
    {
        Default,
        Reverse,
        Ascending,
    }

    [Flags]
    enum ApplicationOptions: int
    {
        IsConsolered = 2,
        WriteHellow = 4
    }

    static void Main(string[] args)
    {
        SetUpSettings(ApplicationOptions.IsConsolered | ApplicationOptions.WriteHellow);


        void SetUpSettings(ApplicationOptions options)
        {
            if (options.HasFlag(ApplicationOptions.IsConsolered))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            if (options.HasFlag(ApplicationOptions.WriteHellow))
            {
                Console.WriteLine("Hello");
            }
        }








        //int[] array = { 1, 2, 3, 4, 5 };
        //MySort(array, SortDirection.Default);

        //SortDirection abc = SortDirection.Ascending;

        //void MySort(int[] array, SortDirection sortDirection)
        //{
        //    if(sortDirection == SortDirection.Default)
        //    {
        //        Array.Sort(array);
        //    }
        //    else if (sortDirection == SortDirection.Reverse)
        //    {
        //        Array.Sort(array);
        //        Array.Reverse(array);
        //    }
        //}

        // Битовые операции - особый вид операций, которые выполняются над отдельными разрядами числа. 

        // & (логическое умножение)
        // Если у обоих операндов значения разрядов 1, то возвращает 1, иначе возвращает 0.
        {
            //int x = 32;                       // 0010 0000
            //int y = 16;                       // 0001 0000
            //int logicAND = x & y;             // 0000 0000 = 0
            //Console.WriteLine(logicAND);
        }

        // | (логическое сложение)
        // Если хотя бы у одного из операндов значения разряда 1, то возвращает 1, иначе возвращает 0.
        {
            //int x = 32;                       // 0010 0000
            //int y = 16;                       // 0001 0000
            //int logicOR = x | y;              // 0011 0000 = 48
            //Console.WriteLine(logicOR);
        }

        // ^ (логическое исключающее ИЛИ) XOR
        // Если значения текущего разряда разные, то возвращается 1, иначе возвращается 0:
        {
            //int x = 32;                       // 0010 0000
            //int y = 16;                       // 0001 0000
            //int logicXOR = x ^ y;             // 0011 0000 = 48
            //Console.WriteLine(logicXOR);
        }

        // ~ (логическое отрицание или инверсия) NOT
        // Если значение разряда равно 1, то становится равным нулю, и наоборот.
        {
            //int x = 32;                       // 0010 0000
            //int logicNot = ~x;                // 1101 1111 = -33
            //Console.WriteLine(logicNot);
        }

        // Операции сдвига
        // x<<y - сдвигает число x влево на y разрядов.
        //  8 = 0000 1000
        // 16 = 0001 0000
        // var left = 8 << 1;
        // Console.WriteLine(left);

        // x>>y - сдвигает число x вправо на y разрядов.
        //  8 = 0000 1000
        //  4 = 0000 0100
        // var right = 8 >> 1;
        // Console.WriteLine(right);
    }
}