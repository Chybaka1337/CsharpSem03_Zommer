int length = 3;
double[] firstPoint =  new double[length];
Console.WriteLine("input first point");
for(int i = 0; i < firstPoint.Length; i++)
{
    Console.Write($"coord {i + 1} ");
    double.TryParse(Console.ReadLine(), out firstPoint[i]);
}

double[] secondPoint = new double[length];
Console.WriteLine("input second point");
for(int i = 0; i < secondPoint.Length; i++) 
{
    Console.Write($"coord {i + 1} ");
    double.TryParse(Console.ReadLine(), out secondPoint[i]);
}

double distance = Math.Sqrt(Math.Pow(firstPoint[0] - secondPoint[0], 2) + Math.Pow(firstPoint[1] - secondPoint[1], 2) + Math.Pow(firstPoint[2] - secondPoint[2], 2));
Console.WriteLine(Math.Round(distance, 2));