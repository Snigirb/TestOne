Console.WriteLine("Enter size of string array");
int size = Convert.ToInt32(Console.ReadLine());﻿

string [] CreateStringArray(int size){
  string [] array = new string [size];
    for (int i = 0;i<size;i++){
        Console.Write($"Enter {i+1} element: ");
        array[i] = new (Console.ReadLine());
    }
    return array;
}
