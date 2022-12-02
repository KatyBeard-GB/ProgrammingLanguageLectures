int[] array = { -158, 852, 332, 77, 482, 56, 66, 77, 88 };

int n = array.Length;
int find = 77;

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