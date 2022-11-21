// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

float[] ArrayNumber(int lengthArray) 
{
    float[] array = new float[lengthArray];
    Random random = new Random();

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = random.NextSingle();
            }

    return array;
}

void Print(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }
}

void deltaMaxMin(float[] array)
{ 
    float maxNum = array[0];
    float minNum = array[0];
   
for (int i = 0; i < array.Length; i++)
{
   
    if (array[i] > maxNum)
    {
        maxNum = array[i];
    }
    if (array[i] < minNum)
    {
        minNum = array[i];
    }
   // result = maxNum - minNum;
  
} 
Console.WriteLine($"Максимальное значение = {maxNum}, минимальное значение = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {maxNum - minNum}");
}

void Start()
{
    Console.Write("Введите длинну массива = ");
    int lengthArray = int.Parse(Console.ReadLine()!);

    float[] array = ArrayNumber(lengthArray); 
    Print(array);
    Console.WriteLine();
    deltaMaxMin(array);
}
Start();



