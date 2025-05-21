namespace HappySadNumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int OGnumber = number;
        int count = 0;
        bool found = false;

        while (count < 100)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum = sum + (digit * digit);
                number = number / 10;
            }

            number = sum;
            count++;

            if (number == 1)
            {
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine(OGnumber + " is a Happy number");
        }
        else
        {
            Console.WriteLine(OGnumber + " is a Sad number");
        }
    }
}
