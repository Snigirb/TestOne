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

int CountArray(string[] array){
  int count = 0;
    for (int i=0;i<array.Length;i++){
      if (array[i].Length<=3){
        count++;}
    }
  return count;
}

void ShowArray(string[] array,int count){
  string []arrayMult = new string [count];
  int j=0;
    for (int i=0;i<array.Length;i++){
        if (array[i].Length<=3){
        arrayMult[j]= new (array[i]);
        j++;}
      }
    Console.WriteLine("["+String.Join(";",arrayMult)+"]");
}

string [] newArray = CreateStringArray(size);
int count = CountArray(newArray);
ShowArray(newArray,count);
