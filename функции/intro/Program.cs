int[] array={4, 66, 663, 525, 56, 2, 6, 3, 71};
int max=Max(
    Max(array[0], array[1], array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));



int Max(int ag1, int ag2, int ag3)
{
    int result = ag1;
    if(ag2>result) result = ag2;
    if(ag3>result) result = ag3;
    return result;
}

Console.WriteLine(max);