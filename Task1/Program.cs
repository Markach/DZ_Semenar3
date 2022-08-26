// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.14212 -> нет 12821 -> да 23432 -> да

void PalindromeN()
{
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length != 5)
{
    Console.Write("Нужно вводить пятизначное число, а не число, которое ввели:  ");
}
    else if(numberText[0] == numberText[4] & numberText[1] == numberText[3])  numberText = "'да', число палиндром";
    else  numberText = "'нет', число не палиндром";

Console.Write(numberText);
}
try
{
     PalindromeN();
 }
catch
{
Console.WriteLine("Нужно вводить число ");
}