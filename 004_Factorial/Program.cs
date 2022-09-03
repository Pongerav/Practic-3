Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine() ?? "0");
int result = 1;

while (N < 1)
{
    Console.WriteLine("Введено неправильное значение N, введите натуральное число N");
    N = int.Parse(Console.ReadLine() ?? "0");
}

for (int i = 1; i <= N; i+=1)
{
    result = result * i;
}

Console.WriteLine($"Факториал числа {N} равен {result}");