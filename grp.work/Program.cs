//Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());

// if (a == (b *b ))
// {
//     Console.WriteLine("True");
// }
// else 
// {
//     Console.WriteLine("False");
// }
Console.Write("Введите номер дня недели: ");
string num = Console.ReadLine();
switch(num)
{
    case "1": 
    Console.WriteLine("Понедельник");
    break;
    case "2": 
    Console.WriteLine("Вторник");
    break;
    case "3": 
    Console.WriteLine("Среда");
    break;
    case "4": 
    Console.WriteLine("Четверг");
    break;
    case "5": 
    Console.WriteLine("Пятница");
    break;
    case "6": 
    Console.WriteLine("Суббота");
    break;
    case "7": 
    Console.WriteLine("Воскресенье");
    break;
    default: Console.WriteLine("Нет такого дня недели");
    break;
}