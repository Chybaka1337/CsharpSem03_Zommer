uint.TryParse(Console.ReadLine(), out uint upBound);

for(int i = 1; i <= upBound; i++) 
{
    Console.Write(Math.Pow(i, 3) + "\t");
}