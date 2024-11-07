
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите значение x (в радианах): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество членов n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        double sum = 0.0;
        for (int i = 1; i <= n; i++)
        {
            
            double term = Math.Pow(-1, i - 1) * Math.Cos(i * x) / (i * i);
            sum += term;
        }

       
        Console.WriteLine($"Сумма ряда S(x) для n={n} и x={x} равна: {sum}");
    }
}
