// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



System.Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
int reversenum = 0;
int sres = 0;
int i=1;
int numberRed=number;
while (i<number)
{
    i*=10;
}
int isres = i/10;

while(reversenum<number)
{
    sres= numberRed % 10;
    numberRed = numberRed / 10;
    reversenum += sres * isres;
    isres/=10;
}
Console.WriteLine(reversenum);
if (number==reversenum)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}