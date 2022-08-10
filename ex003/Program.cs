Console.Clear();
Console.Write("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("numberA - max");
    Console.WriteLine("numberB - min");
}
else 
{
    Console.WriteLine("numberB - max");
    Console.WriteLine("numberA - min");
}