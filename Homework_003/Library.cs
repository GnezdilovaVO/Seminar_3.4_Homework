public static class Library
{
    public static int getNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void fillArray(int[] collection)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            collection[i] = new Random().Next(1, 100);
        }
    }
    public static string printArray(int[] coll)
        {
            string massiv = String.Empty;
            for(int j = 0; j < coll.Length; j++)
            {
                if (j == coll.Length-1)
                {massiv = massiv + coll[j];}
                else
                {massiv = massiv + coll[j] + ", ";}
            }
            return massiv;
        } 
}