namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I do not prefer math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "pe" :
                case "p.e" :
                    Console.WriteLine("P.E is fun!");
                    break;
                case "history":
                    Console.WriteLine("History is my fav too");
                    break;
                default:
                    Console.WriteLine("Thats not a class!");
                    break;
                    
            }
        }
    }
}