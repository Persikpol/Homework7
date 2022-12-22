// Task47

void Zadacha47()
{
    int rows = 3;
    int columns = 4;

    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
}

void FillArray(double[,] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Convert.ToDouble(rand.Next(minValue, maxValue)/10.0);
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
Zadacha47();

// Task50

void Zadacha50()
{
    int rows = 3;
    int columns = 4;

    int[,] numbers = new int[rows, columns];
    FillArr(numbers);
    FindElement(numbers);
    Zadacha52(numbers);
}

void FillArr(int[,] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Console.WriteLine("напишите 1ый индекс элемента");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("напишите 2oй индекс элемента");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x < rows && y < columns)
    {
        Console.WriteLine($"Элемент с данными индексами равен {numbers[x, y]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}


// Task 52 создание массива подтянули из прошлой задачи

void Zadacha52(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers [i, j];
        }
        Console.WriteLine($"Среднее арифместическое столбца {j + 1} = {sum / rows}");
    }
}
Zadacha50();
