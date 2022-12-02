// Знаю, что задание можно было решить в разы легче с помощью представления числа строкой,
//а затем найти её второй/третий символ, однако хотел проработать именно с помощью циклов
//1 Задание
Console.WriteLine("1 Задание");
Console.WriteLine("---------");
int a;
Console.WriteLine("Введите любое трехзначное число, для того чтобы узнать его вторую цифру:");
a = Convert.ToInt32(Console.ReadLine());
if (a>9)
{
while (a>999)
{
a = a/10;
while(a>99)
{
a=a/10;
}
Console.WriteLine("Введенное вами число не является трехзначным, но да ладно");
}
a =a%10;
Console.WriteLine("Вторая цифра: {0}",a);
}
else
{
Console.WriteLine("Вы ввели число без второй цифры");
}
//2 Задание
Console.WriteLine("---------");
Console.WriteLine("2 Задание");
Console.WriteLine("---------");
int b;
Console.WriteLine("Введите любое число, для того чтобы узнать его третью цифру:");
b = Convert.ToInt32(Console.ReadLine());
if (b > 99)
{
while (b>999)
{
b=b/10;
}
b = b%10;
Console.WriteLine("Третья цифра: {0}",b);
}
else
{
Console.WriteLine("В числе нет третьей цифры");
}
//3 Задание
Console.WriteLine("---------");
Console.WriteLine("3 Задание");
Console.WriteLine("---------");
int c;
Console.WriteLine("Введите число от 1 до 7, чтобы узнать является ли этот день выходным или нет");
c = Convert.ToInt32(Console.ReadLine());
if (c < 8)
{
if (c == 6 || c == 7)
{
Console.WriteLine("Ура, Это выходной день!");
}
else
{
Console.WriteLine("Увы, но введенный вами день является рабочим(");
}
}
else
{
Console.WriteLine("Введенное вами число, не является днем недели");
}
