
namespace Lab1
{

    class Lab1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки:");
            string input = Console.ReadLine();

            string cleanedInput = RemoveSpacesAndToLower(input);

            bool isPalindrome = IsPalindrome(cleanedInput);

            if (isPalindrome)
            {
                Console.WriteLine("Это палиндром!");
            }
            else
            {
                Console.WriteLine("Это не палиндром.");
            }
        }

        static string RemoveSpacesAndToLower(string str)
        {
            return str.Replace(" ", "").Replace(",", "")
                .Replace("?", "").Replace("!", "")
                .Replace(".", "").ToLower();
        }

        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length/ 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}