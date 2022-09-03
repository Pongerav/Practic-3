Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine() ?? "0");

while (N < 1)
{
    Console.WriteLine("Введено неправильное значение N, введите натуральное число N");
    N = int.Parse(Console.ReadLine() ?? "0");
}

if (N == 1) Console.WriteLine($"Похоже что 1 единсвенный куб");

for (int i = 1; i <= N; i += 1)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
