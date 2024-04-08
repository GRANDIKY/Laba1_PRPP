Console.Write("Введите N (максимум): ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x (-1 <= x <= 1): ");
double x = Convert.ToDouble(Console.ReadLine());

double sum = 0;

for (int i = 0; i <= N; i++)
{
    sum += (Math.Pow(-1, i) * Math.Pow(x, i + 1)) / (i + 1);
}

Console.WriteLine($"Сумма равна: {sum}");