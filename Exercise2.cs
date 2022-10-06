var input1 = Console.ReadLine();
var input2 = Console.ReadLine();
var input3 = Console.ReadLine();
var num1 = int.Parse(input1);
var num2 = int.Parse(input2);
var num3 = int.Parse(input3);
int max = num1;
 if (num2 > max) {
    max = num2;
 }
 if (num3 > max) {
    max = num3;
 }
 Console.Write(max);