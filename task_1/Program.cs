// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] CreateArr()
{
  int number = Random.Shared.Next(10, 20);
  int[] createdArray = new int[number];
  return createdArray;
}
void FillArray(int[] filledArray)
{
  int count = filledArray.Length;
  for (int i = 0; i < count; i++)
  {
    filledArray[i] = Random.Shared.Next(10);
  }
}
string PrintArray(int[] prArray)
{
  string output = String.Empty;
  int size = prArray.Length;
  for (int i = 0; i < size; i++)
  {
    output = output + $"{prArray[i]} ";
  }
  return output;
}
int[] CountMult(int[] colection)
{
  int mult = 0;
  int[] arrayMult = new int[colection.Length / 2];
  for (int i = 0; i < colection.Length / 2; i++)
  {
    mult = colection[i] * colection[colection.Length - 1 - i];
    // Console.WriteLine(mult);
    arrayMult[i] = mult;
  }
  return arrayMult;
}
int[] arrayNumbers = CreateArr();
FillArray(arrayNumbers);
string Print = PrintArray(arrayNumbers);
Console.WriteLine(Print);
int[] arrayResult = CountMult(arrayNumbers);
string Print2 = PrintArray(arrayResult);
Console.WriteLine();
Console.WriteLine(Print2);