using System.ComponentModel.DataAnnotations;

namespace _04_Loops_Foreach;

class Program
{
    static void Main(string[] args)
    {
        #region Инициализация

        //// Инициализация целочисленного массива
        //int[] nums1 = new int[4];

        //// Все перечисленные выше способы будут равноценны
        //// Индекс первого элемента будет равен 0.
        //int[] nums2 = new int[4] { 1, 2, 3, 5 };
        //int[] nums3 = new int[] { 1, 2, 3, 5 };
        //int[] nums4 = new[] { 1, 2, 3, 5 };
        //int[] nums5 = { 1, 2, 3, 5 };
        //int[] nums6 = [1, 2, 3, 5];

        //string[] stringArray = { "first", "second" };
        //double[] doubleArray = { 2.5, 3.7 };

        #endregion

        #region Индексы

        //// Используем индексы для получения и установки значений элементов массива:
        //int[] nums = new int[4];
        //nums[0] = 1;
        //nums[1] = 2;
        //nums[2] = 3;
        //nums[3] = 5;
        //Console.WriteLine(nums[4]); // 5
        //// Если обратиться к несуществующему элементу массива, то мы получим исключение IndexOutOfRangeException

        #endregion

        #region Rank

        //// Массивы характеризуются таким понятием как ранг или количество измерений.
        ////     Массивы которые имеют два измерения (ранг равен 2) называют двухмерными.
        //int[] numbers1 = new int[] { 0, 1, 2, 3, 4, 5 };
        //int[,] numbers2 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };

        //// Массивы могут иметь и большее количество измерений. 
        //int[,,] numbers3 = new int[2, 3, 4];
        //// Длина такого массива - это совокупное количество элементов.
        //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        //var masLenght = mas.Length;

        //// Компилятор определяет размер массива на основании выражения.
        //int[,] someArray =
        //{
        //    { 1, 2, 3 },
        //    { 4, 5, 6 },
        //    { 7, 8, 9 }
        //};

        #endregion

        #region GetUpperBound

        //// Метод GetUpperBound(dimension) - возвращает индекс последнего элемента в определенной размерности.
        //int[,] array = 
        //{ 
        //    { 1, 2, 3 }, 
        //    { 4, 5, 6 }, 
        //    { 7, 8, 9 },
        //    { 10, 11, 12 } 
        //};
        //int rows = array.GetUpperBound(0) + 1;
        //int columns = array.GetUpperBound(1) + 1;

        //Console.WriteLine(array.Length);
        //Console.WriteLine(rows);
        //Console.WriteLine(columns);

        //var justarray = new[] { 1, 2, 3 };
        //Console.WriteLine(justarray.GetUpperBound(0));


        #endregion

        #region Зубчатые массивы

        ////// От многомерных массивов надо отличать массив массивов или так называемый "зубчатый массив"
        //int[][] someNumbers = new int[3][];

        //// выделяем память для первого подмассива
        //someNumbers[0] = new int[2] { 1, 2 };

        //// выделяем память для второго подмассива
        //someNumbers[1] = new int[3] { 1, 2, 3 };
        //someNumbers[1] = new int[6] { 1, 2, 3, 4, 5, 6 };

        //// выделяем память для третьего подмассива
        //someNumbers[2] = new int[5] { 1, 2, 3, 4, 5 };

        #endregion

        #region Array methods

        // Все массивы в C# построены на основе класса Array из пространства имен System.
        // Свойство Length возвращает длину массива
        // Свойство Rank возвращает размерность массива
        // Статический метод BinarySearch() выполняет бинарный поиск в отсортированном массиве
        // Статический метод Clear() очищает массив, устанавливая для всех его элементов значение по умолчанию
        // Статический метод Copy() копирует часть одного массива в другой массив 
        // Статический метод Exists() проверяет, содержит ли массив определенный элемент
        // Статический метод Find() находит элемент, который удовлеворяет определенному условию
        // Статический метод FindAll() находит все элементы, которые удовлеворяет определенному условию
        // Статический метод IndexOf() возвращает индекс элемента
        // Статический метод Resize() изменяет размер одномерного массива
        // Статический метод Reverse() располагает элементы массива в обратном порядке
        // Статический метод Sort() сортирует элементы одномерного массива

        int[] array2 = {1, 2, 3, 4, 5, 6, 5};
        //int[] array3 = new int[10];

        //var length = array2.Length;
        //var rank = array2.Rank;

        //Array.Copy(array2, array3, 3);
        //Array.Copy(array2, 1, array3, 3, 5);

        //for (int i = 0; i < array3.Length; i++)
        //{
        //    Console.Write($"{array3[i]} ");
        //}
        //bool isExist = Array.Exists(array2, IsEqual);

        //for (int i = 0; i < array2.Length; i++)
        //{
        //    if (IsEqual(array2[i]))
        //    {
        //        isExist = true;
        //    }
        //}

        //bool IsEqual2(int x)
        //{
        //    return x == 9;
        //}

        //var firstElement = Array.Find(array2, IsEqual2);
        //int[] elements = Array.FindAll(array2, IsEqual2);
        //var index = Array.IndexOf(array2, 9);

        //if (index < 0)
        //{
        //    Console.WriteLine("Такого элемента нет");
        //}
        //else
        //{
        //    Console.WriteLine(index);
        //}

        #endregion

        #region Reference type

        //int[] myArray = [1, 2, 3, 4, 5];
        //IncArray(myArray);

        //for (var i = 0; i < myArray.Length; i++)
        //{
        //    Console.Write("{0},", myArray[i]);
        //}

        //void IncArray(int[] argArray)
        //{
        //    for (var i = 0; i < argArray.Length; i++)
        //    {
        //        argArray[i] += 1;
        //    }
        //}

        #endregion


        #region List patterns

        //int[] abc = [1, 2, 3, 4, 5, 6, 7, 8];
        //switch (abc)
        //{
        //    case [1, .., 8]:
        //        {
        //            Console.WriteLine("YES - [1, .., 8]");
        //            break;
        //        }
        //    case [1, ..]:
        //        {
        //            Console.WriteLine("YES - [1, ..]");
        //            break;
        //        }
        //        // case [.., 8]:
        //        // {
        //        //     Console.WriteLine("YES - [.., 8]");
        //        //     break;
        //        // }
        //        // case [1, _, 2]:
        //        // {
        //        //     Console.WriteLine("YES - [1, _, 2]");
        //        //     break;
        //        // }
        //        // case [.., _, 6, _, 8]:
        //        // {
        //        //     Console.WriteLine("YES - [.., _, 6, _, 8]");
        //        //     break;
        //        // }
        //}

        #endregion

        #region Span

        {
            int[] intArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            // мы хотим      [1, 2, 3, 99, 98, 97, 7, 8, 9];

            Span<int> arraySpan = intArray.AsSpan();
            var subSpan = arraySpan.Slice(3, 3);
            subSpan[0] = 99;
            subSpan[1] = 98;
            subSpan[2] = 97;

            foreach (var iten in intArray)
            {
                Console.Write($"{iten} ");
            }
        }

        #endregion
    }




}