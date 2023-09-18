
/*
 string str = "Hellow"; - Строки  не изменны.
enum - Это список констан со своими именами.
 В С#  Все Клас

 enum MyEnum
 
 */


// Сощздание Двумерных массивов

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            int[] arr = new int[16];
//            int[,] arr2 = new int[16, 16]; // [,] так обозначается двумерный массив
//            int[][] arr3 = new int[2][];
//            //string str; // Так создаются строки
//            arr3[0] = new int[] { 1, 2 }; 
//            arr3[1] = new int[] { 3, 4 };
//            Console.WriteLine(arr3[1][0]);

//            int sum = 0;
//            foreach (int i in arr)
//            {
//                sum += i;
//            }
//            Console.WriteLine(sum);
//            //jagged
//        }
//    }
//}



//  Enum 
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        enum MyEnum
//        {
//            Monday = 5, Tuesday = 10, Wendnesday
//        }


//        static void Main(string[] args)
//        {
//            MyEnum day = MyEnum.Monday;
//            Console.WriteLine(day);
//            int[] arr = new int[16];
//            int[,] arr2 = new int[16, 16]; // [,] так обозначается двумерный массив
//            int[][] arr3 = new int[2][];
//            //string str; // Так создаются строки
//            arr3[0] = new int[] { 1, 2 };
//            arr3[1] = new int[] { 3, 4 };
//            Console.WriteLine(arr3[1][0]);

//            int sum = 0;
//            foreach (int i in arr)
//            {
//                sum += i;
//            }
//            Console.WriteLine(sum);
//            //jagged
//        }
//    }
//}

// Задача 
/*
 
 */

//namespace ConsoleApp
//{
//    internal class Program
//    {


//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int RandomNum = rnd.Next(1, 10);

//            int[] arr = Enumerable.Range(1, 10).ToArray();

//            int evenCount = 0;
//            int oddCount = 0;
//           // int uniqueCount = 0;
//            foreach (int i in arr)
//            {
//                if (i % 2 == 0) 
//                    ++evenCount;
//                else
//                    ++oddCount;

//            }
//            foreach 
//            Console.WriteLine($"Начальный массив: {arr[9]}");
//            Console.WriteLine($"Чётных элементов: {evenCount}");
//            Console.WriteLine($"Нечетных элементов: {oddCount}");


//        }

//        public void Zadacha()
//        {

//        }
//    }
//}

//using System.Drawing;

//namespace ConsoleApp
//{
//    internal class Program
//    {


//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int RandomNum = rnd.Next(1, 10);
//            int Chet = 0; int NeChet = 0; int uniqCount = 0;
//            int size = Convert.ToInt32(Console.ReadLine());
//            int[] arr = new int[size];
//            int[] arr2 = new int[size];

//            for(int i = 0; i<10; ++i)
//            {
//                arr[i] = rnd.Next(1, 10);
//                Console.WriteLine("Элемент массива " + i + " = " + arr[i]);
//            }

//            foreach (int i in arr)
//            {
//                if (i % 2 == 0)
//                    Chet++;
//                else
//                    NeChet++;
//            }


//            int count = 0;
//            for(int i = 0; i < size; ++i)
//            {
//                for (int j = 0; j < size; ++j)
//                {
//                    if(i == j)
//                    {
//                        continue;
//                    }
//                    if (arr[i] == arr[j])
//                    {
//                        count++;
//                        break;
//                    }
//                }
//                if (count == 0)
//                {
//                    uniqCount++;
//                }
//                count = 0;
//            }
//            Console.WriteLine($"Четные : {Chet}");
//            Console.WriteLine($"НЕЧетные : {NeChet}");
//            Console.WriteLine($"Уникальные : {uniqCount}");
//        }


//        public void Zadacha()
//        {

//        }
//    }
//}


// Задача (Вводит предложение)

/*
  string? sentence = Console.ReadLine();// string? - Это говорит что не может быть длинной
ReadLine()- Вводим текст 
Split(' ') - Это говорим разбей там где пробелы
StringSplitOptions.RemoveEmptyEntries - Эта опция принадлежит методу Split() но (Выводим Contr-  и наш метод)  
 */
//using System.Collections.Generic;
//using System.Drawing;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите предложение->");
//            string sentence = Console.ReadLine();// string? - Это говорит что не может быть длинной - Вводим текст 
//            string[] parts = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            int Words = parts.Length;

//            // Console.ReadLine(), который позволяет пользователю ввести предложение.
//            Console.WriteLine($"Количество строк: {Words}");
//        }
//        public void Zadacha()
//        {

//        }
//    }
//}

// Задача( Найти Мин Макс Пользователь вводит размер массива. (массив заполняется через рандомайзер)Это в классе  )


//using System.Collections.Generic;
//using System.Drawing;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите размер массива ->");
//            int size = Convert.ToInt32(Console.ReadLine());

//            Random rnd = new Random();
//            int[] arr = new int[10];
//            int min, max;            
//            for (int i = 0; i < 10; i++)
//            {
//                arr[i] = rnd.Next(1, 10);
//                Console.WriteLine(arr[i]);
//            }
//            min = arr[0];
//            max = arr[0];
//            foreach (int i in arr)
//            {
//                if(min > i)
//                {
//                    min = i;
//                }
//                if(max < i)
//                {
//                    max = i;
//                }
//            }

//            Console.WriteLine($"Min: {min}");
//            Console.WriteLine($"Max: {max}");
//        }
//        // Console.ReadLine(), который позволяет пользователю ввести предложение.



//    }
//}

/*
 
 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101); // Заполняем массив случайными числами от 1 до 100
        }

        int min = array[0];
        int max = array[0];

        for (int i = 1; i < size; i++)
        {
            if (array[i] < min)
                min = array[i];

            if (array[i] > max)
                max = array[i];
        }

        Console.WriteLine($"Минимальное значение: {min}");
        Console.WriteLine($"Максимальное значение: {max}");

        Console.ReadLine();
    }
}


В этом примере пользователь вводит размер массива с помощью Console.ReadLine(), а затем создается массив заданного размера. Мы используем класс Random для генерации случайных чисел и заполняем массив случайными значениями от 1 до 100 с помощью метода Next().

Затем мы инициализируем переменные min и max со значениями первого элемента массива. Затем проходим по всем остальным элементам массива и сравниваем их со значениями min и max. Если текущий элемент меньше min, обновляем значение min, а если текущий элемент больше max, обновляем значение max.

Наконец, выводим на экран минимальное и максимальное значения.

Пример использования:
Введите размер массива:
5
Минимальное значение: 12
Максимальное значение: 94

 */