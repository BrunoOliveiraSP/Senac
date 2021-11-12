---
title: "Algoritmos e Programação II: Insertion Sort & Merge Sort"
author: "OLIVEIRA, Bruno"
---

![](Assets/senac.png)

# Algoritmos e Programação II

### Agenda
- O que é um algoritmo?
- Algoritmos para Coleções
- **Algoritmo:** *Insertion SORT*
- **Algoritmo:** *Merge SORT*
- Borá pro código!
- Referências

---
#### Algoritmo!?

> “Um algoritmo é uma sequência finita de ações executáveis que visam obter uma solução para um determinado tipo de problema.”

Algoritmos de Ordenação:
- Quick sort
- Bubble sort
- Selection sort
- Shell sort
- Merge sort
- Insertion sort

---
#### Insertion SORT

> "Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part."

![](Assets/insertionsort.png)

O algoritmo pode ser representado pelo código abaixo:

```csharp
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
```

---
#### Merge SORT

> "Like QuickSort, Merge Sort is a Divide and Conquer algorithm. It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves. The merge() function is used for merging two halves. The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one. See the following C implementation for details."

![](Assets/Merge-Sort.png)

O algoritmo pode ser representado pelo código abaixo:

```csharp
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
```


---
#### Borá pro Código

O código completo está disponível no git. Acessa lá ;)

![github](Assets/github.png) 
[Acessar pelo Github](https://github.com/BrunoOliveiraSP)


---
#### Referências

![referencias](Assets/references.png)

> CORMEN, T. H. et all. **Introduction to Algorithms**. ed. 3. Cambridge: MIT Press, 2009.

> **Data Structure and Algorithms**. Disponível em: <https://www.tutorialspoint.com/data_structures_algorithms/insertion_sort_algorithm.htm>




