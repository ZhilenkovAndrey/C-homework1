//HomeWork1//


// Task2//

// int max;

// Console.Write("Enter a num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 >= num2) 
//     Console.WriteLine($"max = {num1}");
// else
//     Console.WriteLine($"max = {num2}"); 
    

//Task3//

Console.Write("Enter a num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a num1: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) 
    Console.WriteLine($"max = {num1}");

if (num2 > num1 && num2 >num3)    
    Console.WriteLine($"max = {num2}");

else
     Console.WriteLine($"max = {num3}"); 