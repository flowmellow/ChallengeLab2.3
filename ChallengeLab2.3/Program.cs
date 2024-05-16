//3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.

namespace ChallengeLab2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts1 = 0;
            int attempts2 = 0;
            string userID;
            string userID2;
            string password;
            string password2;

            do
            {
                Console.WriteLine("set your user ID");
                userID = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please re-enter your user ID");
                userID2 = Console.ReadLine();
                Console.WriteLine();

                attempts1++;

            } while (userID != userID2 && attempts1 < 3);

            if (userID != userID2)
            {
                Console.WriteLine("Something went wrong, ensure both user IDs match");
                return;
            }

            do
            {
                Console.WriteLine("set your user password");
                password = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("re-enter your user password");
                password2 = Console.ReadLine();
                Console.WriteLine();

                attempts2++;

            } while (password != password2 && attempts2 < 3);            

            if (password != password2)
            {
                Console.WriteLine("Something went wrong, ensure both passwords match");
                return;
            }

            if (password == password2 && userID == userID2) 
            {
                Console.WriteLine("Access granted, great job typing.");
            }
        }

    }
}
