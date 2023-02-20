// Одномерный массив array из n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array[index] = find, алгоритм завершил работу успешно
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно

// int[] array = { 12, 15, 44, 15, 12, 18, 52 };
// int n = array.Length;
// int find = 18;
// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++; // index = index + 1
// }


// второй пример с функциями void - ничего не возвращают

void FillArray(int[] collection)  // заполняем new int[10] рандомными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // метод который печатает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // возвращает позицию, индекс
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
     

int[] array = new int[10]; // первое - определяем массив, по умолчанию заполнен 0, для этого Fillarray.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);


