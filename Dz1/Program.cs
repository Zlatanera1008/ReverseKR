using System; 
 
class Program 
{ 
    static void Main() 
    { 
        Console.Write("Введите значение M: "); 
        int M = Convert.ToInt32(Console.ReadLine()); 
 
        Console.Write("Введите значение N: "); 
        int N = Convert.ToInt32(Console.ReadLine()); 
 
        PrintNaturalNumbers(M, N); 
    } 
 
    static void PrintNaturalNumbers(int N, int M) 
    { 
        if (N <= M) 
        {
            if (N > 0)
            {
            Console.Write(N + " "); 
            PrintNaturalNumbers(N + 1, M);
            }
            else PrintNaturalNumbers(N + 1, M );
        } 
    } 
}