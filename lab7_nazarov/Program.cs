//lab7 Вариант 8, средний уровень

Console.Write("Введите вещественное число: ");
double A = double.Parse(Console.ReadLine());

int N = 1;
double sum = 1.0;

while (sum <= A)
{
    N++;
    sum += 1.0 / N;
}

Console.WriteLine($"Наименьшее N: {N}");
Console.WriteLine($"Сумма: {sum:F2}");