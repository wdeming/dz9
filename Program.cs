// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
void Zadacha64(){
    Console.WriteLine();
    Console.WriteLine("Задача 64:");
    int count = 5;
    int number = 25;
    Recursion(count,number);

    void Recursion(int count, int number){
        if (count > number) return;
        if (count%3 == 0){
            Console.Write(count + " ");
        }
        count++;    
        Recursion(count,number);    
    }  
}
Zadacha64();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Zadacha66(){
    Console.WriteLine("\n");
    Console.WriteLine("Задача 66:");
    int count = 1;
    int number = 15;
    int sum = 0;
    Recursion(count,number);

    void Recursion(int count, int number){
        if (count > number) return;
        sum += count;
        count++;    
        Recursion(count,number);    
    }
    Console.WriteLine(sum);   
}
Zadacha66();