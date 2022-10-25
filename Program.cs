namespace HomeWorkCollections3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool isProgramOn = true;
            string? userInput = null;
            string sumCommand = "sum";
            string exitCommand = "exit";

            while (isProgramOn)
            {
                Console.WriteLine("Введите число: ");
                userInput = Console.ReadLine();

                if (userInput == sumCommand)
                {
                    int sum = 0;

                    foreach (int number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine("Сумма чисел равна: " + sum);
                }
                else if (userInput == exitCommand)
                {
                    isProgramOn = false;
                    Console.Clear();
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("До свидания!");
                }
                else
                {
                    int convertStringToNumber = 0;

                    if (int.TryParse(userInput, out convertStringToNumber))
                    {
                        numbers.Add(convertStringToNumber);
                    }
                }
            }
        }

    }
}