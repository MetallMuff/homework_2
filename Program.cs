﻿/*Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.*/

/*
int number = new Random().Next(100,1000);
Console.WriteLine("Случайное число : " + number ) ;
int digitOne = number %100;
int digitTwo = digitOne / 10;

int result = digitTwo;

Console.WriteLine("нужное число : " +result)
*/
////////////конец первой задачи///////

/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_as_text = Convert.ToString(num);
if (num_as_text.Length > 2){
  Console.WriteLine("Цифра №3: " + num_as_text[2]);
}
else {
  Console.WriteLine("Цифра №3 - Отсутствует");
}
*/
////////////конец второй задачи/////////


/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNum) {
  if (dayNum == 6 && dayNum == 7) {
  Console.WriteLine("Выходной день");
  }
  else if (dayNum < 1 && dayNum > 7) {
    Console.WriteLine("Не верно указан день недели");
  }
  else Console.WriteLine("Рабочий день");
}

CheckingTheDayOfTheWeek(dayNum);