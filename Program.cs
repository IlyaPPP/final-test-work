/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [ */


string[] array1 = new string[4];             // создание массива строк
int smallerThree = 0;                      // счетчик строк с количеством символов меньше 3
for (int i = 0; i < array1.Length; i++)      // цикл для ввода строк
{
    Console.WriteLine("Введите строку: ");
    array1[i] = Console.ReadLine()!;
    if (array1[i].Length <= 3) smallerThree++;
}
Console.Write($"{array1[0]}, {array1[1]}, {array1[2]}, {array1[3]} -> ");       // вывод строк
AddSmallerThree();                                       // вызов функции AddSmallerThree()
void AddSmallerThree()                                   // функция AddSmallerThree()
{
    int position = 0;                                           // счетчик позиции нужного элемента
    string[] array2 = new string[smallerThree];                  // создание нового массива
    for (int i = 0; i < array1.Length; i++)                // цикл для нахождения позиции
    {
        if (array1[i].Length <= 3)                         // условие добавления
        {
            array2[i - position] = array1[i];                     // добавление в новый массив элементов
            Console.Write($"{array2[i - position]}, ");          // вывод этого элемента
        }
        else position++;                                        // счетчик увеличения позиции
    }
}