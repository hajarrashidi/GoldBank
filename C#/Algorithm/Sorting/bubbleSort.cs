//Insert a array of Integers to the method and it will be sorted with bubble sort.
public static int[] BubbleSortArray(int[] array)
{
    int length = array.Length;

    int temp = array[0];

    for (int i = 0; i < length; i++)
    {
        for (int j = i+1; j < length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];

                array[i] = array[j];

                array[j] = temp;
            }
        }
    }

    return array;        
}
