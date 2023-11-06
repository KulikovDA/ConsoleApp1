try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
      double S = 0;
    for (int k = 1; n <= k; k++)
    {
            if (k != (-2)) S += Math.Pow((-1),k)*(Math.Pow(k,3)-27)/(3*(k+2));
    }
    Console.WriteLine($"S={S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
