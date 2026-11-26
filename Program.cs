// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите целое число: ");
//         string input = Console.ReadLine() ?? "";

//         try
//         {
//             int number = int.Parse(input);

//             Console.WriteLine($"Вы ввели число {number}");
//             Console.WriteLine($"Квадрат числа:{number * number}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Ошибка: нужно ввести целое число.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.Write("Введите первое число: ");
//             int a = int.Parse(Console.ReadLine() ?? "");

//             Console.Write("Введите второе число: ");
//             int b = int.Parse(Console.ReadLine() ?? "");

//             int result = a / b;

//             Console.WriteLine($"Результат: {result}");
            
//             int remainder = a % b;
//             Console.WriteLine($"Остаток от деления: {remainder}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Ошибка: введено не целое число.");
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Ошибка: делить на ноль нельзя.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.Write("Введите первое число: ");
//             int a = int.Parse(Console.ReadLine() ?? "");

//             Console.Write("Введите второе число: ");
//             int b = int.Parse(Console.ReadLine() ?? "");

//             int result = a / b;

//             Console.WriteLine($"Результат: {result}");
            
//             int remainder = a % b;
//             Console.WriteLine($"Остаток от деления: {remainder}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Ошибка: введено не целое число.");
//         }
//         catch (OverflowException)
//         {
//              Console.WriteLine("Ошибка: число выходит за диапазон типа int.");
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Ошибка: делить на ноль нельзя.");
//         }
//     }
// }

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Введите индекс от 0 до 4: ");
            int index = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"Элемент: {numbers[index]}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: нужно ввести целое число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число выходит за диапазон int.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Ошибка: такого индекса в массиве нет.");
        }
    }
}