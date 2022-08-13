/* Перепишем код с
использованием генератора псевдослучайных чисел с использованием методов. 
Взять метод, передать в него массив и
заполнить массив нужным количеством элементов. 
Описать метод,
который будет выводить все элементы по порядку. 
Превратить наш код поиска нужного
индекса в метод. */

int[] array = new int[10];

/*«Cоздай новый массив, где будет 10 элементов». По
умолчанию, он будет наполнен нулями*/

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

{int count = col.Length;
int position = 0;

while (position < count)

{Console.WriteLine(col[position]);
position++;}
}

FillArray(array);
PrintArray(array);

/* Определен массив из 10 элементов. Вызван метод FillArray,
который заполнил массив, вызван метод PrintArray, который распечатал массив.*/