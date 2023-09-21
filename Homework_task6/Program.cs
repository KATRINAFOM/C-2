Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int remDiv = number % 2;

if(remDiv == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}