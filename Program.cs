// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int PromptInt(string msg)
{
    Console.Write(msg + " >>");
    return Convert.ToInt32(Console.ReadLine());
}

string[] CreateStringArray(int elements)
{
    string[] arr = new string[elements];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] CreateNewArray(string[] oldArr)
{
    int j = 0;
    string[] newStringArray = new string[j];

    for (int i = 0; i < oldArr.Length; i++)
    {
        if (oldArr[i].Length <= 3)
        {
            Array.Resize(ref newStringArray, j+1);
            newStringArray[j] = oldArr[i];
            j++;
        }
    }
    return newStringArray;
}

void PrintArray(string[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(", " + arr[i]);
    }
}

void Execute()
{
    string[] sourceArray = CreateStringArray(PromptInt($"Сколько элементов будет в нашем массиве?"));
    Console.WriteLine("Новый массив:");
    PrintArray(CreateNewArray (sourceArray));
}
Execute();