
void SortingArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] array1 = new string[5] {"arr", "43", "sorting", "98765", "yes"};
string[] array2 = new string[array1.Length];

SortingArray(array1, array2);
PrintArray(array2);
