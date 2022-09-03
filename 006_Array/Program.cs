void FillArray(int[] array, int length)
{
    for (int i = 0; i < length; i += 1)
    {
        array[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] array)
{
    foreach (int i in array) Console.Write(i + " ");
}


int[] array = new int[8];

FillArray(array, array.Length);
PrintArray(array);