
void Exibir(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}






public void Ordenar(int[] items)
{
    int tamanho = items.Length;
    for (int posicao = 1; posicao < tamanho; posicao++)
    {
        int item = items[posicao];
        int anterior = posicao - 1;

        while (anterior >= 0 && items[anterior] > item)
        {
            items[anterior + 1] = items[anterior];
            anterior = anterior - 1;
        }
        items[anterior + 1] = item;
    }
}


// ----------------------------------------- //


int[] items = new int[5] { 2, 4, 1, 5, 3 };

Ordenar(items);
Exibir(items);
