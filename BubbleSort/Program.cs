
public class Program
{
    public static void Main()
    {
        int[] arrNumbers = { 9, 0, 3, 4, 2, 10, 8, 11, 1, 22, 1 };

        for (int i = 0; i < arrNumbers.Length - 1; i++)
        {
            for (int j = 1; j < arrNumbers.Length - i; j++)
            {
                if (arrNumbers[j - 1] > arrNumbers[j])
                {
                    int num1 = arrNumbers[j - 1];
                    int num2 = arrNumbers[j];

                    arrNumbers[j] = num1;
                    arrNumbers[j - 1] = num2;

                    Console.WriteLine(arrNumbers[j - 1]);
                }
                else
                {
                    Console.WriteLine(arrNumbers[j - 1]);
                }
            }
            Console.WriteLine();
        }
    }
}
