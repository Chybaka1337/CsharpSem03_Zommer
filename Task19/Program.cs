int.TryParse(Console.ReadLine(), out int number);

int length = 0;
int buff = number;
while(buff != 0) 
{
    length++;
    buff /= 10;
}

for (int i = 0; i < length / 2; i++) 
{
    int lowDigit = number / (int) Math.Pow(10, i) % 10;
    int upDigit = number / (int) Math.Pow(10, length - i - 1) % 10;
    // Console.WriteLine(lowDigit + " " + upDigit);
    if(lowDigit != upDigit) 
    {
        Console.WriteLine("нет");
        return;
    }
}

Console.WriteLine("да");