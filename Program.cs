int InText(string Text)
{
    Console.WriteLine(Text);
    return Convert.ToInt32(Console.ReadLine());
}


void Creatarray(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void Printarray(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void Printarray1(double[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void Task34()
{
    int size = InText("Введите размер массива");
    int[]  numbers= new int[size];
    Creatarray(numbers);
    int count = 0;
    for (int i = 0; i<numbers.Length;i++)
    {
        if (numbers[i]%2 == 0)
        {
            count +=1;

        }
        
    }
    Console.WriteLine($"Колличество четных чисел в массиве равен {count} ");
}

void Task36()
{
    int size = InText("Введите размер массива");
    int[]  numbers= new int[size];
    Creatarray(numbers);
    int sumnum = 0;
    for (int i = 1; i<numbers.Length;i=i+2)
    {
        sumnum +=numbers[i];              
    }
    Console.WriteLine($"Сумма элентов с нечетными индексами равна {sumnum} ");
}
void Creatarray1(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void Creatarray2(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i<array.Length;i++)
    {
        array[i] = rand.Next(-100, 100) + rand.NextDouble();
        array[i] = Math.Round(array[i],2);
    }
}
void Task38()
{
    int size = InText("Введите размер массива");
    double[]  numbers= new double[size];
    Creatarray2(numbers);
    double maxi = numbers[0];
    double mini = numbers[0];
    for (int i = 1; i<numbers.Length;i++)
    {
        if (maxi < numbers[i]) maxi = numbers[i];    
        if (mini > numbers[i]) mini = numbers[i];         
    }
    
    Console.WriteLine($"Разность максимального и минимального элемента массива равна {maxi - mini} ");
}
Task34();
Task36();
Task38();