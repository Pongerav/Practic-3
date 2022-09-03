Console.WriteLine("Введите натуральное число N");
int N = int.Parse(Console.ReadLine() ?? "0");

while (N < 1)
{
    Console.WriteLine("Введено неправильное значение N, введите натуральное число N");
    N = int.Parse(Console.ReadLine() ?? "0");
}

if (N == 1) Console.WriteLine("Похоже что чисел заканчивающихся на чётную цифру нет");

for (int i = 2; i <= N; i += 2)
{
    Console.Write($"\t{ Math.Pow(i,3) }");
}