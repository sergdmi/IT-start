// start


string[] CreateArray1(int size)
{
    return new string[size];
}

void FillArrayConsole(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива (текст) с индексом {i}: ");
        array[i] = Console.ReadLine();
    }

}

string Print(string[] array)
{
    string text = "[";

    for (int i = 0; i < array.Length; i++)
    {
        text += ($" {array[i]}, ");
    }
    return (text + "]");
}

int ValueCount(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }

    return count;
}

string[] CreateArray2(string[] array, int count)
{
    string[] values = new string[count];
    int length = array.Length;
    int index1 = 0;
    int index2 = 0;

    while (index1 < length)
    {
        if (array[index1].Length < 4)
        {
            values[index2] = array[index1];
            index2++;
        }
        index1++;
    } 

    return values;      
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = CreateArray1(size);
FillArrayConsole(array1);
Console.Write("Вывод масcива 1:");
Console.WriteLine(Print(array1));
int newsize = ValueCount(array1);
string[] array2 = CreateArray2(array1, newsize);
Console.Write("Вывод масcива 2:");
Console.WriteLine(Print(array2));


// end