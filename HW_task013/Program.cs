/*
  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
  что третьей цифры нет.
  645 -> 5
  78 -> третьей цифры нет
  32679 -> 6
*/
Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
//1-ый способ:
int num1 = num;
//2-ой способ:
//int num1 = Math.Abs(num);
int i = 1;
//1-ый способ:
if (num1 > 99 || num1 < -99)
//2-ой способ:
//if (num1 > 99)
{
  //1-ый способ:
  while (num1 > 999 || num1 < -999)
  //2-ой способ:
  //while (num1 > 999)
  {
    num1 = num1 / 10;
    i++;
  }
  int result = num1 % 10;
  //1-ый способ:
  Console.Write($"Третья цифра числа {num} => {Math.Abs(result)}");
  //2-ой способ:
  //Console.Write($"Третья цифра числа {num} => {result}");
}
else
{
  Console.Write($"Третьей цифры в числе {num} => НЕТ");
}
