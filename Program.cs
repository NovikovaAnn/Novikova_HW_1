// Console.Write("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2){
//     Console.Write(num1 + " is a maximum number " + num2 + " is a minimum number");
// }
// else
// {
//     Console.Write(num2 + " is a maximum number " + num1 + " is a minimum number");
// }


// Console.Write("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.WriteLine(max + " is a maximum number");


// Console.Write("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2==0) {
// Console.WriteLine("The number is even");
// }
// else {
// Console.WriteLine("The number is odd");
// }


Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= n) {
    if (current % 2==0) {
Console.WriteLine(current);
    }
current ++;
}