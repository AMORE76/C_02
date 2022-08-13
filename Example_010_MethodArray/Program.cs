/*Есть массив array, в котором n элементов. Найти элемент, совпадающий с
некоторым значением, который определяет пользователь.*/

/*               0   1   2   3   4   5   6   7   8 */
int[] array = { 11, 21, 31, 41, 15, 61, 11, 18, 19 };

int n = array.Length;
int find = 11;
int index = 0;


while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    else
    {
        Console.WriteLine("Number is absent");
        break;
    }

    index = index + 1;
}
