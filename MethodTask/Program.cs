public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] TaskMinArray = { 3, 6, 43, 8, 2, 75, 35, 73, 653, 1, 4532 };
        Console.WriteLine("Minimal number: " + GetMin(TaskMinArray));
        Console.WriteLine("Area of circle: " + Area(3));
        Console.WriteLine("Area of rectagle: " + Area(3, 4));
        Console.WriteLine("Area of rectangular parallelepiped: " + Area(3, 4, 5));
        Console.WriteLine("Area of circle in triangle: " + Area(3, 4, 5, 6));







    }

    public static int GetMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    public static int Area(int r)
    {
        return 3 * r * r;
    }
    public static int Area(int a, int b)
    {
        return a * b;
    }
    public static int Area(int a, int b, int c)
    {
        int s = 2 * (a * b + a * c + b * c);
        return s;
    }
    public static int Area(int a, int b, int c, int r)
    {
        int p = (a + b + c) / 2;
        int s = p * r;
        return s;
    }



}