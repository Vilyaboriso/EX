//поиск позиции нужного элемента. Команда break в цикле останавливает счетчик, если несколько позиций одинаковых

int[] array = {1, 12, 3, 50, 50, 77, 33, 1};

int n = array.Length;
int find = 50;

int index = 0;

while (index <n)
{
    if(array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //              0   1    2   3   4    5   6  7  8

// int[] array = { 11, 22, 15, 99, 107, 88, 96, 1, 0 };
// array[0] = 12;
// Console.WriteLine(array[4]);




  

