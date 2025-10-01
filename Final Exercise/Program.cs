// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please give me a number of seconds.");
int seconds = int.Parse(Console.ReadLine());
float totalDays = (float)seconds / 86400;

int days = seconds / (24*3600);

seconds %= 24 * 3600; //get the remainder of seconds after removing number of days
int hours = seconds / 3600; //one hour consists of 3600 seconds

seconds %= 3600; //get the remaining seconds by removing the hours
int minutes = seconds / 60;

seconds %= 60;

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");

Console.WriteLine($"{days}.{hours}.{minutes}.{seconds}");

Console.WriteLine($"In total that's {totalDays} days.");
