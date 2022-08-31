int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i=0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

int [] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int PositiveSum = 0;
int NegativeSum = 0;


foreach (int el in array)
{
    PositiveSum += el > 0 ? el : 0;
    NegativeSum += el > 0 ? el :0;
}

Console.WriteLine ($"PositiveSum {PositiveSum}, NegativeSum {NegativeSum}");
