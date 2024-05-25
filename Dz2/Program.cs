using System; 
 
class Program 
{ 
    static void Main() 
    { 
        int[] myArray = { 1, 99, 4, 3, 7 }; 
 
        Console.WriteLine("Элементы массива в обратном порядке:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    } 
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 
}