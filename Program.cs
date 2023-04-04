// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// с клаиватуры, либо задать на старте выполненич алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[6] {"Hi", "!", "my", "name", "is", "Tanya"};
string[] arrLength = new string[array.Length];

void lessThanThreeLatters(string[] array, string[] arrLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3)
        {
            arrLength[count] = array[i];
            count++;
        }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) 
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

lessThanThreeLatters(array, arrLength);
PrintArray (arrLength);