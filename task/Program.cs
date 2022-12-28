// Задача:Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
//[“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;
Clear();

string[] Array1 = new string[5] {"Russia", "Denmark", "Kazan", "Pskov", "123"};
string[] newArray = new string[Array1.Length];
void SecondArray(string[] Array1, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        newArray[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

SecondArray(Array1, newArray);
PrintArray(newArray);