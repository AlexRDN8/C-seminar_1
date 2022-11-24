// 1. Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число кввадратом второго.
//a = 25, b = 5. Да.
//a = 2, b = 10. Нет.

// Console.Clear();
// Console.WriteLine("Введите первое число");
// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Второе число");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// 3 задача. Напишите программу, которая будет выводить название недели по заданному номеру
//3 - среда
//5 - пятница

// Console.Clear();
// Console.WriteLine("Введите номер дня недели числом от 1 до 7");
// string number = Console.ReadLine();
// if (number == "1")
// {
//     Console.WriteLine("Понедельник");
// }
// if (number == "2")
// {
//     Console.WriteLine("Вторник");
// }
// if (number == "3")
// {
//     Console.WriteLine("Среда");
// }
// if (number == "4")
// {
//     Console.WriteLine("Четверг");
// }
// if (number == "5")
// {
//     Console.WriteLine("Пятница");
// }
// if (number == "6")
// {
//     Console.WriteLine("Суббота");
// }
// if (number == "7")
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Нужно ввести число от 1 до 7");
// }

//3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

// Console.Clear();
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// int opposit_number = number - ( number * 2);
// {
//     Console.WriteLine(opposit_number);
// }

// 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456->6 782->2 918->8

// Console.Clear();
// Console.WriteLine("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine());

// int remainder = number % 10;
// {
//     Console.WriteLine(remainder);
// }
