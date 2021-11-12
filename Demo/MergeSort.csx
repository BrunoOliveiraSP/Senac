
void Exibir(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}





void Merge(int[] arr, int l, int m, int r)
{
    int n1 = m - l + 1;
    int n2 = r - m;

    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;

    for (i = 0; i < n1; ++i)
        L[i] = arr[l + i];
    for (j = 0; j < n2; ++j)
        R[j] = arr[m + 1 + j];



    i = 0;
    j = 0;

    int k = l;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}




void Sort(int[] items, int esquerda, int direita)
{
    if (esquerda < direita)
    {
        int meio = esquerda + (direita - esquerda) / 2;

        Sort(items, esquerda, meio);
        Sort(items, meio + 1, direita);

        Merge(items, esquerda, meio, direita);
    }
}





// ----------------------------------------- //


int[] items = new int[] { 2, 4, 1, 5, 3 };
Sort(items, 0, items.Length - 1);
Exibir(items);
