namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "science":
                    Console.WriteLine("Science is a tough subject");
                    break;

                case "english":
                    Console.WriteLine("English is an interesting subject");
                    break;

                case "history":
                    Console.WriteLine("History is a good subject");
                    break;

                default:
                    Console.WriteLine($"Sounds fun I have never taken {subject} before.");
                    break;  

            }
        }
    }
}