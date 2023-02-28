// Двумерные массивы.

// string [, ] table = new string [2, 3]
// [,] - указание к тому, что две размерности
// 1 размерность - строки, 2я - столбы
// int [,] matrix = new int [5, 8] 5- строки, 8 - столбцы

// string[,] table = new string[2, 5];
// table[1, 2] = "слово"; // 1 -индекс строки, 2 - индекс столбца, и дальше работаем как с обычной переменной
// первый элемент - table[0, 0]
// String.Empty - инициализация для строк
// table[0, 0] table[0, 1] table [0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table [1, 2] table[1, 3] table[1, 4]

// string[,] table = new string[2, 5];

// table [1, 2] = "bb";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int [,] matrix = new int [3, 4];

// for (int i = 0; i < 3; i++) 
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]}");
//     }
// Console.WriteLine();
// }

// получили матрицу. 3 и 4 можно оставить
// получаем кол-во строк и столбцов через GetLength
// for (int i = 0; i < 3; i++) == for (int i = 0; i < matrix.GetLength(0); i++)  GetLength(0) - 0 означает кол-во строк
// for (int j = 0; j < 4; j++) == for (int j = 0; j < matrix.GetLength(1); j++)  GetLength(1) - 1 означает кол-во столбцов

// опишем метод, описывающий двумерную матрицу и заполним ее числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int [3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


// Отличие двумерных массивов int[,]  от int[][] 

// int[,]
// - это всегда массив размера M x N , т е каждая строка содержит N элементов, а в
// int[][]
// в т ч в других языках это, так называемый, зубчатый массив и он может выглядеть так:

// 1 2 3 4 1 2
// 2 3 4 4
// 1 2
// 3 4 5 6 1
// 1 2 2 1

// каждая строка может содержать любое количество элементов. и вот как мы узнали этот факт вся "интуитивность" улетает просто моментально.
// в шарпе тоже есть массивы массивов
// int[][]
// , но используют их почти никогда именно из-за того, что нужно всегда контролировать размер очередной строки
