public static class Library 
{
    public static int getNumber(string s)
    {
        Console.WriteLine(s);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int getDegree(int number, int degree)
    {
        int reserve = number;
        for (int i = 0; i < degree-1; i++)
        {
            number = number*reserve;
        }
        return number;
    }
}