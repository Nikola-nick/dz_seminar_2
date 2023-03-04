// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string []days = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine(" Введите число ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay > 7 )
{
    Console.WriteLine("нет такого дня");
}
if (numberOfDay > 5 & numberOfDay <= 8 )
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий");
}