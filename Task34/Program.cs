// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] ArrayNumber(int lengthArray)
{
    int[] array = new int[lengthArray];
    Random random = new Random();

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = random.Next(99, 999);
    }

    return array;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }
}

void chetnoe(int[] array)
{
   int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result++;
         
    }
     
}
Console.WriteLine("Количество четных " + result);
}

void Start()
{
    Console.Write("Введите длинну массива = ");
    int lengthArray = int.Parse(Console.ReadLine()!);

    int[] array = ArrayNumber(lengthArray);
    Print(array);
    Console.WriteLine();
    chetnoe(array);
    
}
Start();
