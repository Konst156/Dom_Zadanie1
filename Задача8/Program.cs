Console.Clear();

Console.WriteLine("Введите число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));
int b = 2;

 while(b <= N)
 {
    Console.Write($"{b} ");
    b = b + 2;
    }

