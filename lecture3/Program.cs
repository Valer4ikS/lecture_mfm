
// Вид методов

// Вид1 - ничего не возвращают, ничего не принимают

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// как вызывается метод:

// Method1();

// Вид2 - ничего не возвращают, но принимают аргументы

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;  // увеличение на 1 - инкремент, а уменьшение - декремент count = count + 1
//     }
// }

// Method21(msg: "Текст", count: 4); // Method21("Текст", 4) добавляем аргументы каким присваиваем значения
// Method21(count: 4, msg: "Текст"); // когда используем именованные аргументы можно вводиить не по порядку

// Вид 3 - что-то возвращают, но ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year =  Method3();
// Console.WriteLine(year);



// Вид 4 - методы, которые что-то принимают и что-то возвращают


string Method4(int count, string text) // строку text компануем count раз
{
    int i = 0;
    string result = String.Empty; // String.Empty  

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "efe");
Console.WriteLine(res);

// Цикл for - цикл со счетчиком, в себе собирает все 

// for(int i = 0; i<10;i++)
// {
//     Console.WriteLine();
// }

// Используем в методе 4 цикл for

// string Method4(int count, string text) // строку text компануем count раз
// {
//     // int i = 0;
//     string result = String.Empty; // String.Empty  
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "efe");
// Console.WriteLine(res);


// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10, j++)
//     {
//         Console.WriteLine(i * j)
//     }
//     Console.WriteLine()
// }


// Таблица умножения

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}"); // интерполяция строк
//     }
//     Console.WriteLine();
// }


// Дан текст. 
// В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//     + "ежели бы вас послали вместо нашего милого Винценгероде,"
//     + "вы бы взяли приступом согласие прусского короля. "
//     + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qaefge" 
//             012345
// s[3] = f 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|'); // 
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

// алгоритм сортировки методом выбора, метод мин макса
// 1. Найти позицию минимального элемента в неосортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неосортированные элементы

// int[] arr = {1, 5, 2, 8, 1, 3, 4, 6, 7 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array) // сортировка по возрастанию элементов массива
// {
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }

// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);



