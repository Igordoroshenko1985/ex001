Console.Clear();
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());

int i = 0;

i = i - (number + 1);

while (i < number)
{
    i += 1;
    Console.Write(i + " ");
}
Console.WriteLine();
