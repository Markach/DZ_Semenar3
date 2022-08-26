// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double DistanceBetweenTwoPoints()
{
Console.WriteLine("Введите координаты точки А в 3D пространстве (А(x,y,z): ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B в 3D пространстве (B(x,y,z): ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double resalt = Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2));
return resalt;
}
try
{
    Console.WriteLine(DistanceBetweenTwoPoints());
}
catch
{
Console.WriteLine("Введите цифры ");
}