namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования методов
            int[] phoneNumbers = { 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string phoneNumber = CreatePhoneNumber(phoneNumbers);
            Console.WriteLine($"Phone number: {phoneNumber}");

            string trimmedString = TrimString("Writing code is fun", 14);
            Console.WriteLine($"Trimmed string: {trimmedString}");

            long squaredDigits = SquareDigits(5678);
            Console.WriteLine($"Squared digits: {squaredDigits}");

            string[] likes = { "Alex", "Jacob", "Mark", "Max" };
            string likesText = Likes(likes);
            Console.WriteLine(likesText);
        }

        static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10)
            {
                throw new ArgumentException("Array must contain exactly 10 digits.");
            }

            return string.Format("+7 ({0}{1}{2}) {3}{4}{5}-{6}{7}-{8}{9}",
                numbers[0], numbers[1], numbers[2],
                numbers[3], numbers[4], numbers[5],
                numbers[6], numbers[7], numbers[8], numbers[9]);
        }

        static string TrimString(string phrase, int len)
        {
            if (phrase.Length <= len)
            {
                return phrase;
            }

            if (len <= 3)
            {
                return phrase.Substring(0, len) + "...";
            }

            return phrase.Substring(0, len - 3) + "...";
        }

        static long SquareDigits(long n)
        {
            string squaredDigits = "";
            foreach (char digit in n.ToString())
            {
                int num = int.Parse(digit.ToString());
                squaredDigits += (num * num).ToString();
            }
            return long.Parse(squaredDigits);
        }

        static string Likes(string[] names)
        {
            int count = names.Length;

            if (count == 0)
            {
                return "no one likes this";
            }
            else if (count == 1)
            {
                return $"{names[0]} likes this";
            }
            else if (count == 2)
            {
                return $"{names[0]} and {names[1]} like this";
            }
            else if (count == 3)
            {
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            else
            {
                return $"{names[0]}, {names[1]} and {count - 2} others like this";
            }
        }
    }
}
