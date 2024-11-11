// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

//Find the Minimum value 
Console.WriteLine("***LINQ Lab***");

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
int minValue = nums.Min(x => x);
Console.WriteLine("Minimum Value is "+minValue);

//Find the Maximum value
int maxValue = nums.Max(x => x);
Console.WriteLine("Maximum value is " + maxValue);

//Find the Maximum value less than 10000
maxValue = nums.Where(x => x < 10000).Max();
Console.WriteLine("Maximum value less then 10000 is " + maxValue);

//Find all the values between 10 and 100
List<int> listValues = new List<int>();
listValues = nums.Where(x => x > 10 && x < 100).ToList();
Console.WriteLine("Values between 10 and 100");
foreach (int values in listValues)
{
    Console.WriteLine(values);
}

//Find all the Values between 100000 and 999999 inclusive
listValues = nums.Where(x => x >= 100000 && x <= 999999).ToList();
Console.WriteLine("Values between 100000 and 999999");
foreach (int values in listValues)
{
    Console.WriteLine(values);
}
 
//Count all the even numbers in the arrays
int numCount = nums.Count(x => x % 2 == 0);
Console.WriteLine($"Arrays has {numCount} even number in the list");