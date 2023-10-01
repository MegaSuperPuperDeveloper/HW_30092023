// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Функция заполняет массив в соответствии с ее длиной
int[] PullArray(int[] array) {
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(1, 100);
        if(i + 1 == array.Length) {
            Console.Write($"{array[i]} ");
        } else {
            Console.Write($"{array[i]}, ");
        }
    }
    return array;
}

void PrintArray(int[] array) {
    int length = array.Length;
    Console.Write("[");
    for(int i = 0; i < length; i++) {
        if(i + 1 == length ) {
            Console.Write($"{array[i]}]");
        } else {
            Console.Write($"{array[i]}, ");
        }
    }
}

var length = new Random().Next(1, 8);
int[] array = new int[length];
PullArray(array);
Console.Write(" -> ");
PrintArray(array);