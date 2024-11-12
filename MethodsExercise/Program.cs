namespace MethodsExercise
{
    public class Program
    {
        public static void MadLibLog()
        {
            Console.WriteLine("What is your name?");
            string randomName = Console.ReadLine();
            Console.WriteLine($"Hello, {randomName}! What is your favorite color?"); //color question
            //color response memory
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("I'll keep that in mind! What is your favorite animal?"); //Favorite Animal
            //Favorite Animal response memory
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Awesome! What is your favorite band?"); //favorite Band
            //Favorite band Memory
            string favoriteBand = Console.ReadLine();
            // response for last question then story production
            Console.WriteLine($"Thank you, {randomName}! Let's make a story of your answers!");
            Console.WriteLine($"One day {randomName} turned into a {favoriteAnimal} and realized they had magically put on a T-shirt with {favoriteBand} on it and was {favoriteColor}. What a crazy day!");



        }

        
            
        
        static void Main(string[] args)
        {
            MadLibLog();
            
            
        }
    }
}
