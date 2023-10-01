// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число которое нужно возвести в степень: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int stepen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{digit}, {stepen} -> {Math.Pow(digit, stepen)}");