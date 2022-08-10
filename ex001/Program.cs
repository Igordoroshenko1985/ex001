
Console.Clear();
Console.Write("ВВедите число А");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число Б");
int numberB = int.Parse(Console.ReadLine()); 
int sqr = numberA * numberA;
  if (sqr == numberB)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}
 