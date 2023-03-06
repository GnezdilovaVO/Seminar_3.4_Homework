public static class Library 
{
    public static int getNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int getSum (int numb)
    {
        int sum = 0;
        while(numb>0)
        {
            sum = sum + numb%10;
            numb = numb/10;
        }
        return sum;
    }
}