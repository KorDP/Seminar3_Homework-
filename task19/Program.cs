Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n0 = n / 10000;
int n1 = n / 1000 % 10;
int n2 = n / 100 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;

if (n0 == n4 && n1 == n3) 
{
    Console.WriteLine($"Число '{n}' палиндром");
}
else 
{
    Console.WriteLine($"Число '{n}' не палиндром");
}