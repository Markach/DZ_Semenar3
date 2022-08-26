// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void PrintNambers()
{
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 1)
{
for (int i = 1; i <= number; i++)
{
  Console.Write(i*i*i + ", ");   
}
}
else
Console.WriteLine("Нужно вводить число, которое больше 0 ");
}
try
{
    PrintNambers();
}
catch
{
Console.WriteLine("Нужно вводить число ");
}
