int[] array = {2,34, 457, 43, 876, 34, 765, 3764};

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}