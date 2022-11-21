// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


int[] ArrayNumber(int lengthArray, int startInterval, int endInterval)
{
    int[] array = new int[lengthArray];
    Random random = new Random();

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = random.Next(startInterval, endInterval + 1);
    }

    return array;
}

void sum(int[] array)
{
   int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        result += array[i];
         
    }
}
Console.WriteLine("Сумма " + result);
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

void Start()
{
    Console.Write("Введите длинну массива = ");
    int lengthArray = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение массива = ");     
    int startInterval = int.Parse(Console.ReadLine()!);      
    
    Console.Write("Введите максимальное значение массива = ");     
    int endInterval = int.Parse(Console.ReadLine()!); 

    int[] array = ArrayNumber(lengthArray, startInterval, endInterval); 
    Print(array);
    Console.WriteLine();
    sum(array);
    
}
Start();