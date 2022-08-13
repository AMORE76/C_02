/* 

Теперь разберёмся, для чего используется ключевое слово void. 
Дело в том, что в контексте
языка С# есть методы, которые могут возвращать или не возвращать 
какие-то значения. 
Если метод ничего не возвращает, он называется void-методом.

Метод IndexOf
Требуется описать метод, отличный от void. 
Он будет возвращать позицию, то есть index. 
Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив
collection и какой-то элемент find.*/

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

// Оформляем метод void, который будет печатать массив.

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;

    while (position < count)

    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

Console.WriteLine();
FillArray(array);
array[4] = 4;
array[5] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);

/*{if (find > 9)
Console.WriteLine("Число не найдено");}*/

Console.WriteLine(pos);

