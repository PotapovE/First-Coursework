// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] Numbers(int countNumbers, int leftNumbers, int rightNumbers)
{
    Random random = new Random();
    int[] numbers = new int[countNumbers];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(leftNumbers, rightNumbers);
    }
    return numbers;
}

int CountEven(int[] numbers)
{
    int countEven = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) countEven++;
    }
    if (countEven == 0) countEven = 1;
    return countEven;
}

int[] Evens(int[] numbers, int countEven)
{
    int[] evenNubers = new int[countEven];
    int j = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenNubers[j] = numbers[i];
            j++;
        }
    }
    if (j == 0) evenNubers[0] = -1;
    return evenNubers;
}

void Run()
{
    Console.WriteLine("Введите длину массива чисел");
    int countNumbers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите интервал от: ");
    int leftNumbers = Convert.ToInt32(Console.ReadLine());
    Console.Write("до: ");
    int rightNumbers = Convert.ToInt32(Console.ReadLine());
    int[] numbers = Numbers(countNumbers, leftNumbers, rightNumbers);
    Console.WriteLine($"[{String.Join(',', numbers)}]");
    int[] evenNumbers = Evens(numbers, CountEven(numbers));
    Console.WriteLine($"[{String.Join(',', evenNumbers)}]");
}

Run();