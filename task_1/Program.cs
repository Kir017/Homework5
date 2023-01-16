// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateFillArray() 
{
    Console.Write("Введите длину массива: ");
    int[] createdArray = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < createdArray.Length; i++)
    {
        createdArray[i] = Random.Shared.Next(10);
    }
    return createdArray;
}
string PrintArray(int[] prArray)
{
    string output = String.Empty;
    for (int i = 0; i < prArray.Length; i++)
    {
        output = output + $"{prArray[i]} ";
    }
    return output;
}
int[] CountMult(int[] colection)
{
    int[] arrayMult = new int[colection.Length / 2];
    for (int i = 0; i < colection.Length / 2; i++)
    {
        arrayMult[i] = colection[i] * colection[colection.Length - 1 - i];
    }
    return arrayMult;
}
int[] arrayNumbers = CreateFillArray();
string print = PrintArray(arrayNumbers);
Console.WriteLine(Print);
int[] arrayResult = CountMult(arrayNumbers);
string print2 = PrintArray(arrayResult);
Console.WriteLine();
Console.WriteLine(Print2);