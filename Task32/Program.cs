int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i=0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

int [] revers (int [] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }
    return mas;
}



int [] array = GetArray (5, -10, 11);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine(String.Join(" ", revers(array)));


