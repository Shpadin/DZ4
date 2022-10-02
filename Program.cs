// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

 Console.WriteLine("Выберете задачу 25 / 27 / 29");
int task = int.Parse(Console.ReadLine());

switch (task)
{
     case 25: Task25();
   break;
   case 27: Task27();
   break;
   case 29: Task29();
   break;
   default : 
   Console.WriteLine("введон не верный номер задания");
   break;
}
// if (task == 25) 
// {
//     Task25();
// }
// else if (task == 27)
// {
//     Task27();
// }
// else if (task == 29)
// {
//     Task29();
// }
// else
// {
//     Console.WriteLine("введон не верный номер задания");
// }
void Task25()
{
Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите  число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число B: ");
int numberB = int.Parse(Console.ReadLine());
double log =numberA;

for (int i = 0; i < numberB -1;i++)
{
    log=log*numberA;
}

// double log = Math.Pow((numberA), numberB);
 Console.WriteLine($"{numberA} в степени {numberB} = {log} ");

}
void Task27()
{
Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите  число N: ");
int number = int.Parse(Console.ReadLine());
string numberN =number.ToString();
int amount = numberN.Length;
int sum =   0;
for (int i = 0; i < amount; i++)
{
    sum = sum + number%10;
    number=number/10;

}
 Console.WriteLine($"  длинна числа {amount}  ");
 Console.WriteLine($" Сумма цифр в числе {numberN}  = {sum} ");
}
void Task29()
{
Console.WriteLine("Напишите программу, которая задаёт массив из N элементов и выводит их на экран");
Console.WriteLine("Введите  длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int size)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(0,9);
    }
    return filledArray;
}
int[]array= FillArray(size);
 Console.WriteLine("Массив: [ " + String.Join(",",array) + " ]");
}